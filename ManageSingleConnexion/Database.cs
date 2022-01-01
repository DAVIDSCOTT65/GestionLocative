using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManageSingleConnexion
{
    public class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=GestionLocative.sqlite");
            if (!File.Exists("./GestionLocative.sqlite"))
            {
                SQLiteConnection.CreateFile("./GestionLocative.sqlite");
            }
        }
    }
}
