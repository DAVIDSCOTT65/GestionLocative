using GUIProject.DataSets;
using GUIProject.Etats;
using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject.Forms
{
    public partial class PrintFrm : Form
    {
        public PrintFrm()
        {
            InitializeComponent();
        }
        public void TestConn()
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
        }
        private void PrintFrm_Load(object sender, EventArgs e)
        {

        }
        public void PrintQuittanceLoyer(int id)
        {
            TestConn();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Affichage_Details_Location Where id=" + id + "", (SQLiteConnection)ImplementeConnexion.Instance.Conn);
            QuittanceLoyerCR x = new QuittanceLoyerCR();
            DataSet1 ds = new DataSet1();

            da.Fill(ds.Contrat);
            x.SetDataSource((DataTable)ds.Contrat);

            crystalReportViewer1.ReportSource = x;
            crystalReportViewer1.Refresh();
        }
        public void PrintAvisEcheance(int id)
        {
            TestConn();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Affichage_Details_Location Where id=" + id + "", (SQLiteConnection)ImplementeConnexion.Instance.Conn);
            AppelLoyerCR x = new AppelLoyerCR();
            DataSet1 ds = new DataSet1();

            da.Fill(ds.Contrat);
            x.SetDataSource((DataTable)ds.Contrat);

            crystalReportViewer1.ReportSource = x;
            crystalReportViewer1.Refresh();
        }

        public void PrintRecuSecurite(int id)
        {
            TestConn();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Affichage_Detail_Paiement_Securite Where id=" + id + "", (SQLiteConnection)ImplementeConnexion.Instance.Conn);
            RecuSecuriteCR x = new RecuSecuriteCR();
            DataSet1 ds = new DataSet1();

            da.Fill(ds.Securite);
            x.SetDataSource((DataTable)ds.Securite);

            crystalReportViewer1.ReportSource = x;
            crystalReportViewer1.Refresh();
        }
        public void PrintRecuElectricite(int id)
        {
            TestConn();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Affichage_Detail_Paiement_Electricite Where id=" + id + "", (SQLiteConnection)ImplementeConnexion.Instance.Conn);
            RecuElectricite x = new RecuElectricite();
            DataSet1 ds = new DataSet1();

            da.Fill(ds.Electricite);
            x.SetDataSource((DataTable)ds.Electricite);

            crystalReportViewer1.ReportSource = x;
            crystalReportViewer1.Refresh();
        }
        public void PrintRecuEau(int id)
        {
            TestConn();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Affichage_Detail_Paiement_Eau Where id=" + id + "", (SQLiteConnection)ImplementeConnexion.Instance.Conn);
            RecuCR x = new RecuCR();
            DataSet1 ds = new DataSet1();

            da.Fill(ds.Eau);
            x.SetDataSource((DataTable)ds.Eau);

            crystalReportViewer1.ReportSource = x;
            crystalReportViewer1.Refresh();
        }
        public void PrintContrat(int id)
        {
            TestConn();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Affichage_Details_Location Where id=" + id + "", (SQLiteConnection)ImplementeConnexion.Instance.Conn);
            ContratBailCR x = new ContratBailCR();
            DataSet1 ds = new DataSet1();

            da.Fill(ds.Contrat);
            x.SetDataSource((DataTable)ds.Contrat);

            crystalReportViewer1.ReportSource = x;
            crystalReportViewer1.Refresh();
        }
    }
}
