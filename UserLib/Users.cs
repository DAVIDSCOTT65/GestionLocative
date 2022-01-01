using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLib
{
    public class Users
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public string Sexe { get; set; }
        public DateTime Dob { get; set; }
        public string Telepone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Lieu { get; set; }
        public Image Photo { get; set; }
        public void TestConn()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
        }
        private byte[] ConvertToByteImage(Image img)
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(img);
            byte[] bytImage;
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytImage = ms.ToArray();
            ms.Close();
            return bytImage;
        }
        public int Nouveau()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(id) as LastId from Bailleur";
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["LastId"] == DBNull.Value)
                        Id = 1;
                    else
                        Id = Convert.ToInt32(dr["LastId"].ToString()) + 1;
                }
                dr.Dispose();
            }
            return Id;
        }
        public void SaveDatas(Users a, string action)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                if(action == "INSERT")
                    cmd.CommandText = "INSERT INTO Bailleur VALUES(@id,@nomComplet,@sexe,@dob,@telephone,@email,@userName,@pass,@lieu)";
                else
                {
                    cmd.CommandText = "UPDATE Bailleur SET nomComplet=@nomComplet,sexe=@sexe,dob=@dob,telephone=@telephone,email=@email,userName=@userName,pass=@pass,lieu=@lieu WHERE id=@id";
                    
                }
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "id", 11, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "nomComplet", 200, DbType.String, a.NomComplet));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "sexe", 1, DbType.String, a.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "dob", 20, DbType.Date, a.Dob));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "telephone", 20, DbType.String, a.Telepone));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "email", 100, DbType.String, a.Email));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "userName", 30, DbType.String, a.UserName));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "pass", 200, DbType.String, a.Pass));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "lieu", 200, DbType.String, a.Lieu));

                cmd.ExecuteNonQuery();

                MessageBox.Show("User Save", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int LoginTest(Users u)
        {
            int count = 0;
            try
            {
                TestConn();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Bailleur WHERE Pass='"+u.Pass+ "' AND UserName='" + u.UserName+"' COLLATE NOCASE";


                    IDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Id = Convert.ToInt32(dr["Id"].ToString().Trim());
                        NomComplet = dr["NomComplet"].ToString().Trim();
                        Sexe = dr["Sexe"].ToString().Trim();
                        UserName = dr["Username"].ToString().Trim();
                        Dob = Convert.ToDateTime(dr["dob"].ToString());
                        Telepone = dr["telephone"].ToString();
                        Email = dr["Email"].ToString();
                        Lieu = dr["Lieu"].ToString();
                        Pass = dr["Pass"].ToString();

                        count += 1;
                    }
                    dr.Dispose();
                    if (count == 1)
                    {
                        UserSession.GetInstance().Id = Id;
                        UserSession.GetInstance().NomComplet = NomComplet;
                        UserSession.GetInstance().Sexe = Sexe;
                        UserSession.GetInstance().Dob = Dob;
                        UserSession.GetInstance().Email = Email;
                        UserSession.GetInstance().Phone = Telepone;
                        UserSession.GetInstance().UserName = UserName;
                        UserSession.GetInstance().Pass = Pass;
                        UserSession.GetInstance().Lieu = Lieu;
                    }
                    else
                    {
                        MessageBox.Show("Echec de Connexion.", "Message Serveur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return count;
        }
    }
}
