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
using LocationLib;

namespace GUIProject.UserC
{
    public partial class LocataireAddUser : UserControl
    {
        public static LocataireAddUser instance = new LocataireAddUser();
        public int idLocataire = 0;
        public LocataireAddUser()
        {
            InitializeComponent();
            instance = this;
        }
        private void PassData(UserControl user)
        {
            try
            {
                ChargerUser((LocataireInfo)user);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void ChargerUser(LocataireInfo user)
        {
            try
            {

                user.Dock = DockStyle.None;
                locatairePanel.Controls.Clear();
                locatairePanel.Controls.Add(user);

            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur suivant est survenue lors du chargement : " + ex.Message);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            LocataireAddFrm2 fr = new LocataireAddFrm2();
            Locataire l = new Locataire();

            //fr.passControl = new LocataireAddFrm2.PassControl(PassData);

            fr.id = l.Nouveau();
            LocataireAddFrm.instance.idLocataire = fr.id;

            fr.ShowDialog();
        }

        private void LocataireAddUser_Load(object sender, EventArgs e)
        {
            if (idLocataire != 0)
                ChargerUser(new LocataireInfo());
        }
    }
}
