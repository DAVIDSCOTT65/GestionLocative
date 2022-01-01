using ObjectDesignLib;
using PaiementLib;
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
    public partial class ConfirmPaieFrm : Form
    {
        public int id = 0;
        //public int idCharge = 0;
        public int idLocation = 0;
        public float total = 0;
        public string statut = "";
        public string motif = "";
        public ConfirmPaieFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmPaieFrm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(toggleButton1.Checked == true)
            {
                if (id == 0 || idLocation == 0 || total == 0)
                {
                    MessageBox.Show("Erreur");
                }
                else
                {
                    if (statut == "Loyer")
                    {
                        PLoyer p = new PLoyer();

                        p.Id = id;
                        p.RefLocation = idLocation;
                        p.Montant = total;

                        p.SaveDatas();

                        PrintFrm fr = new PrintFrm();
                        fr.PrintQuittanceLoyer(idLocation);
                        fr.Show();

                        EncaisserFrm.instace.localationFlow.Controls.Clear();
                        EncaisserFrm.instace.SelectDatas(new LocationLib.Location());

                        
                    }
                    else if(statut == "Charges")
                    {
                        switch (motif)
                        {
                            case "Eau":
                                PEau l = new PEau();

                                l.Id = idLocation;

                                l.UpdateDatas(l);
                                ObjectDesign.GetInstance().Alert("Validé !!!", CustomDialog.enmType.Success);
                                PrintFrm p = new PrintFrm();
                                p.PrintRecuEau(idLocation);
                                p.Show();
                                break;
                            case "Electricite":
                                PElectricite el = new PElectricite();

                                el.Id = idLocation;

                                el.UpdateDatas(el);
                                ObjectDesign.GetInstance().Alert("Validé !!!", CustomDialog.enmType.Success);
                                PrintFrm pe = new PrintFrm();
                                pe.PrintRecuElectricite(idLocation);
                                pe.Show();
                                break;
                            case "Securite":
                                PSecurite s = new PSecurite();

                                s.Id = idLocation;

                                s.UpdateDatas(s);

                                ObjectDesign.GetInstance().Alert("Validé !!!", CustomDialog.enmType.Success);
                                PrintFrm pa = new PrintFrm();
                                pa.PrintRecuSecurite(idLocation);
                                pa.Show();
                                break;
                        }
                        EncaisserChargeFrm.instance.localationFlow.Controls.Clear();
                        EncaisserChargeFrm.instance.SelectDatasEau(new PEau());
                        EncaisserChargeFrm.instance.SelectDatasElectricite(new PElectricite());
                        EncaisserChargeFrm.instance.SelectDatasSecurite(new PSecurite());
                    }

                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
