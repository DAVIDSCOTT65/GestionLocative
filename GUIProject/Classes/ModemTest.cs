using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace GUIProject.Classes
{
    class ModemTest
    {
        public List<string> phonesNumbers = new List<string>();
        DataGridView dgMembre = new DataGridView();
        //ClsSms sms = new ClsSms();
        public bool check;
        private static ModemTest _instance = null;
        public static ModemTest Instance()
        {
            if (_instance == null)
                _instance = new ModemTest();
            return _instance;
        }
        //public bool TestModem(string txtPort)
        //{
        //    try
        //    {
        //        if (txtPort == "")
        //        {
        //            //MessageBox.Show("Vérifier que le modem est bien branché ou changer de port.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            check = false;
        //        }
        //        else
        //        {
        //            sms.com = txtPort.Substring(0, 4);
        //            check = sms.connetport();
        //            //statusTxt.Text = "Sending...\n";
        //            System.Threading.Thread.Sleep(1000);
        //            //statusTxt.Text += "\rConnecton Status " + check + "\n";
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return check;
        //}
        public bool GetAllPorts(ComboBox txtPort)
        {
            bool isConnected = false;
            try
            {
                txtPort.Items.Clear();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem ");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if ((string)queryObj["Status"] == "OK")
                    {

                        txtPort.Items.Add(queryObj["AttachedTo"] + " - " + System.Convert.ToString(queryObj["Description"]));
                    }
                    if (txtPort.Items.Count > 0)
                    {
                        txtPort.SelectedIndex = 0;
                        txtPort.DropDownStyle = ComboBoxStyle.DropDownList;
                        isConnected = true;
                    }
                    else
                    {
                        isConnected = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la requette", "Erreur de" + ex.Message);
                isConnected = false;
            }
            return isConnected;
        }
        //public List<string> ChargementDataGrid(string departement)
        //{
        //    try
        //    {
        //        phonesNumbers.Clear();
        //        if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
        //            ImplementeConnexion.Instance.Conn.Open();
        //        using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT_MEMBRE_DEPARTEMENTS";
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cmd.Parameters.Add(Parametre.Instance.AddParametres(cmd, "@department", 200, DbType.String, departement));

        //            IDataReader dr = cmd.ExecuteReader();

        //            while (dr.Read())
        //            {
        //                phonesNumbers.Add(dr["Telephone"].ToString());
        //            }
        //            dr.Dispose();

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Erreur lors du chargement de la table : " + ex.Message);
        //    }
        //    return phonesNumbers;
        //}
        //public int CountContact()
        //{
        //    int count = 0;
        //    try
        //    {

        //        count = phonesNumbers.Count;


        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    return count;
        //}
        //public void SendSms(string phone, string message)
        //{
        //    try
        //    {
        //        sms.sendsms(message.Trim(), phone);

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
