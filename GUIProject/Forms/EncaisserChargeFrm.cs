using GUIProject.Properties;
using GUIProject.UserC;
using PaiementLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject.Forms
{
    public partial class EncaisserChargeFrm : Form
    {
        public static EncaisserChargeFrm instance = new EncaisserChargeFrm();
        public string statut = "";
        public EncaisserChargeFrm()
        {
            InitializeComponent();
            instance = this;
        }
        public void SelectDatasEau(PEau l)
        {
            List<PEau> lst = new List<PEau>();
            lst = l.GetChargeAEncaisser();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, item.PuCube.ToString(), item.QteCubage.ToString(), item.Periode, item.Total, item.Motif,item.Phone);
            }
        }
        public void SelectDatasElectricite(PElectricite l)
        {
            List<PElectricite> lst = new List<PElectricite>();
            lst = l.GetChargeAEncaisser();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, "-", "-", item.Periode, item.Montant, item.Motif,item.Phone);
            }
        }
        public void SelectDatasSecurite(PSecurite l)
        {
            List<PSecurite> lst = new List<PSecurite>();
            lst = l.GetChargeAEncaisser();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, "-", "-", item.Periode, item.Montant, item.Motif,item.Phone);
            }
        }
        public void ChargerUser(ConfirmPaieUser userc, int id, string locateur, string dateSave, string adresse, string locale, string loyer, string garantie, string duree, float total, string motif,string phone)
        {
            try
            {
                userc.statut = statut;
                userc.idLbl.Text = id.ToString();
                //userc.idAppart.Text = idAppart.ToString();
                //userc.idLocateur.Text = idLocataire.ToString();
                userc.saveDate.Text = dateSave;
                userc.dureeTxt.Text = duree.Replace("00:00:00","");
                userc.adresseTxt.Text = adresse;
                userc.localTxt.Text = locale;
                userc.montantTxt.Text = loyer.ToString() + "$";
                userc.moisTxt.Text = garantie.ToString();
                userc.totalTxt.Text = total.ToString() + "$";
                userc.totTxt.Text = total.ToString();
                userc.locateurTxt.Text = locateur;
                userc.picCharge.Visible = true;
                userc.phoneTxt.Text = phone;
                switch (motif)
                {
                    case "Eau":
                        userc.motif = motif;
                        userc.picCharge.Image = Resources.Plumbing_48px;
                        userc.imgName.Text = "Eau";
                        break;
                    case "Electricite":
                        userc.motif = motif;
                        userc.picCharge.Image = Resources.Electricity_48px;
                        userc.imgName.Text = "Electricite";
                        break;
                    case "Securite":
                        userc.motif = motif;
                        userc.picCharge.Image = Resources.Policeman_Male_48px;
                        userc.imgName.Text = "Securite";
                        break;
                }
                if (statut == "sms")
                {
                    userc.button1.Text = "SMS";
                }
                
                //userc.paysLbl.Text = pays;
                //userc.montantLbl.Text = montant.ToString();
                //userc.garantieLbl.Text = garantie.ToString();
                //userc.typeTxt.Text = type;
                //userc.salonTxt.Text = salon.ToString();
                //userc.cuisineTxt.Text = cuisine.ToString();
                //userc.toiletteTxt.Text = toilette.ToString();
                //userc.chambreTxt.Text = chambre.ToString();
                userc.Dock = DockStyle.None;
                localationFlow.Controls.Add(userc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        private void EncaisserChargeFrm_Load(object sender, EventArgs e)
        {
            SelectDatasEau(new PEau());
            SelectDatasElectricite(new PElectricite());
            SelectDatasSecurite(new PSecurite());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            localationFlow.Controls.Clear();
            SearchEau(new PEau());
            SearchElectricite(new PElectricite());
            SearchSecurite(new PSecurite());
        }
        void SearchEau(PEau m)
        {
            List<PEau> lst = new List<PEau>();
            lst = m.Research(searchTxt.Text);

            //localationFlow.Controls.Clear();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, item.PuCube.ToString(), item.QteCubage.ToString(), item.Periode, item.Total, item.Motif, item.Phone);
            }
        }
        void SearchElectricite(PElectricite m)
        {
            List<PElectricite> lst = new List<PElectricite>();
            lst = m.Research(searchTxt.Text);

            //localationFlow.Controls.Clear();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, "-", "-", item.Periode, item.Montant, item.Motif, item.Phone);
            }
        }
        void SearchSecurite(PSecurite m)
        {
            List<PSecurite> lst = new List<PSecurite>();
            lst = m.Research(searchTxt.Text);

            //localationFlow.Controls.Clear();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, "-", "-", item.Periode, item.Montant, item.Motif, item.Phone);
            }
        }
    }
}
