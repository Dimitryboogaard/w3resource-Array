using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intAantalElementen, intPositie, intTeller;

        private void btnInvoeren2_Click(object sender, EventArgs e)
        {
            if(btnInvoeren2.Text == "Invoeren")
            {
                arrayGetallen[intTeller] = Convert.ToInt32(tbInvoer.Text);
                intTeller++;
                lblNogTeGaan.Text = Convert.ToString(Convert.ToInt32(lblNogTeGaan.Text) - 1);
                tbInvoer.Text = "";

                if(lblNogTeGaan.Text == "0")
                {
                    btnInvoeren2.Text = "Antwoord";
                }
            }

            else
            {
                lblOudeReeks.Text = "";

                for (intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    lblOudeReeks.Text += arrayGetallen[intTeller].ToString() + " ";
                }

                for (intTeller = intPositie - 1; intTeller < intAantalElementen; intTeller++)
                {
                    arrayGetallen[intTeller] = arrayGetallen[intTeller + 1];
                }

                lblNieuweReeks.Text = "";

                for(intTeller = 0; intTeller < intAantalElementen - 1; intTeller++)
                {
                    lblNieuweReeks.Text += arrayGetallen[intTeller].ToString() + " ";
                }
            }
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);
            intPositie = Convert.ToInt32(tbPositie.Text);
            lblNogTeGaan.Text = intAantalElementen.ToString();
        }
    }
}
