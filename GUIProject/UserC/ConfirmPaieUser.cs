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
using PaiementLib;
using GUIProject.Properties;

namespace GUIProject.UserC
{
    public partial class ConfirmPaieUser : UserControl
    {
        public string statut = "";
        public string motif = "";
        public ConfirmPaieUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Encaisser")
            {
                ConfirmPaieFrm fr = new ConfirmPaieFrm();
                PLoyer l = new PLoyer();

                fr.id = l.Nouveau();
                fr.idLocation = int.Parse(idLbl.Text);
                fr.totalTxt.Text = totalTxt.Text;
                fr.total = float.Parse(totTxt.Text);
                fr.statut = statut;
                fr.motif = motif;

                fr.ShowDialog();
            }
            else if(button1.Text == "Imprimer")
            {
                PrintFrm fr = new PrintFrm();
                fr.PrintAvisEcheance(int.Parse(idLbl.Text));
                fr.Show();
            }
            else if(button1.Text == "Email")
            {
                MailFrm fr = new MailFrm();

                fr.toTxt.Text = emailTxt.Text;
                fr.subjectTxt.Text = "Avis d’échéance du " + saveDate.Text;
                fr.messageTxt.Text = "Somme à payer sur le terme du terme " + dureeTxt.Text+ " \r\n-Loyer : "+montantTxt.Text+" \r\n-Durée : "+moisTxt.Text+ " \r\nMontant total du terme : "+totalTxt.Text+ "\r\nPour loyer et accessoires des locaux sis : "+adresseTxt.Text;

                fr.ShowDialog();
            }
            else if(button1.Text == "SMS")
            {
                SMSFrm fr = new SMSFrm();
                if (imgName.Text == "Eau")
                {
                    fr.messageTxt.Text = "FACTURE - Eau \r\nBonjour "+ locateurTxt .Text + ", votre facture d'eaux pour la période "+ dureeTxt.Text.Replace("00:00:00","")+" est de "+totalTxt.Text+".\r\nLe bailleur";
                }
                else if(imgName.Text == "Electricite")
                {
                    fr.messageTxt.Text = "FACTURE - Electricité \r\nBonjour " + locateurTxt.Text + ", votre facture pour la période " + dureeTxt.Text.Replace("00:00:00", "") + " est de " + totalTxt.Text + ".\r\nLe bailleur";
                }
                else if(imgName.Text  == "Securite")
                {
                    fr.messageTxt.Text = "FACTURE - Sécurité \r\nBonjour " + locateurTxt.Text + ", votre facture pour la période " + dureeTxt.Text.Replace("00:00:00", "") + " est de " + totalTxt.Text + ".\r\nLe bailleur";
                }
                fr.phoneTxt.Text = phoneTxt.Text;
                fr.ShowDialog();
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dureeTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
