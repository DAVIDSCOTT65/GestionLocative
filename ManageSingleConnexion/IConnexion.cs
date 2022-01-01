using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
    interface IConnexion
    {
        IDbConnection Initialise(ConnexionType connectionType);
    }
}
