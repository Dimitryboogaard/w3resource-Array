using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int[] arrayEven = new int[10];
        int[] arrayOneven = new int[10];

        int intAantalElementen, intTeller, intTellerEven, intTellerOneven;

        private void btnInvoeren2_Click(object sender, EventArgs e)
        {
            if(btnInvoeren2.Text == "Invoeren")
            {
                arrayGetallen[intTeller] = Convert.ToInt32(tbInvoer.Text);
                intTeller++;
                tbInvoer.Text = "";
                lblNogTeGaan.Text = Convert.ToString(Convert.ToInt32(lblNogTeGaan.Text) - 1);

                if(lblNogTeGaan.Text == "0")
                {
                    btnInvoeren2.Text = "Antwoord";
                }
            }

            else
            {
                for(intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    if(arrayGetallen[intTeller] % 2 == 0)
                    {
                        arrayEven[intTellerEven] = arrayGetallen[intTeller];
                        intTellerEven++;
                    }

                    if (arrayGetallen[intTeller] % 2 != 0)
                    {
                        arrayOneven[intTellerOneven] = arrayGetallen[intTeller];
                        intTellerOneven++;
                    }
                }

                lblEven.Text = "";
                for (intTeller = 0; intTeller < intTellerEven; intTeller++)
                {
                    lblEven.Text += arrayEven[intTeller] + ", ";
                }

                lblOneven.Text = "";
                for (intTeller = 0; intTeller < intTellerOneven; intTeller++)
                {
                    lblOneven.Text += arrayOneven[intTeller] + ", ";
                }
            }
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);

            lblNogTeGaan.Text = intAantalElementen.ToString();
        }
    }
}
