using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartementLib
{
    public class TypeAppartement
    {
        public int Id { get; set; }
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
                cmd.CommandText = "SELECT MAX(id) as LastId from TypeAppartement";
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
        public void SaveDatas(TypeAppartement t)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO typeappartement VALUES(@Id,@Designation)";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, t.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Designation", 50, DbType.String, t.Designation));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Appartement Save", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
