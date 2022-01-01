using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject.Forms
{
    public partial class ExportDataFrm : Form
    {
        public ExportDataFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //pathTxt.Text = Application.StartupPath;
        }

        private void ExportDataFrm_Load(object sender, EventArgs e)
        {
            FileFrm.instance.Close();
            SauvegardeFrm.instance.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string dbFilePath = Application.StartupPath + @"\data\orders.db";
            string dbFilePath = Application.StartupPath + @"\GestionLocative.db";
            string dbNewFilePath = Application.StartupPath + @"\data\backup\GestionLocative_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")+".db";
            string dirPath = Application.StartupPath + @"\data\backup";
            try
            {
                if (!Directory.Exists(dirPath))
                {
                    //Create BackUp Folder
                    Directory.CreateDirectory(dirPath);
                }
                File.Copy(dbFilePath, dbNewFilePath);
                if (File.Exists(dbNewFilePath))
                {
                    MessageBox.Show("Sauvegarde Successfully");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Backup(string strDestination)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();
            //using (var location = new SQLiteConnection(@"Data Source = GestionLocative.db"))
            //{
            //location.Open();
            SQLiteCommand cmd = (SQLiteCommand)ImplementeConnexion.Instance.Conn.CreateCommand();
                cmd.CommandText = $"VACUUM INTO '{strDestination}'";
                cmd.ExecuteNonQuery();
            //ImplementeConnexion.Instance.Conn.Open();
            //}
        }
    }
}
