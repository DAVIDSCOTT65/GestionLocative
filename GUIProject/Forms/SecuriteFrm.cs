using ObjectDesignLib;
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
    public partial class SecuriteFrm : Form
    {
        public int id = 0;
        public int idLocation = 0;
        public SecuriteFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SecuriteFrm_Load(object sender, EventArgs e)
        {

        }

        private void debutMask_TextChanged(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(debutMask.Text);
            finMask.Text = date.AddMonths(1).ToShortDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.Parse(montantTxt.Text) <= 0)
                ObjectDesign.GetInstance().Alert("Vérifier le montant saisie", CustomDialog.enmType.Error);
            else
            {
                PSecurite el = new PSecurite();
                PrintFrm fr = new PrintFrm();

                el.Id = id;
                el.RefLocation = idLocation;
                el.Montant = float.Parse(montantTxt.Text);
                el.DebutMois = Convert.ToDateTime(debutMask.Text);
                el.FinMois = Convert.ToDateTime(finMask.Text);

                el.SaveDatas();

                fr.PrintRecuSecurite(id);
                fr.Show();

                this.Close();
            }
        }
    }
}
