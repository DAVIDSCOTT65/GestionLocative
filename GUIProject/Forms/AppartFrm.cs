using AppartementLib;
using GUIProject.UserC;
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
    public partial class AppartFrm : Form
    {
        public int id = 0;
        public int garantie = 0;
        public float loyer = 0;
        public static AppartFrm instance = new AppartFrm();
        public delegate void PassControl(string location, string adresse, int id,int garantie,float loyer);
        public PassControl passControl;
        public AppartFrm()
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
            AppartAddFrm fr = new AppartAddFrm();
            Appartements a = new Appartements();

            fr.id = a.Nouveau();
            fr.nomTxt.Text = "LOCALE " + fr.id;
            fr.statut = "insert";

            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void ChargerUser(LocationUser userc, string location, string adresse, string ville,string pays, int id,float montant,int garantie,string type,int salon,int cuisine,int toilette,int chambre)
        {
            try
            {

                userc.idLbl.Text = id.ToString();
                userc.nomTxt.Text = location;
                userc.adresseTxt.Text = adresse;
                userc.villeTxt.Text = ville;
                userc.paysLbl.Text = pays;
                userc.montantLbl.Text = montant.ToString();
                userc.garantieLbl.Text = garantie.ToString();
                userc.typeTxt.Text = type;
                userc.salonTxt.Text = salon.ToString();
                userc.cuisineTxt.Text = cuisine.ToString();
                userc.toiletteTxt.Text = toilette.ToString();
                userc.chambreTxt.Text = chambre.ToString();
                userc.Dock = DockStyle.None;
                localationFlow.Controls.Add(userc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        void SelectDatas(Appartements c)
        {
            List<Appartements> lst = new List<Appartements>();
            lst = c.GetLocale();

            foreach (var item in lst)
            {
                ChargerUser(new LocationUser(), item.Nom, item.Adresse, item.Ville,item.Pays,item.Id,item.MontantParMois,item.Garantie,item.Designation,item.Salon,item.Cuisine,item.Toilette,item.Chambre);
            }
        }
        void Search(Appartements m)
        {
            List<Appartements> lst = new List<Appartements>();
            lst = m.Research(searchTxt.Text);

            localationFlow.Controls.Clear();

            foreach (var item in lst)
            {
                ChargerUser(new LocationUser(), item.Nom, item.Adresse, item.Ville, item.Pays, item.Id, item.MontantParMois, item.Garantie, item.Designation, item.Salon, item.Cuisine, item.Toilette, item.Chambre);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppartFrm_Load(object sender, EventArgs e)
        {
            SelectDatas(new Appartements());
        }

        private void localationFlow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void localationFlow_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            Search(new Appartements());
        }
    }
}
