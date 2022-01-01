using ManageSingleConnexion;
using ParametreLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationLib
{
    public class Conjoint
    {
        public int Id { get; set; }
        public int RefLocataire { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime DateSave { get; set; }
        public void TestConn()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
        }
        public void SaveDatas(Conjoint a)
        {
            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Conjointe VALUES(@Id,@RefLocataire,@Nom,@Postnom,@Prenom,@Telephone,@Email,GETDATE())";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, a.Id));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefLocataire", 11, DbType.Int32, a.RefLocataire));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Nom", 100, DbType.String, a.Nom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Postnom", 100, DbType.String, a.Postnom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Prenom", 100, DbType.String, a.Prenom));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Telephone", 20, DbType.String, a.Telephone));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Email", 100, DbType.String, a.Email));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
