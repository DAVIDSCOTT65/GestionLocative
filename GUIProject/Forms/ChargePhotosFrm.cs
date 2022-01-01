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
    public partial class ChargePhotosFrm : Form
    {
        bool mouseDown;
        private Point offset;
        public delegate void PassControl(object sender,string piece);
        public PassControl passControl;
        public ChargePhotosFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pieceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();

            try
            {
                if (openDlg.FileName != null)
                {
                    // try to open the file
                    this.img.Image = Bitmap.FromFile(openDlg.FileName);
                    //this.tbFileName.Text = openDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("L'erreur suivant est survenue lors du chargement de la photo : " + ex.Message);
            }
        }

        private void ChargePhotosFrm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (passControl != null)
            {
                passControl(img,pieceCombo.Text);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
