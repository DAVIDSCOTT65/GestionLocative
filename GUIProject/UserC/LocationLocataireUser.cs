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

namespace GUIProject.UserC
{
    public partial class LocationLocataireUser : UserControl
    {
        public LocationLocataireUser()
        {
            InitializeComponent();
        }

        private void LocationLocataireUser_Load(object sender, EventArgs e)
        {

        }

        private void LocationLocataireUser_MouseClick(object sender, MouseEventArgs e)
        {
            LocateurFrm.instance.idAppart = int.Parse(idAppart.Text);
            LocateurFrm.instance.idLocateur = int.Parse(idLocateur.Text);
            LocateurFrm.instance.nom = nomTxt.Text;
            LocateurFrm.instance.adresse = adresseTxt.Text;
            LocateurFrm.instance.loction = localTxt.Text;

            if (LocateurFrm.instance.passControl != null)
            {
                LocateurFrm.instance.passControl(int.Parse(idLbl.Text), int.Parse(idAppart.Text), int.Parse(idLocateur.Text),nomTxt.Text,adresseTxt.Text,localTxt.Text,int.Parse(garantieLbl.Text),float.Parse(montantLbl.Text));
                LocateurOptionFrm.instance.nomTxt.Visible = true;
                LocateurOptionFrm.instance.adLbl.Visible = true;
                LocateurOptionFrm.instance.localLbl.Visible = true;
                LocateurFrm.instance.Close();
            }
        }

        private void LocationLocataireUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LocataireAddFrm fr = new LocataireAddFrm();

            fr.id = int.Parse(idLbl.Text);
            fr.idAppart = int.Parse(idAppart.Text);
            fr.idLocataire = int.Parse(idLocateur.Text);
            fr.location = localTxt.Text;
            fr.garantie = int.Parse(garantieLbl.Text);
            fr.loyer = float.Parse(montantLbl.Text);
            fr.button1.Visible = false;

            fr.ChargerLocataire(new LocataireAddUser(), adresseTxt.Text, nomTxt.Text, fr.idLocataire);

            fr.ShowDialog();
        }
    }
}
