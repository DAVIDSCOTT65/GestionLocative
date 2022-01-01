using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLib;

namespace LocationLib
{
    public class Location
    {
        public int Id { get; set; }
        public int RefAppartement { get; set; }
        public int RefLocataire { get; set; }
        public DateTime DebutContrat { get; set; }
        public DateTime FinContrat { get; set; }
        //public string UserSession { get; set; }
        public int Garantie { get; set; }
        public DateTime DateSave { get; set; }
        public string Periodicite { get; set; }
        public string LoyerPayable { get; set; }
        public string LoyerExigible { get; set; }
        public int Delais { get; set; }

        public string Nom { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adresse { get; set; }
        public string Locale { get; set; }
        public float Montant { get; set; }
        public string Duree { get; set; }
        public int DayRest { get; set; }
        public float Total { get; set; }
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
                cmd.CommandText = "SELECT MAX(id) as LastId from Location";
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
        
        public int BailExpirer()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT count(id) Bail_Expirer FROM Affichage_Details_Location WHERE fincontrat < CURRENT_DATE";
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Bail_Expirer"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["Bail_Expirer"].ToString());
                }
                dr.Dispose();
            }
            return Id;
        }
        public int CountLoyerAValider()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(Id) CountData from Affichage_Loyer_A_Encaisser";
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["CountData"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["CountData"].ToString());
                }
                dr.Dispose();
            }
            return Id;
        }
        public void VerifyLocation(int lastid)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT FinContrat FROM Affichage_Details_Location WHERE fincontrat > CURRENT_DATE AND id=" + lastid + "";
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["FinContrat"] != DBNull.Value)
                        MessageBox.Show("La maison est occupée jusqu'au "+ dr["FinContrat"].ToString() + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    SaveDatas();
                }
                dr.Dispose();   
            }
        }
        public void SaveDatas()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Location VALUES(@Id,@RefAppartement,@RefLocataire,@DebutContrat,@FinContrat,@UserSession,CURRENT_DATE,@Periodicite,@Loyer_Payable,@Loyer_Exigible,@Delais_paiement_avant_impayer,@garantie_en_mois)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefAppartement", 11, DbType.Int32, RefAppartement));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefLocataire", 11, DbType.Int32, RefLocataire));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "DebutContrat", 20, DbType.Date, DebutContrat));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "FinContrat", 20, DbType.Date, FinContrat));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "UserSession", 200, DbType.String, UserSession.GetInstance().NomComplet));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Periodicite", 255, DbType.String, Periodicite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Loyer_Payable", 255, DbType.String, LoyerPayable));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Loyer_Exigible", 255, DbType.String, LoyerExigible));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Delais_paiement_avant_impayer", 5, DbType.Int32, Delais));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Garantie_en_mois", 5, DbType.Int32, Garantie));

                cmd.ExecuteNonQuery();
            }
        }
        public List<Location> GetLocation(string requette)
        {
            List<Location> lst = new List<Location>();

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = requette;

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatasLocataire(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Location> GetLoyerAEncaisser()
        {
            List<Location> lst = new List<Location>();

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Loyer_A_Encaisser";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatasLocataire(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<Location> Research(string recherche)
        {
            List<Location> lst = new List<Location>();
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Loyer_A_Encaisser WHERE (Nom LIKE '%" + recherche + "%' OR Nom LIKE '%" + recherche + "' OR Nom LIKE '" + recherche + "%' OR Locale LIKE '%" + recherche + "%')";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDatasLocataire(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        public List<Location> ResearchLoyer_A_Encaisser(string recherche)
        {
            List<Location> lst = new List<Location>();
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Loyer_A_Encaisser WHERE (Nom LIKE '%" + recherche + "%' OR Nom LIKE '%" + recherche + "' OR Nom LIKE '" + recherche + "%' OR Locale LIKE '%" + recherche + "%')";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDatasLocataire(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private Location GetDatasLocataire(IDataReader rd)
        {
            Location A = new Location();

            A.Id = Convert.ToInt32(rd["Id"].ToString());
            A.RefAppartement = Convert.ToInt32(rd["refappartement"].ToString());
            A.RefLocataire = Convert.ToInt32(rd["reflocataire"].ToString());
            A.Nom = rd["Nom"].ToString();
            A.Email = rd["email"].ToString();
            A.Phone = rd["telephone"].ToString();
            A.Adresse = rd["Adresse"].ToString();
            A.Locale = rd["locale"].ToString();
            A.Garantie = int.Parse(rd["garantie_en_mois"].ToString());
            A.Montant = float.Parse(rd["montantparmois"].ToString());
            A.Total = float.Parse(rd["Totale"].ToString());
            A.DebutContrat = Convert.ToDateTime(rd["DebutContrat"].ToString());
            A.FinContrat = Convert.ToDateTime(rd["FinContrat"].ToString());
            A.Duree = "Du "+(A.DebutContrat.ToShortDateString() + " Au " + A.FinContrat.ToShortDateString());
            A.DayRest = DateTime.Today.CompareTo(A.FinContrat);
            A.DateSave = Convert.ToDateTime(rd["dateSave"].ToString());


            return A;
        }
    }
}
