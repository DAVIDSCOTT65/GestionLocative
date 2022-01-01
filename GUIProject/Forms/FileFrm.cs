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
    public partial class FileFrm : Form
    {
        public static FileFrm instance = new FileFrm();
        public FileFrm()
        {
            InitializeComponent();
            instance = this;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SauvegardeFrm fr = new SauvegardeFrm();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutFrm fr = new AboutFrm();
            fr.ShowDialog();
        }
    }
}
