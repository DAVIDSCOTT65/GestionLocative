using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationLib
{
    public class Locataire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public DateTime DOB { get; set; }
        public string EtatCivil { get; set; }
        public string Profession { get; set; }
        public int NbrEnfant { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime DateSave { get; set; }
        public void TestConn()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
        }
        public int Nouveau()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(id) as LastId from Locataire";
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
        public void GetNamesLocataires(ComboBox cmb)
        {
            try
            {
                TestConn();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT (nom || ' ' || postnom || ' ' || prenom) Noms FROM locataire";
                    cmd.CommandType = CommandType.Text;

                    IDataReader rd = cmd.ExecuteReader();
                    cmb.Items.Clear();
                    cmb.Items.Add("");

                    while (rd.Read())
                    {
                        string de = rd["Noms"].ToString();
                        cmb.Items.Add(de);
                    }
                    rd.Close();
                    rd.Dispose();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Une exception est survenue : " + ex.Message);
            }
        }
        public void SaveDatas(Locataire a)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Locataire VALUES(@Id,@Nom,@Postnom,@Prenom,@Sexe,@Dob,@EtatCivil,@Profession,@NbreEnfant,@Telephone,@Email,CURRENT_DATE)";
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Nom", 100, DbType.String, a.Nom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Postnom", 100, DbType.String, a.Postnom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Prenom", 100, DbType.String, a.Prenom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Sexe", 10, DbType.String, a.Sexe));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Dob", 20, DbType.Date, a.DOB));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "EtatCivil", 50, DbType.String, a.EtatCivil));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Profession", 50, DbType.String, a.Profession));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "NbreEnfant", 11, DbType.Int32, a.NbrEnfant));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Telephone", 20, DbType.String, a.Telephone));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Email", 100, DbType.String, a.Email));

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Locatire Save", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
