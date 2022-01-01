using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaiementLib
{
    public class PEau
    {
        int i = 0;
        public int Num { get; set; }
        public int Id { get; set; }
        public int RefLocation { get; set; }
        public float QteCubage { get; set; }
        public float PuCube { get; set; }
        public float Total { get; set; }
        public DateTime DateSave { get; set; }
        public DateTime DebutMois { get; set; }
        public DateTime FinMois { get; set; }
        public string Periode { get; set; }
        public string Nom { get; set; }
        public string Locale { get; set; }
        public string Adresse { get; set; }
        public string Motif { get; set; }
        public string Phone { get; set; }
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
                cmd.CommandText = "SELECT MAX(id) as LastId from PEau";
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
        public float GetSommePaiements(int refLoation)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT SUM(Tota) Somme FROM Affichage_Paiement_Eau WHERE IdLocation=@IdLocation";

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "IdLocation", 11, DbType.Int32, refLoation));

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["Somme"] == DBNull.Value)
                        Total = 0;
                    else
                        Total = float.Parse(dr["Somme"].ToString());
                }
                dr.Dispose();
            }
            return Total;
        }
        public DateTime GetDateDebutMois(int refLocation)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT garantie_en_mois," +
                                    "CASE \n" +
                                    "   WHEN (SELECT MAX(Id) FROM peau WHERE reflocation = " + refLocation + ") IS NULL \n" +
                                    "       THEN debutcontrat \n" +
                                    "ELSE \n" +
                                    "   DATE(location.debutcontrat, '+' || IIF((SELECT COUNT(Id) FROM peau WHERE reflocation = " + refLocation + ") = garantie_en_mois, NULL, (SELECT COUNT(Id) FROM peau WHERE reflocation = " + refLocation + ")) || ' MONTH') \n"
                                   + "END DebuMois\n" +
                                   " FROM location WHERE Id = " + refLocation + "";
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["DebuMois"] == DBNull.Value)
                        MessageBox.Show("Le locataire n'a pas de dette d'eau pour ce contrat");
                    else
                        DebutMois = Convert.ToDateTime(dr["DebuMois"].ToString());
                }
                dr.Dispose();
            }
            return DebutMois;
        }
        public int CountPaiementAValider()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(Id) CountData from PEau WHERE Encaissement='Non' COLLATE NOCASE";
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["CountData"] == DBNull.Value)
                        Id = 0;
                    else
                        Id = Convert.ToInt32(dr["CountData"].ToString());
                }
                dr.Dispose();
                dr.Close();
            }
            return Id;
        }
        public void SaveDatas(PEau a)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO PEau VALUES(@Id,@RefLocation,@QteCubage,@PuCube,@DebutMois,@FinMois,CURRENT_DATE,'Non')";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefLocation", 11, DbType.Int32, a.RefLocation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "QteCubage", 11, DbType.Double, a.QteCubage));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "PuCube", 11, DbType.Double, a.PuCube));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "DebutMois", 20, DbType.Date, a.DebutMois));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "FinMois", 20, DbType.Date, a.FinMois));

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateDatas(PEau a)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE PEau SET DateSave=CURRENT_DATE,Encaissement='Oui' WHERE Id=@id";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, a.Id));

                cmd.ExecuteNonQuery();
            }
        }
        public List<PEau> GetPaiement(int idLocation)
        {
            List<PEau> lst = new List<PEau>();

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Paiement_Eau WHERE IdLocation=@IdLocation";

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "IdLocation", 11, DbType.Int32, idLocation));

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatasPaiement(dr));
                }
                dr.Dispose();
            }
            return lst;
        }

        public List<PEau> GetChargeAEncaisser()
        {
            List<PEau> lst = new List<PEau>();

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Detail_Paiement_Eau WHERE Encaissement='Non' COLLATE NOCASE";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatasCharge(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<PEau> Research(string recherche)
        {
            List<PEau> lst = new List<PEau>();
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Affichage_Detail_Paiement_Eau WHERE Encaissement='Non' AND (Nom LIKE '%" + recherche + "%' OR Nom LIKE '%" + recherche + "' OR Nom LIKE '" + recherche + "%' OR Locale LIKE '%" + recherche + "%')";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDatasCharge(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private PEau GetDatasCharge(IDataReader rd)
        {
            PEau A = new PEau();

            A.Id = Convert.ToInt32(rd["Id"].ToString());
            A.Periode = rd["Periode"].ToString();
            A.QteCubage = float.Parse(rd["QteCubage"].ToString());
            A.PuCube = float.Parse(rd["PuCube"].ToString());
            A.Total = float.Parse(rd["Totale"].ToString());
            A.RefLocation = Convert.ToInt32(rd["idLocation"].ToString());
            A.Nom = rd["nom"].ToString();
            A.Locale = rd["locale"].ToString();
            A.Adresse = rd["adresse"].ToString();
            A.DateSave = Convert.ToDateTime(rd["DateSave"].ToString());
            A.Motif = rd["Motif"].ToString();
            A.Phone = rd["telephone"].ToString();

            return A;
        }
        private PEau GetDatasPaiement(IDataReader rd)
        {
            PEau A = new PEau();
            i = i + 1;

            A.Num = i;
            A.Id = Convert.ToInt32(rd["Id"].ToString());
            A.RefLocation = Convert.ToInt32(rd["idLocation"].ToString());
            A.QteCubage = float.Parse(rd["qtecubage"].ToString());
            A.PuCube = float.Parse(rd["pucube"].ToString());
            A.Total = float.Parse(rd["tota"].ToString());
            A.Periode = rd["Periode"].ToString();
            A.DebutMois = Convert.ToDateTime(rd["debutMois"].ToString());
            A.FinMois = Convert.ToDateTime(rd["finMois"].ToString());
            A.DateSave = Convert.ToDateTime(rd["dateSave"].ToString());

            return A;
        }
    }
}
