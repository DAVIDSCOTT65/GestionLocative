using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
    public class ImplementeConnexion:IConnexion
    {
        private IDbConnection _conn = null;
        private static ImplementeConnexion _instance = null;


        public IDbConnection Conn
        {
            get
            {
                return _conn;
            }

            set
            {
                _conn = value;
            }
        }
        public static ImplementeConnexion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImplementeConnexion();
                return _instance;
            }
        }
        public IDbConnection Initialise(ConnexionType connexionType)
        {
            switch (connexionType)
            {
                
                case ConnexionType.SQLite:

                    _conn = new SQLiteConnection("Data Source = GestionLocative.db");
                    if (!File.Exists("./GestionLocative.db"))
                    {
                        SQLiteConnection.CreateFile("GestionLocative.db");    
                    }
                    
                    break;
            }
            return _conn;
        }
    }
}
