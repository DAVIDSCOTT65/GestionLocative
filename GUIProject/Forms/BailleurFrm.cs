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

namespace GUIProject.Forms
{
    public partial class BailleurFrm : Form
    {
        public int id = 0;
        public string action = "";
        public BailleurFrm()
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
                DateTime date = Convert.ToDateTime(naisanceTxt.Text);

                if (id == 0 || nomTxt.Text == "" || sexeTxt.Text == "" || lieuTxt.Text == "" || date >= DateTime.Today || mailTxt.Text == "" || phoneTxt.Text == "+243_________" || usernameTxt.Text == "" || passTxt.Text == "" || passConfTxt.Text == "" || phoneTxt.Text.Contains(" "))
                {
                    MessageBox.Show("Completez tout les champs svp !");
                }
                else
                {
                    if (!mailTxt.Text.Contains("@"))
                    {
                        MessageBox.Show("Adresse e-mail invalide");
                    }
                    else if(passTxt.Text == passConfTxt.Text)
                    {
                        Users u = new Users();

                        u.Id = id;
                        u.NomComplet = nomTxt.Text;
                        u.Sexe = sexeTxt.Text;
                        u.Lieu = lieuTxt.Text;
                        u.Dob = date;
                        u.Email = mailTxt.Text;
                        u.Telepone = phoneTxt.Text;
                        u.UserName = usernameTxt.Text;
                        u.Pass = passConfTxt.Text;

                        u.SaveDatas(u, action);
                    }
                    else
                    {
                        MessageBox.Show("Vérifier le mot de passe");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
