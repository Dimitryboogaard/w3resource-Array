using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intTeller, intMin, intMax, intAantalElementen;
        
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
                intMax = arrayGetallen[0];
                intMin = arrayGetallen[0];

                for(intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    if(arrayGetallen[intTeller] > intMax)
                    {
                        intMax = arrayGetallen[intTeller];
                    }

                    if(arrayGetallen[intTeller] < intMin)
                    {
                        intMin = arrayGetallen[intTeller];
                    }
                }
            }

            lblMax.Text = intMax.ToString();
            lblMin.Text = intMin.ToString();
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);

            lblNogTeGaan.Text = intAantalElementen.ToString();
        }
    }
}
