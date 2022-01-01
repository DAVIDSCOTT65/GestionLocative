using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject.Forms
{
    public partial class RestaureDataFrm : Form
    {
        public RestaureDataFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string backUpDir = Application.StartupPath + @"data\backup";
            string dbFilePath = Application.StartupPath + @"\GestionLocative.db";

            openFileDialog1.Filter = "db File |*.db";
            openFileDialog1.InitialDirectory = backUpDir;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openFileDialog1.FileName, dbFilePath, true);
                if (File.GetLastWriteTime(openFileDialog1.FileName).ToString("dd_MM_yyyy_HH_mm_ss") == File.GetLastWriteTime(dbFilePath).ToString("dd_MM_yyyy_HH_mm_ss"))
                {
                    MessageBox.Show("The data is restored successfully");
                }
                else
                {
                    MessageBox.Show("Data restored failed. Please manually copy files to recover.");
                }
            }
            openFileDialog1.Dispose();
        }
    }
}
