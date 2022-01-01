using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesLib
{
    public class ClsConnection
    {
        ClsCrypto crypto = new ClsCrypto();
        ConnexionType connectionType = new ConnexionType();

        public static ClsConnection _instance = null;
        public string chemin;

        public static ClsConnection GetInstance()
        {
            if (_instance == null)
                _instance = new ClsConnection();
            return _instance;
        }
        public void Connecter()
        {
            try
            {
                Connexion connexion = new Connexion();

                ImplementeConnexion.Instance.Initialise(ConnexionType.SQLite);
                ImplementeConnexion.Instance.Conn.Open();
                //MessageBox.Show("Connection Succefully !!!", "Succefully", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                //chemin = "server = " + connexion.Serveur + ";database = " + connexion.Database + ";uid =" + connexion.User + ";pwd = " + connexion.Password + ";";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                ClsGetdatas.GetInstance().Testeconne = 0;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
                ClsGetdatas.GetInstance().Testeconne = 0;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                ClsGetdatas.GetInstance().Testeconne = 0;
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                    {
                        ImplementeConnexion.Instance.Conn.Close();
                    }
                }
            }
        }
    }
}
