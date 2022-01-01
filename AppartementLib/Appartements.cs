using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSingleConnexion;
using ParametreLibrary;
using System.Data;
using System.Windows.Forms;
using ObjectDesignLib;

namespace AppartementLib
{
    public class Appartements
    {
        public int Id { get; set; }
        public int RefType { get; set; }
        public int Salon { get; set; }
        public int Chambre { get; set; }
        public int Cuisine { get; set; }
        public int Toilette { get; set; }
        public float MontantParMois { get; set; }
        public int Garantie { get; set; }
        public string Adresse { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public int Capacite { get; set; }
        public DateTime DateSave { get; set; }
        public string Designation { get; set; }
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
                cmd.CommandText = "SELECT MAX(id) as LastId from Appartements";
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
        public void GetNameAppart(ComboBox cmb)
        {
            try
            {
                TestConn();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT nom FROM appartements";
                    cmd.CommandType = CommandType.Text;

                    IDataReader rd = cmd.ExecuteReader();
                    cmb.Items.Clear();
                    cmb.Items.Add("");

                    while (rd.Read())
                    {
                        string de = rd["nom"].ToString();
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
        public int RetourId(string valeur)
        {
            try
            {
                TestConn();
                using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id FROM TypeAppartement WHERE Designation='"+valeur+"'";

                    IDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        RefType = int.Parse(rd["Id"].ToString());
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
            return RefType;
        }
        public void SaveDatas(Appartements a,string statut)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                switch (statut)
                {
                    case "insert":
                        cmd.CommandText = "INSERT INTO Appartements VALUES(@Id,@RefType,@Salon,@Chambre,@Cuisine,@Toilette,@Montant,@Garantie,CURRENT_DATE,@adresse,@nom,@ville,@pays,@capacite)";
                        break;
                    case "update":
                        cmd.CommandText = "UPDATE Appartements SET RefType=RefType,Salon=@Salon,Chambre=@Chambre,Cuisine=@Cuisine,Toilette=@Toilette,MontantParMois=@Montant,Garantie=@Garantie,Adresse=@Adresse,Nom=@Nom,Ville=@Ville,Pays=@Pays,Capacite=@Capacite WHERE Id=@Id";
                        break;
                }
                
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefType", 11, DbType.Int32, a.RefType));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Salon", 11, DbType.Int32, a.Salon));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Chambre", 11, DbType.Int32, a.Chambre));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Cuisine", 11, DbType.Int32, a.Cuisine));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Toilette", 11, DbType.Int32, a.Toilette));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Montant", 11, DbType.Double, a.MontantParMois));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Garantie", 11, DbType.Int32, a.Garantie));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Adresse", 200, DbType.String, a.Adresse));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Nom", 200, DbType.String, a.Nom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Ville", 200, DbType.String, a.Ville));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Pays", 200, DbType.String, a.Pays));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Capacite", 11, DbType.Int32, a.Capacite));

                cmd.ExecuteNonQuery();   
            }
        }
        public List<Appartements> GetLocale()
        {
            List<Appartements> lst = new List<Appartements>();

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Details_Local";
                
                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatasAppart(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Appartements> Research(string recherche)
        {
            List<Appartements> lst = new List<Appartements>();
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Details_Local WHERE (Nom LIKE '%" + recherche + "%' OR Nom LIKE '%" + recherche + "' OR Nom LIKE '" + recherche + "%')";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDatasAppart(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Appartements GetDatasAppart(IDataReader rd)
        {
            Appartements A = new Appartements();


            A.Id = Convert.ToInt32(rd["Id"].ToString());
            A.Salon = int.Parse(rd["Salon"].ToString());
            A.Chambre = int.Parse(rd["Chambre"].ToString());
            A.Cuisine = int.Parse(rd["Cuisine"].ToString());
            A.Toilette = int.Parse(rd["Toilette"].ToString());
            A.MontantParMois = float.Parse(rd["MontantParMois"].ToString());
            A.Garantie = int.Parse(rd["Garantie"].ToString());
            A.Adresse = rd["Adresse"].ToString();
            A.Nom = rd["Nom"].ToString();
            A.Ville = rd["Ville"].ToString();
            A.Pays = rd["Pays"].ToString();
            A.Designation = rd["Designation"].ToString();
            return A;
        }
    }
}
