using GUIProject.UserC;
using LocationLib;
using ObjectDesignLib;
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
    public partial class LocataireAddFrm2 : Form
    {
        public delegate void PassControl(UserControl user);
        public PassControl passControl;
        public int id = 0;
        public LocataireAddFrm2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                mailTxt.Text.Contains("@");
                if (id <= 0 || nomTxt.Text == "" || postnomTxt.Text == "" || prenomTxt.Text == "" || civiliteTxt.Text == "" || lieuTxt.Text == "" || profTxt.Text == "" || phoneTxt.Text == "" || mailTxt.Text == "" || etatTxt.Text == "")
                    ObjectDesign.GetInstance().Alert("Champs vide !", CustomDialog.enmType.Error);
                else if(!mailTxt.Text.Contains("@"))
                    ObjectDesign.GetInstance().Alert("Email invalid !", CustomDialog.enmType.Warning);
                else
                {
                    Locataire l = new Locataire();

                    l.Id = id;
                    l.Nom = nomTxt.Text;
                    l.Postnom = postnomTxt.Text;
                    l.Prenom = prenomTxt.Text;
                    l.Sexe = (civiliteTxt.Text == "M." ? "M" : "F");
                    l.DOB = Convert.ToDateTime(dobTxt.Text);
                    l.EtatCivil = etatTxt.Text;
                    l.Profession = profTxt.Text;
                    l.NbrEnfant = int.Parse(enfantTxt.Text);
                    l.Telephone = phoneTxt.Text;
                    l.Email = mailTxt.Text;

                    l.SaveDatas(l);

                    ObjectDesign.GetInstance().Alert("Ajouter !", CustomDialog.enmType.Success);

                    LocataireAddUser.instance.locataireInfo1.nomTxt.Text = (civiliteTxt.Text + " " + nomTxt.Text + " " + postnomTxt.Text);
                    LocataireAddUser.instance.locataireInfo1.idLbl.Text = id.ToString();
                    LocataireAddUser.instance.locataireInfo1.Visible = true;
                    this.Close();

                    //LocataireInfo lo = new LocataireInfo();

                    //lo.nomTxt.Text = (civiliteTxt.Text + " " + nomTxt.Text + " " + postnomTxt.Text);
                    //lo.idLbl.Text = id.ToString();

                    ////if (passControl != null)
                    ////{
                    ////    passControl(lo);
                    ////    this.Close();
                    ////}
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : "+ex.Message);
            }
        }

        private void LocataireAddFrm2_Load(object sender, EventArgs e)
        {

        }
    }
}
