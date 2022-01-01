using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLib;

namespace GUIProject.Forms
{
    public partial class InsertFAQFrm : Form
    {
        public InsertFAQFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (questionTxt.Text == "" || answerTxt.Text == "")
                    MessageBox.Show("Compléter tous les champs !");
                else
                {
                    FAQTable f = new FAQTable();

                    f.Question = questionTxt.Text.Trim();
                    f.Answer = answerTxt.Text.Trim();

                    f.SaveDatas(f);

                    FAQFrm.instance.localationFlow.Controls.Clear();
                    FAQFrm.instance.SelectFAQs(new FAQTable());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
