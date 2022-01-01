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
    public partial class ConnectionFrm : Form
    {
        public ConnectionFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTxt.Text == "" || passTxt.Text == "")
                    MessageBox.Show("Veuillez completez tous les champs svp !!!", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Users u = new Users();
                    int test = 0;
                    u.UserName = userTxt.Text.Trim();
                    u.Pass = passTxt.Text.Trim();

                    test = u.LoginTest(u);
                    if (test == 1)
                    {
                        this.Close();
                        //frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BailleurFrm fr = new BailleurFrm();
            Users u = new Users();

            fr.action = "INSERT";
            fr.id = u.Nouveau();

            fr.ShowDialog();
        }
    }
}
