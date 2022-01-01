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
    public partial class SauvegardeFrm : Form
    {
        public static SauvegardeFrm instance = new SauvegardeFrm();
        public SauvegardeFrm()
        {
            InitializeComponent();
            instance = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ExportDataFrm fr = new ExportDataFrm();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaureDataFrm fr = new RestaureDataFrm();
            fr.ShowDialog();
        }
    }
}
