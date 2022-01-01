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
    public partial class LocationUser : UserControl
    {
        
        //public delegate void PassControl(string location, string adresse);
        //public PassControl passControl;
        public LocationUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppartAddFrm fr = new AppartAddFrm();
            fr.id = int.Parse(idLbl.Text);
            fr.idLbl.Text = idLbl.Text;
            fr.nomTxt.Text = nomTxt.Text;
            fr.adresseTxt.Text = adresseTxt.Text;
            fr.villeTxt.Text = villeTxt.Text;
            fr.paysTxt.Text = paysLbl.Text;
            fr.montantTxt.Text = montantLbl.Text;
            fr.garantiTxt.Text = garantieLbl.Text;
            fr.salonTxt.Text = salonTxt.Text;
            fr.cuisineTxt.Text = cuisineTxt.Text;
            fr.toiletteTxt.Text = toiletteTxt.Text;
            fr.autrePieceTxt.Text = chambreTxt.Text;
            if (typeTxt.Text == "Location non meublée (nue)")
                fr.nonMeubleeRbtn.Checked = true;
            else
                fr.meubleeRbtn.Checked = true;
            fr.statut = "update";
            fr.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LocationUser_Load(object sender, EventArgs e)
        {

        }

        private void LocationUser_MouseClick(object sender, MouseEventArgs e)
        {
            //AppartFrm.instance.adresseTxt.Text = adresseTxt.Text;
            //AppartFrm.instance.nomTxt.Text = nomTxt.Text;
            //AppartFrm.instance.id = int.Parse(idLbl.Text);
            //AppartFrm.instance.garantie = int.Parse(garantieLbl.Text);
            //AppartFrm.instance.loyer = float.Parse(montantLbl.Text);

            DetailBailUser.instance.locationUser1.nomTxt.Text = nomTxt.Text;
            DetailBailUser.instance.locationUser1.adresseTxt.Text = adresseTxt.Text;
            DetailBailUser.instance.locationUser1.idLbl.Text = idLbl.Text;
            DetailBailUser.instance.locationUser1.garantieLbl.Text = garantieLbl.Text;
            DetailBailUser.instance.locationUser1.loyerLbl.Text = montantLbl.Text+"$ /Mois";
            DetailBailUser.instance.locationUser1.montantLbl.Text = montantLbl.Text;
            DetailBailUser.instance.dureeTxt.Text = garantieLbl.Text;
            DetailBailUser.instance.loyer = float.Parse(montantLbl.Text);
            DetailBailUser.instance.calcul();

            if (AppartFrm.instance.passControl != null)
            {
                AppartFrm.instance.passControl(nomTxt.Text, adresseTxt.Text, int.Parse(idLbl.Text), int.Parse(garantieLbl.Text), float.Parse(montantLbl.Text));
                
            }
            AppartFrm.instance.Close();
        }
    }
}
