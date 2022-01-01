using GUIProject.UserC;
using LocationLib;
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
    public partial class EncaisserFrm : Form
    {
        public static EncaisserFrm instace = new EncaisserFrm();
        public string statut = "";
        public EncaisserFrm()
        {
            InitializeComponent();
            instace = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChargerUser(ConfirmPaieUser userc, int id, string locateur,string dateSave, string adresse, string locale, float loyer, int garantie, string duree, float total,string email,string phone)
        {
            try
            {
                userc.statut = statut;
                userc.idLbl.Text = id.ToString();
                //userc.idAppart.Text = idAppart.ToString();
                //userc.idLocateur.Text = idLocataire.ToString();
                userc.saveDate.Text = dateSave;
                userc.dureeTxt.Text = duree;
                userc.adresseTxt.Text = adresse;
                userc.localTxt.Text = locale;
                userc.montantTxt.Text = loyer.ToString() +"$";
                userc.moisTxt.Text = garantie.ToString() +" Mois";
                userc.totalTxt.Text = total.ToString()+"$";
                userc.totTxt.Text = total.ToString();
                userc.locateurTxt.Text = locateur;
                userc.emailTxt.Text = email;
                userc.phoneTxt.Text = phone;
                if(statut=="Appel")
                    userc.button1.Text = "Imprimer";
                if(statut== "Mail")
                    userc.button1.Text = "Email";

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
        public void SelectDatas(Location l)
        {
            List<Location> lst = new List<Location>();
            lst = l.GetLoyerAEncaisser();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom,item.DateSave.ToShortDateString(), item.Adresse, item.Locale, item.Montant, item.Garantie, item.Duree, item.Total,item.Email,item.Phone);
            }
        }
        private void EncaisserFrm_Load(object sender, EventArgs e)
        {

        }

        private void EncaisserFrm_Load_1(object sender, EventArgs e)
        {
            SelectDatas(new LocationLib.Location());
        }
        void Search(Location m)
        {
            List<Location> lst = new List<Location>();
            lst = m.Research(searchTxt.Text);

            localationFlow.Controls.Clear();

            foreach (var item in lst)
            {
                ChargerUser(new ConfirmPaieUser(), item.Id, item.Nom, item.DateSave.ToShortDateString(), item.Adresse, item.Locale, item.Montant, item.Garantie, item.Duree, item.Total,item.Email,item.Phone);
            }
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new LocationLib.Location());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }
    }
}
