using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIProject.Forms;
using PaiementLib;

namespace GUIProject.UserC
{
    public partial class PaiementChargeUser : UserControl
    {
        public PaiementChargeUser()
        {
            InitializeComponent();
        }
        void SelectDatasEau(PEau e)
        {
            dgEau.DataSource = e.GetPaiement(LocataireAddFrm.instance.id);
            eauLbl.Text = e.GetSommePaiements(LocataireAddFrm.instance.id).ToString();
        }
        void SelectDatasElectricite(PElectricite e)
        {
            dgElectricite.DataSource = e.GetPaiement(LocataireAddFrm.instance.id);
            elecLbl.Text = e.GetSommePaiements(LocataireAddFrm.instance.id).ToString();
        }
        void SelectDatasSecurite(PSecurite e)
        {
            dgSecurite.DataSource = e.GetPaiement(LocataireAddFrm.instance.id);
            secLbl.Text = e.GetSommePaiements(LocataireAddFrm.instance.id).ToString();
        }
        private void PaiementChargeUser_Load(object sender, EventArgs e)
        {
            SelectDatasEau(new PEau());
            SelectDatasElectricite(new PElectricite());
            SelectDatasSecurite(new PSecurite());
            timer1.Start();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaiementChargeOptionFrm fr = new PaiementChargeOptionFrm();
            fr.ShowDialog();
        }

        private void adresseTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                totalTxt.Text = (float.Parse(elecLbl.Text) + float.Parse(eauLbl.Text) + float.Parse(secLbl.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Errerur : "+ex.Message);
            }
        }
    }
}
