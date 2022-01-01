using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{
    public class FAQTable
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
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
                cmd.CommandText = "SELECT MAX(id) as LastId from FAQTbl";
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
        public void SaveDatas(FAQTable f)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO FAQTbl VALUES(@Id,@Question,@Answer)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, f.Nouveau()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Question", 255, DbType.String, f.Question));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Answer", 255, DbType.String, f.Answer));

                cmd.ExecuteNonQuery();
            }
        }
        public List<FAQTable> GetFAQs()
        {
            List<FAQTable> lst = new List<FAQTable>();

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM FAQTbl";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lst.Add(GetDatasFAQ(dr));
                }
                dr.Dispose();
            }
            return lst;
        }
        public List<FAQTable> Research(string recherche)
        {
            List<FAQTable> lst = new List<FAQTable>();
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM FAQTbl WHERE (Question LIKE '%" + recherche + "%' OR Question LIKE '%" + recherche + "' OR Question LIKE '" + recherche + "%')";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDatasFAQ(rd));
                }
                rd.Dispose();
                rd.Close();
            }
            return lst;
        }
        private FAQTable GetDatasFAQ(IDataReader rd)
        {
            FAQTable A = new FAQTable();

            A.Id = Convert.ToInt32(rd["Id"].ToString());
            A.Question = rd["Question"].ToString();
            A.Answer = rd["Answer"].ToString();

            return A;
        }
    }
}
