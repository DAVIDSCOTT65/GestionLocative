using ManageSingleConnexion;
using ObjectDesignLib;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiementLib
{
    public class PLoyer : IPaiement
    {
        public string Annee{ get; set; }

        public DateTime DateSave { get; set; }

        public int Id { get; set; }

        public string Mois { get; set; }

        public float Montant { get; set; }

        public int RefLocation { get; set; }
        public int Nouveau()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT MAX(id) as LastId from PLoyer";
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
        public void SaveDatas()
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO PLoyer VALUES(@Id,@RefLocation,@Montant,CURRENT_DATE,@Ecaissement)";

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefLocation", 11, DbType.Int32, RefLocation));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Montant", 11, DbType.Double, Montant));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Ecaissement", 11, DbType.String, "Oui"));

                cmd.ExecuteNonQuery();

                ObjectDesign.GetInstance().Alert("Location enregistrée !", CustomDialog.enmType.Success);
            }
        }

        public void TestConn()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
        }
    }
}
