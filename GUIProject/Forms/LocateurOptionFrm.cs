using GUIProject.UserC;
using LocationLib;
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
    public partial class LocateurOptionFrm : Form
    {
        int id = 0;
        int garantie = 0;
        float loyer = 0;

        int idLocat = 0;

        public static LocateurOptionFrm instance = new LocateurOptionFrm();
        public LocateurOptionFrm()
        {
            InitializeComponent();
            instance = this;
            timer1.Start();
        }
        private void PassData(string location, string adresse, int idAppart, int garanti,float montant)
        {
            try
            {
                locationBtn.Text = "            " + location;
                adresseLbl.Text = adresse;
                id = idAppart;
                garantie = garanti;
                loyer = montant;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void PassData2(int idLocation,int idAppart, int idLocataire, string nom, string adresse, string locale,int garanti,float montant)
        {
            try
            {
                idLbl.Text = idLocation.ToString();
                nomTxt.Text = nom;
                adLbl.Text = adresse;
                id = idAppart;
                idLocat = idLocataire;
                localLbl.Text = locale;
                garantie = garanti;
                loyer = montant;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppartFrm fr = new AppartFrm();
            fr.passControl = new AppartFrm.PassControl(PassData);
            fr.ShowDialog();
        }

        private void LocateurOptionFrm_Load(object sender, EventArgs e)
        {
            createRbtn.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (createRbtn.Checked)
                locationBtn.Enabled = true;
            else
                locationBtn.Enabled = false;

            if (reprendreRbtn.Checked)
                repBtn.Enabled = true;
            else
                repBtn.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocataireAddFrm fr = new LocataireAddFrm();
            Location f = new Location();
            PLoyer p = new PLoyer();

            fr.idPaiement = p.Nouveau();
            fr.id = f.Nouveau();

            if (createRbtn.Checked)
            {
                if (locationBtn.Text == "            Veuillez selectionner une location" || adresseLbl.Text == "Adresse")
                    MessageBox.Show("Charger une location");
                else
                {
                    fr.idAppart = id;
                    fr.location = locationBtn.Text.Trim();
                    fr.garantie = garantie;
                    fr.loyer = loyer;
                    fr.ChargerLocataire(new LocataireAddUser(), adresseLbl.Text, "", 0);


                    fr.ShowDialog();
                }
                
            }else if (reprendreRbtn.Checked)
            {
                if(nomTxt.Text=="locataire" || adLbl.Text =="adresse" || localLbl.Text=="locale")
                    MessageBox.Show("Charger un bail");
                else
                {
                    fr.lastId = int.Parse(idLbl.Text);
                    fr.idAppart = id;
                    fr.idLocataire = idLocat;
                    fr.location = localLbl.Text;
                    fr.garantie = garantie;
                    fr.loyer = loyer;

                    fr.ChargerLocataire(new LocataireAddUser(), adLbl.Text, nomTxt.Text, idLocat);

                    fr.ShowDialog();
                }
                
            }
            
        }

        private void repBtn_Click(object sender, EventArgs e)
        {
            LocateurFrm fr = new LocateurFrm();
            fr.passControl = new LocateurFrm.PassControl(PassData2);
            //fr.ShowDialog();

            fr.button4.Visible = false;

            fr.ShowDialog();
        }
    }
}
