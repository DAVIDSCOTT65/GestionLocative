using GUIProject.UserC;
using LocationLib;
using PaiementLib;
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
    public partial class LocataireAddFrm : Form
    {
        public static LocataireAddFrm instance = new LocataireAddFrm();
        public UserControl locataireUser = new UserControl(); 
        string adresse = "";

        public int id = 0;
        public int lastId = 0;
        public int idPaiement = 0;
        public int idAppart = 0;
        public int idLocataire = 0;
        public DateTime debutContrat;
        public DateTime finContrat;
        public string periodicite = "";
        public string loyer_payable = "";
        public string loyer_exigible = "";
        public int delais = 0;
        public float montant = 0;
        public int duree = 0;

        public string location = "";
        public int garantie = 0;
        public float loyer = 0;
        public LocataireAddFrm()
        {
            InitializeComponent();
            instance = this;
        }
        public void ChargerUser(UserControl userc)
        {
            try
            {
                userc.Dock = DockStyle.Fill;
                centralPanel.Controls.Clear();
                centralPanel.Controls.Add(userc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        public void ChargerBail(DetailBailUser userc)
        {
            try
            {
                userc.locationUser1.nomTxt.Text = location;
                userc.locationUser1.adresseTxt.Text = adresse;
                userc.locationUser1.garantieLbl.Text = garantie.ToString();
                userc.locationUser1.loyerLbl.Visible = true;
                userc.locationUser1.loyerLbl.Text = loyer.ToString() + "$ /Mois";
                userc.loyer = loyer;
                userc.dureeTxt.Value = garantie;
                userc.Dock = DockStyle.Fill;
                centralPanel.Controls.Clear();
                centralPanel.Controls.Add(userc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        public void ChargerLocataire(LocataireAddUser locataire, string txt, string nom,int id)
        {
            try
            {
                if(nom!="" && id != 0)
                {
                    locataire.locataireInfo1.nomTxt.Text = nom;
                    locataire.locataireInfo1.idLbl.Text = id.ToString();
                    locataire.addresseTxt.Text = nom+"\n"+txt;
                    locataire.locataireInfo1.Visible = true;
                }
                else
                {
                    locataire.addresseTxt.Text = txt;
                }
                adresse = txt;
                locataire.Dock = DockStyle.Fill;
                locataireUser = locataire;
                centralPanel.Controls.Clear();
                centralPanel.Controls.Add(locataire);

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

        private void LocataireAddFrm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if(idLocataire != 0)
                ChargerUser(locataireUser);
        }

        private void centralPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChargerBail(new DetailBailUser());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //locataireUser = 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (montant <= 0 || id == 0 || idAppart == 0 || idLocataire == 0 || periodicite == "" || loyer_exigible == "" || loyer_payable == "" || delais <= 0)
                {
                    ObjectDesignLib.ObjectDesign.GetInstance().Alert("Champs vides !", ObjectDesignLib.CustomDialog.enmType.Error);
                }
                else
                {
                    Location l = new Location();
                    //PLoyer p = new PLoyer();

                    l.Id = id;
                    l.RefAppartement = idAppart;
                    l.RefLocataire = idLocataire;
                    l.DebutContrat = debutContrat.Date;
                    l.FinContrat = finContrat;
                    l.Periodicite = periodicite;
                    l.LoyerPayable = loyer_payable;
                    l.LoyerExigible = loyer_exigible;
                    l.Delais = delais;
                    l.Garantie = duree;

                    //p.Id = idPaiement;
                    //p.RefLocation = id;
                    //p.Montant = montant;

                    l.VerifyLocation(lastId);
                    //p.SaveDatas();

                }
            }
            catch (SQLiteException ex)
            {

                MessageBox.Show("Erreur : \nVous ne pouvez loué un local au courant de la même période à plusieurs locataire !","Attention",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChargerUser(new PaiementChargeUser());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PrintFrm p = new PrintFrm();

            if (id > 0)
            {
                p.PrintContrat(id);
                p.Show();
            }
            
        }
    }
}
