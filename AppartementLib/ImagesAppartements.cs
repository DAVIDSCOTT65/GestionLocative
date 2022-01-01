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

namespace AppartementLib
{
     public class ImagesAppartements
    {
        public int Id { get; set; }
        public int RefAppartement { get; set; }
        public string Piece { get; set; }
        public Image Img { get; set; }
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
                cmd.CommandText = "SELECT MAX(id) as LastId from imagesappartements";
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
        public void SaveDatas(ImagesAppartements i)
        {

            TestConn();
            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO imagesappartements VALUES(@Id,@RefAppartement,@Piece,@Img)";

                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Id", 11, DbType.Int32, i.Nouveau()));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "RefAppartement", 11, DbType.Int32, i.RefAppartement));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Piece", 50, DbType.String, i.Piece));
                cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "Img", int.MaxValue, DbType.Binary, ConvertToByteImage(i.Img)));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
