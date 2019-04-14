using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intElementen, intTeller;
        int[] arrayGetallen = new int[1000];



        private void btnInvoer_Click(object sender, EventArgs e)
        {
            intElementen = Convert.ToInt32(tbElementen.Text);
            lblAantal.Text = intElementen.ToString();
        }

        private void btnInvoer2_Click(object sender, EventArgs e)
        {
            if(btnInvoer2.Text == "Invoer")
            {
                arrayGetallen[intTeller] = Convert.ToInt32(tbInvoer.Text);
                intTeller++;
                lblAantal.Text = Convert.ToString(Convert.ToInt32(lblAantal.Text) - 1);
                tbInvoer.Text = "";
                if(intTeller == intElementen)
                {
                    btnInvoer2.Text = "Antwoord";
                }
            }

            else if(btnInvoer2.Text == "Antwoord")
            {
                for(intTeller = 0; intTeller < intElementen; intTeller++)
                {
                    rtUitvoer.Text += Convert.ToString(arrayGetallen[intTeller]) + " ";
                }

                rtUitvoer.Text += Environment.NewLine;

                for(intTeller = intElementen - 1; intTeller >= 0; intTeller--)
                {
                    rtUitvoer.Text += Convert.ToString(arrayGetallen[intTeller]) + " ";
                }
            }
        }
    }
}
