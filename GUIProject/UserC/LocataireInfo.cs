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

namespace GUIProject.UserC
{
    public partial class LocataireInfo : UserControl
    {
        public LocataireInfo()
        {
            InitializeComponent();
        }
        private void PassData(string identite, string idLocataire)
        {
            try
            {
                nomTxt.Text = identite;
                idLbl.Text = idLocataire.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LocataireInfo_Load(object sender, EventArgs e)
        {
            //LocataireAddUser.instance.idLocataire = int.Parse(idLbl.Text);
            //LocataireAddUser.instance.addresseTxt.Text = (nomTxt.Text + "\n" + LocataireAddUser.instance.addresseTxt.Text);
            //LocataireAddFrm.instance.idLocataire = int.Parse(idLbl.Text);
        }
    }
}
