using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GUIProject.Forms
{
    public partial class MailFrm : Form
    {
        public MailFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MailFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string to, from, subject, pass, mail;

                to = (toTxt.Text).ToString();
                from = (fromTxt.Text).ToString();
                subject = (subjectTxt.Text).ToString();
                mail = (messageTxt.Text).ToString();
                pass = "1111996scott";

                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = subject;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                smtp.Send(message);
                MessageBox.Show("Email send successfully");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }
    }
}
