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
    public partial class EauFrm : Form
    {
        public int id = 0;
        public int idLocation = 0;

        decimal val1 = 0;
        decimal val2 = 0;
        public EauFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void debutMask_TextChanged(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(debutMask.Text);
            finMask.Text = date.AddMonths(1).ToShortDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.Parse(prixTxt.Text) <= 0 || float.Parse(qteTxt.Text) <= 0)
                ObjectDesign.GetInstance().Alert("Vérifier les montants saisie !", CustomDialog.enmType.Error);
            else
            {
                PEau el = new PEau();
                PrintFrm fr = new PrintFrm();

                el.Id = id;
                el.RefLocation = idLocation;
                el.QteCubage = float.Parse(qteTxt.Text);
                el.PuCube = float.Parse(prixTxt.Text);
                el.DebutMois = Convert.ToDateTime(debutMask.Text);
                el.FinMois = Convert.ToDateTime(finMask.Text);

                el.SaveDatas(el);

                fr.PrintRecuEau(id);

                fr.Show();

                this.Close();
            }
        }
        void CalculTotal(decimal val1,decimal val2)
        {
            try
            {
                totalTxt.Value = (val1 * val2);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : "+ex.Message);
            }
            
        }
        private void prixTxt_ValueChanged(object sender, EventArgs e)
        {
            val1 = prixTxt.Value;
        }

        private void qteTxt_ValueChanged(object sender, EventArgs e)
        {
            val2 = qteTxt.Value;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CalculTotal(val1,val2);
        }

        private void EauFrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
