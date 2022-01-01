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
    public class EntetePaiement
    {
        public int Id { get; set; }
        public int RefLoyer { get; set; }
        public int RefEau { get; set; }
        public int RefSecurite { get; set; }
        public int RefElectricite { get; set; }
        public DateTime DateSave { get; set; }
        public string Mois { get; set; }
        public string Annee { get; set; }
        public void TestConn()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
        }
        public void SaveDatas(EntetePaiement a)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO EntetePaiement VALUES(@Id,@RefLoyer,@RefEau,@RefSecurite,@RefElectricite,GETDATE(),MONTH(GETDATE()),@UserSession,YEAR(GETDATE()))";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefLoyer", 11, DbType.Int32, a.RefLoyer));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefEau", 11, DbType.Int32, a.RefEau));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefSecurite", 11, DbType.Int32, a.RefSecurite));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefElectricite", 11, DbType.Int32, a.RefElectricite));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Paiement Save", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
