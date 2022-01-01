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
    public partial class PaiementChargeOptionFrm : Form
    {
        public PaiementChargeOptionFrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (electRbtn.Checked)
            {
                ElecticiteFrm f = new ElecticiteFrm();
                PElectricite p = new PElectricite();

                f.id = p.Nouveau();
                f.idLocation = LocataireAddFrm.instance.id;

                f.debutMask.Text = p.GetDateDebutMois(LocataireAddFrm.instance.id).ToShortDateString();

                if(f.debutMask.Text != "01/01/0001")
                    f.ShowDialog();
            }
            if (eauRbtn.Checked)
            {
                EauFrm f = new EauFrm();
                PEau p = new PEau();

                f.id = p.Nouveau();
                f.idLocation = LocataireAddFrm.instance.id;

                f.debutMask.Text = p.GetDateDebutMois(LocataireAddFrm.instance.id).ToShortDateString();

                if (f.debutMask.Text != "01/01/0001")
                    f.ShowDialog();
            }
            if (secRbtn.Checked)
            {
                SecuriteFrm f = new SecuriteFrm();
                PSecurite p = new PSecurite();

                f.id = p.Nouveau();
                f.idLocation = LocataireAddFrm.instance.id;

                f.debutMask.Text = p.GetDateDebutMois(LocataireAddFrm.instance.id).ToShortDateString();

                if (f.debutMask.Text != "01/01/0001")
                    f.ShowDialog();
            }
        }
    }
}
