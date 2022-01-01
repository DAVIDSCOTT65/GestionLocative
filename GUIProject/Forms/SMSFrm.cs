using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using GUIProject.Properties;
using GUIProject.Classes;

namespace GUIProject.Forms
{
    public partial class SMSFrm : Form
    {
        string txt = "Facture Eau " +
"Bonjour LUCIE REHEMA Bashizi," +
"Votre facture d'eaux pour la période du 20/01/2021 00:00:00 au 20/02/2021 se prélève comme suit :" +
 "-Quantité cons";
        
        public SMSFrm()
        {
            InitializeComponent();
            timer1.Start();
            statutTxt.Text = txt.Count().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TestModem();
            try
            {
                SerialPort sp = new SerialPort();
                sp.PortName = txtPort.Text.Substring(0, 5);
                sp.Open();
                sp.WriteLine("AT&F" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"" + phoneTxt.Text + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(messageTxt.Text + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var response = sp.ReadExisting();
                statutTxt.Text = messageTxt.Text.Count().ToString();
                if (response.Contains("ERROR"))
                {
                    MessageBox.Show("Echec d'envoie !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Message envoyé !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sp.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void ConnectModem()
        {
            bool test = ModemTest.Instance().GetAllPorts(txtPort);
            if (test == true)
            {
                modemPic.Image = Resources.USB_Connected_25px;
                phoneTxt.Enabled = true;
                messageTxt.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                modemPic.Image = Resources.USB_Disconnected_25px;
                txtPort.SelectedItem = "";
                phoneTxt.Enabled = false;
                messageTxt.Enabled = false;
                button1.Enabled = false;
            }

        }
        private void TestModem()
        {
            try
            {
                if (txtPort.Text == "")
                {
                    MessageBox.Show("Vérifier que le modem est bien branché ou changer de port.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string com = "";
                    com = txtPort.Text.Substring(0, 5);
                    //check = sms.connetport();
                    //statusTxt.Text = "Sending...\n";
                    //Thread.Sleep(1000);
                    //statusTxt.Text += "\rConnecton Status " + check + "\n";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SMSFrm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ConnectModem();
        }
    }
}
