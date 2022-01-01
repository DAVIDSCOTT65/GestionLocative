using AppartementLib;
using ObjectDesignLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject.Forms
{
    public partial class AppartAddFrm : Form
    {
        public int id = 0;
        public string statut = "";
        public AppartAddFrm()
        {
            InitializeComponent();
            nonMeubleeRbtn.Checked = true;
        }
        private void PassData(object sender, string piece)
        {
            try
            {
                switch (piece)
                {
                    case "Salon":
                        salonPic.Image = ((PictureBox)sender).Image;
                        break;
                    case "Cuisine":
                        cuisinePic.Image = ((PictureBox)sender).Image;
                        break;
                    case "Toilette":
                        toilettePic.Image = ((PictureBox)sender).Image;
                        break;
                    case "Autres pièces":
                        autrePic.Image = ((PictureBox)sender).Image;
                        break;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(float.Parse(salonTxt.Text) > 0)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (float.Parse(cuisineTxt.Text) > 0)
            {
                ff.Checked = true;
            }
            else
            {
                ff.Checked = false;
            }
            if (float.Parse(toiletteTxt.Text) > 0)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }
            if (float.Parse(autrePieceTxt.Text) > 0)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }
            if(float.Parse(salonTxt.Text) > 0 || float.Parse(cuisineTxt.Text) > 0 || float.Parse(toiletteTxt.Text) > 0 || float.Parse(autrePieceTxt.Text) > 0)
            {
                photosBtn.Visible = true;
            }
            else
            {
                photosBtn.Visible = false;
            }
        }

        private void AppartAddFrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void photosBtn_Click(object sender, EventArgs e)
        {
            ChargePhotosFrm frm = new ChargePhotosFrm();
            frm.passControl = new ChargePhotosFrm.PassControl(PassData);

            if (float.Parse(salonTxt.Text) > 0)
            {
                frm.pieceCombo.Items.Add(checkBox1.Text);
            }
            if (float.Parse(cuisineTxt.Text) > 0)
            {
                frm.pieceCombo.Items.Add(ff.Text);
            }
            if (float.Parse(toiletteTxt.Text) > 0)
            {
                frm.pieceCombo.Items.Add(checkBox3.Text);
            }
            if (float.Parse(autrePieceTxt.Text) > 0)
            {
                frm.pieceCombo.Items.Add(checkBox4.Text);
            }
            
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomTxt.Text == "" || adresseTxt.Text == "" || villeTxt.Text == "" || paysTxt.Text == "" || checkBox1.Checked != true || float.Parse(montantTxt.Value.ToString()) <= 0 || int.Parse(garantiTxt.Text) <= 0 || int.Parse(capaciteNum.Text) <= 0)
                    ObjectDesign.GetInstance().Alert("Champs vide", CustomDialog.enmType.Error);
                else
                {
                    Appartements a = new Appartements();

                    ImagesAppartements i = new ImagesAppartements();
                    i.RefAppartement = id;

                    a.Id = id;
                    a.RefType = a.RetourId(meubleeRbtn.Checked == true ? meubleeRbtn.Text.Trim() : nonMeubleeRbtn.Text.Trim());
                    a.Salon = int.Parse(salonTxt.Text);
                    a.Chambre = int.Parse(autrePieceTxt.Text);
                    a.Cuisine = int.Parse(cuisineTxt.Text);
                    a.Toilette = int.Parse(toiletteTxt.Text);
                    a.MontantParMois = float.Parse(montantTxt.Text);
                    a.Garantie = int.Parse(garantiTxt.Text);
                    a.Adresse = adresseTxt.Text;
                    a.Nom = nomTxt.Text.Trim();
                    a.Ville = villeTxt.Text;
                    a.Pays = paysTxt.Text;
                    a.Capacite = int.Parse(capaciteNum.Text);

                    switch (statut)
                    {
                        case "insert":
                            a.SaveDatas(a,statut);

                            if (checkBox1.Checked)
                            {

                                i.Piece = checkBox1.Text;
                                i.Img = salonPic.Image;

                                i.SaveDatas(i);
                            }
                            if (ff.Checked)
                            {
                                //i.RefAppartement = id;
                                i.Piece = ff.Text;
                                i.Img = cuisinePic.Image;

                                i.SaveDatas(i);
                            }
                            if (checkBox3.Checked)
                            {
                                //i.RefAppartement = id;
                                i.Piece = checkBox3.Text;
                                i.Img = toilettePic.Image;

                                i.SaveDatas(i);
                            }
                            if (checkBox4.Checked)
                            {
                                //i.RefAppartement = id;
                                i.Piece = checkBox4.Text;
                                i.Img = autrePic.Image;

                                i.SaveDatas(i);
                            }
                            ObjectDesign.GetInstance().Alert("Location Ajoutée !", CustomDialog.enmType.Success);
                            break;
                        case "update":
                            a.SaveDatas(a, statut);
                            ObjectDesign.GetInstance().Alert("Location Modifiée !", CustomDialog.enmType.Success);
                            break;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur in Database : " + ex.Message);
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Erreur : "+ex.Message);
            }
        }
    }
}
