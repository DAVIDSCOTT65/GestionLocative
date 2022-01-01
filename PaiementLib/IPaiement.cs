using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiementLib
{
    interface IPaiement
    {
        int Id { get; set; }
        int RefLocation { get; set; }
        float Montant { get; set; }
        DateTime DateSave { get; set; }
        string Mois { get; set; }
        string Annee { get; set; }
        void TestConn();
        void SaveDatas();
    }
}
