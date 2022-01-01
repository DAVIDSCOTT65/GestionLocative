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
    public partial class LocateurFrm : Form
    {
        public int idAppart = 0;
        public int idLocateur = 0;
        public string nom = "";
        public string adresse = "";
        public string loction = "";
        public string requette = "SELECT * FROM Affichage_Details_Location fincontrat > CURRENT_DATE";

        public delegate void PassControl(int id, int idAppar, int idLocat, string name, string adresse, string location, int garantie, float loyer);
        public PassControl passControl;

        public static LocateurFrm instance = new LocateurFrm();
        public LocateurFrm()
        {
            InitializeComponent();
            instance = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LocateurOptionFrm fr = new LocateurOptionFrm();
            fr.ShowDialog();
        }
        public void SelectDatas(Location l, string query)
        {
            List<Location> lst = new List<Location>();
            lst = l.GetLocation(query);

            foreach (var item in lst)
            {
                ChargerUser(new LocationLocataireUser(), item.Id, item.Nom, item.Adresse,item.Locale,item.RefAppartement,item.RefLocataire,item.Montant,item.Garantie,item.Duree,item.DayRest);
            }
        }
        void Search(Location m)
        {
            List<Location> lst = new List<Location>();
            lst = m.Research(searchTxt.Text);

            localationFlow.Controls.Clear();

            foreach (var item in lst)
            {
                ChargerUser(new LocationLocataireUser(), item.Id, item.Nom, item.Adresse, item.Locale, item.RefAppartement, item.RefLocataire, item.Montant, item.Garantie,item.Duree,item.DayRest);
            }
        }
        public void ChargerUser(LocationLocataireUser userc, int id, string nom, string adresse, string locale, int idAppart,int idLocataire,float loyer,int garantie,string duree,int dayRest)
        {
            try
            {
                userc.idLbl.Text = id.ToString();
                userc.idAppart.Text = idAppart.ToString();
                userc.idLocateur.Text = idLocataire.ToString();
                userc.nomTxt.Text = nom;
                userc.adresseTxt.Text = duree;
                userc.qTxt.Text = adresse;
                userc.localTxt.Text = locale;
                userc.montantLbl.Text = loyer.ToString();
                userc.garantieLbl.Text = garantie.ToString();
                userc.villeTxt.Text = dayRest.ToString();
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LocateurFrm_Load(object sender, EventArgs e)
        {
            //SelectDatas(new LocationLib.Location());
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new LocationLib.Location());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
