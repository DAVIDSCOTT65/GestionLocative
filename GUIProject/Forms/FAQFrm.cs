using GUIProject.UserC;
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
    public partial class FAQFrm : Form
    {
        public static FAQFrm instance = new FAQFrm();
        public FAQFrm()
        {
            InitializeComponent();
            instance = this;
        }
        public void SelectFAQs(FAQTable l)
        {
            List<FAQTable> lst = new List<FAQTable>();
            lst = l.GetFAQs();

            foreach (var item in lst)
            {
                ChargerFAQUser(new FAQUserControl(), item.Id, item.Question,item.Answer);
            }
        }
        public void Search(FAQTable l)
        {
            List<FAQTable> lst = new List<FAQTable>();
            lst = l.Research(searchTxt.Text);

            foreach (var item in lst)
            {
                ChargerFAQUser(new FAQUserControl(), item.Id, item.Question, item.Answer);
            }
        }
        public void ChargerFAQUser(FAQUserControl userc, int id, string question,string answer)
        {
            try
            {
                userc.idLbl.Text = id.ToString();
                userc.questionLbl.Text = question;
                userc.answerLbl.Text = answer;

                userc.Dock = DockStyle.None;
                localationFlow.Controls.Add(userc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertFAQFrm fr = new InsertFAQFrm();
            fr.ShowDialog();
        }

        private void FAQFrm_Load(object sender, EventArgs e)
        {
            
            SelectFAQs(new FAQTable());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            localationFlow.Controls.Clear();
            Search(new FAQTable());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
