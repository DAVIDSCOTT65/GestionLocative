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
    public partial class DetailBailUser : UserControl
    {
        public float loyer = 0;
        public float total = 0;
        public string periodicite = "";
        public string loyerPayable = "";
        public int idAppart = 0;

        public static DetailBailUser instance = new DetailBailUser();
        public DetailBailUser()
        {
            InitializeComponent();
            instance = this;
        }

        private void DetailBailUser_Load(object sender, EventArgs e)
        {
            expirRbtn.Checked = true;
            debutRbtn.Checked = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(debutTxt.Text);
            int val = Convert.ToInt32(dureeTxt.Text);
            finTxt.Value = date.AddMonths(val);

            if(LocataireAddFrm.instance.idAppart == 0)
                LocataireAddFrm.instance.idAppart = int.Parse(locationUser1.idLbl.Text);
            LocataireAddFrm.instance.debutContrat = debutTxt.Value;
            LocataireAddFrm.instance.finContrat = finTxt.Value;
            LocataireAddFrm.instance.periodicite = periodicite;
            LocataireAddFrm.instance.loyer_payable = loyerPayable;
            LocataireAddFrm.instance.loyer_exigible = exigTxt.Text;
            LocataireAddFrm.instance.delais = int.Parse(delaisTxt.Text);
            LocataireAddFrm.instance.montant = total;
            LocataireAddFrm.instance.duree = int.Parse(dureeTxt.Value.ToString());
        }
        public void calcul()
        {
            decimal val = dureeTxt.Value;
            total = (loyer * int.Parse(val.ToString()));
            totalTxt.Text = total.ToString() + "$";
        }
        private void dureeTxt_ValueChanged(object sender, EventArgs e)
        {
            if(dureeTxt.Value != 0)
            {
                decimal val = dureeTxt.Value;
                total = (loyer * int.Parse(val.ToString()));
                totalTxt.Text = total.ToString() + "$";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            periodicite = radioButton1.Text.Trim();
        }

        private void expirRbtn_CheckedChanged(object sender, EventArgs e)
        {
            periodicite = expirRbtn.Text.Trim();
        }

        private void debutRbtn_CheckedChanged(object sender, EventArgs e)
        {
            loyerPayable = debutRbtn.Text.Trim();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            loyerPayable = radioButton3.Text.Trim();
        }

        private void debutTxt_ValueChanged(object sender, EventArgs e)
        {
            if (dureeTxt.Value != 0)
            {
                decimal val = dureeTxt.Value;
                total = (loyer * int.Parse(val.ToString()));
                totalTxt.Text = total.ToString() + "$";
            }
        }

        private void locationUser1_Load(object sender, EventArgs e)
        {
            
        }

        private void locationUser1_MouseClick(object sender, MouseEventArgs e)
        {
            AppartFrm fr = new AppartFrm();
            fr.ShowDialog();
        }
    }
}
