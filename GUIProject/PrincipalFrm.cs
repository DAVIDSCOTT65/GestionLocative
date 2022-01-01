using GUIProject.Forms;
using GUIProject.Properties;
using GUIProject.UserC;
using ManageSingleConnexion;
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
using UserLib;
using UtilitiesLib;

namespace GUIProject
{
    public partial class PrincipalFrm : Form
    {
        public Image Resource { get; private set; }

        public PrincipalFrm()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            try
            {
                ClsConnection.GetInstance().Connecter();
                var form = new ConnectionFrm();
                form.ShowDialog();
                timer1.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur de chargement : \n" + ex.Message);
            }
        }
        void ChekingLoyer_A_Valider()
        {
            LocationLib.Location l = new LocationLib.Location();

            int count = 0;

            count = l.CountLoyerAValider();

            if(count == 0)
            {
                numberTxt.Text = count.ToString();
                pictureBox8.Image = Resources.Ok_30px;
                appelLbl.Text = count.ToString();
                appelPic.Image = Resources.Ok_30px;
                mailNumber.Text = count.ToString();
                mailPic.Image = Resources.Ok_30px;
            }
            else
            {
                numberTxt.Text = count.ToString();
                pictureBox8.Image = Resources.Warning_Shield_30px;
                appelLbl.Text = count.ToString();
                appelPic.Image = Resources.Warning_Shield_30px;
                mailNumber.Text = count.ToString();
                mailPic.Image = Resources.Warning_Shield_30px;
            }
        }
        void GetBailExpirer()
        {
            LocationLib.Location l = new LocationLib.Location();

            int count = 0;

            count = l.BailExpirer();

            if (count == 0)
            {
                bailTxt.Text = count.ToString();
                bailPic.Image = Resources.Ok_30px;
            }
            else
            {
                bailTxt.Text = count.ToString();
                bailPic.Image = Resources.Warning_Shield_30px;
            }
        }
        void ChekingEau_A_Valider()
        {
            PEau l = new PEau();
            PElectricite e = new PElectricite();
            PSecurite s = new PSecurite();

            int count = 0;

            count = (l.CountPaiementAValider() + e.CountPaiementAValider() + s.CountPaiementAValider());

            if (count == 0)
            {
                eauLbl.Text = count.ToString();
                eauPic.Image = Resources.Ok_30px;
                smsNumber.Text = count.ToString();
                smsPic.Image = Resources.Ok_30px;
            }
            else
            {
                eauLbl.Text = count.ToString();
                eauPic.Image = Resources.Warning_Shield_30px;
                smsNumber.Text = count.ToString();
                smsPic.Image = Resources.Warning_Shield_30px;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
            userLbl.Text = UserSession.GetInstance().NomComplet;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppartFrm fr = new AppartFrm();
            fr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LocateurFrm fr = new LocateurFrm();
            fr.SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE fincontrat > CURRENT_DATE");
            fr.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            EncaisserFrm fr = new EncaisserFrm();
            fr.statut = "Loyer";
            fr.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("dd/MM/yyyy HH:mm:ss");
            ChekingLoyer_A_Valider();
            ChekingEau_A_Valider();
            GetBailExpirer();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            EncaisserChargeFrm f = new EncaisserChargeFrm();
            f.statut = "Charges";
            f.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            EncaisserFrm fr = new EncaisserFrm();
            fr.pictureBox4.Image = Resources.Advertising_70px;
            fr.label6.Text = "Appels de loyer";
            fr.label5.Text = "Cliquez sur le boutton Imprimer pour imprimer";
            fr.statut = "Appel";
            fr.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            LocateurFrm fr = new LocateurFrm();
            fr.SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE fincontrat < CURRENT_DATE");
            fr.button4.Text = "Renouveler";
            fr.button4.Visible = false;
            fr.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EncaisserFrm fr = new EncaisserFrm();
            fr.statut = "Loyer";
            fr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EncaisserFrm fr = new EncaisserFrm();
            fr.pictureBox4.Image = Resources.Advertising_70px;
            fr.label6.Text = "Appels de loyer";
            fr.label5.Text = "Cliquez sur le boutton Imprimer pour imprimer";
            fr.statut = "Appel";
            fr.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            HistoriqueLoyer fr = new HistoriqueLoyer();
            fr.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            EncaisserFrm fr = new EncaisserFrm();
            fr.pictureBox4.Image = Resources.Gmail_100px;
            fr.label6.Text = "Mail";
            fr.label5.Text = "Cliquez sur le boutton Mail pour envoyer le email";
            fr.statut = "Mail";
            fr.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EncaisserFrm fr = new EncaisserFrm();
            fr.pictureBox4.Image = Resources.Gmail_100px;
            fr.label6.Text = "Mail";
            fr.label5.Text = "Cliquez sur le boutton Imprimer pour envoyer le mail";
            fr.statut = "Mail";
            fr.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            EncaisserChargeFrm f = new EncaisserChargeFrm();
            f.statut = "sms";
            f.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EncaisserChargeFrm f = new EncaisserChargeFrm();
            f.statut = "Charges";
            f.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EncaisserChargeFrm f = new EncaisserChargeFrm();
            f.statut = "sms";
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LocateurFrm fr = new LocateurFrm();
            fr.SelectDatas(new LocationLib.Location(), "SELECT * FROM Affichage_Details_Location WHERE fincontrat < CURRENT_DATE");
            fr.button4.Text = "Renouveler";
            fr.button4.Visible = false;
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAQFrm fr = new FAQFrm();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileFrm fr = new FileFrm();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BailleurFrm fr = new BailleurFrm();

            fr.id = UserSession.GetInstance().Id;
            fr.nomTxt.Text = UserSession.GetInstance().NomComplet;
            fr.sexeTxt.Text = UserSession.GetInstance().Sexe;
            fr.lieuTxt.Text = UserSession.GetInstance().Lieu;
            fr.naisanceTxt.Text = UserSession.GetInstance().Dob.ToString();
            fr.mailTxt.Text = UserSession.GetInstance().Email;
            fr.phoneTxt.Text = UserSession.GetInstance().Phone;
            fr.usernameTxt.Text = UserSession.GetInstance().UserName;
            fr.passTxt.Text = UserSession.GetInstance().Pass;
            fr.passConfTxt.Text = UserSession.GetInstance().Pass;
            fr.action = "UPDATE";

            fr.ShowDialog();
        }
    }
}
