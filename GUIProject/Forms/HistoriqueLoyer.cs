using AppartementLib;
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
    public partial class HistoriqueLoyer : Form
    {
        public HistoriqueLoyer()
        {
            InitializeComponent();
        }
        public void SelectDatas(Location l, string query)
        {
            List<Location> lst = new List<Location>();
            lst = l.GetLocation(query);

            foreach (var item in lst)
            {
                ChargerUser(new LocationLocataireUser(), item.Id, item.Nom, item.Adresse, item.Locale, item.RefAppartement, item.RefLocataire, item.Montant, item.Garantie, item.Duree, item.DayRest);
            }
        }
        public void ChargerUser(LocationLocataireUser userc, int id, string nom, string adresse, string locale, int idAppart, int idLocataire, float loyer, int garantie, string duree, int dayRest)
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoriqueLoyer_Load(object sender, EventArgs e)
        {
            Appartements l = new Appartements();
            Locataire lo = new Locataire();
            l.GetNameAppart(locationCmb);
            lo.GetNamesLocataires(locataireCmb);
        }

        private void locataireCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            localationFlow.Controls.Clear();
            if (locationCmb.Text != "" && locataireCmb.Text != "")
            {
                SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE locale='" + locationCmb.Text.Trim() + "' AND Nom='" + locataireCmb.Text.Trim() + "' ORDER BY id DESC");
            }
            else
            {
                SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE Nom='" + locataireCmb.Text.Trim() + "' ORDER BY id DESC");
            }
            
        }

        private void locationCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            localationFlow.Controls.Clear();
            if (locationCmb.Text != "" && locataireCmb.Text != "")
            {
                SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE locale='" + locationCmb.Text.Trim() + "' AND Nom='"+locataireCmb.Text.Trim()+"' ORDER BY id DESC");
            }
            else
            {
                SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE locale='" + locationCmb.Text.Trim() + "' ORDER BY id DESC");
            }
            
        }
    }
}
