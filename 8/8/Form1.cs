using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int[] arrayAantal = new int[10];
        int[] arrayGetallenGesorteerd = new int[10];
        int intTeller, intTeller2, intTeller3, intTeller4, intTeller5, intAantalElementen, intFrequentie;
        bool boo1Maal = false;

        private void btnInvoerenGetallen_Click(object sender, EventArgs e)
        {
            if (btnInvoerenGetallen.Text == "Invoeren")
            {
                lblNogTeGaan.Text = Convert.ToString(Convert.ToInt32(lblNogTeGaan.Text) - 1);

                arrayGetallen[intTeller] = Convert.ToInt32(tbInvoerGetallen.Text);
                intTeller++;

                if (intTeller == intAantalElementen)
                {
                    btnInvoerenGetallen.Text = "Antwoord";

                    tbInvoer.Text = "";
                }

                tbInvoerGetallen.Text = "";
            }

            else if(btnInvoerenGetallen.Text == "Antwoord")
            {
                arrayGetallenGesorteerd[0] = arrayGetallen[0];

                for(intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    for(intTeller2 = 0; intTeller2 < intAantalElementen; intTeller2++)
                    {
                        if(arrayGetallenGesorteerd[intTeller2] == arrayGetallen[intTeller])
                        {
                            arrayAantal[intTeller2]++;
                        }

                        else
                        {
                            for(intTeller3 = 0; intTeller3 < intAantalElementen; intTeller3++)
                            {
                                if(arrayGetallenGesorteerd[intTeller3] != arrayGetallen[intTeller])
                                {
                                    intTeller4++;
                                }
                            }

                            if(intTeller4 == intAantalElementen)
                            {
                                boo1Maal = true;
                            }

                            intTeller4 = 0;
                        }
                            
                    }

                    if(boo1Maal)
                    {
                        intTeller5++;
                        arrayGetallenGesorteerd[intTeller5] = arrayGetallen[intTeller];
                        arrayAantal[intTeller5]++;
                        boo1Maal = false;
                    }

                    boo1Maal = false;
                }

                for (intTeller = 0; intTeller <= intTeller5; intTeller++)
                {
                    rtUitvoer.Text += arrayGetallenGesorteerd[intTeller] + " verschijnt " + 
                                      arrayAantal[intTeller].ToString() + " keer." + Environment.NewLine;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt16(tbInvoer.Text);
            lblNogTeGaan.Text = intAantalElementen.ToString();

        }


    }
}
