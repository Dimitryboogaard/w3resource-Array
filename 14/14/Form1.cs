using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intAantalElementen, intPositie, intGetal, intTeller;

        private void button2_Click(object sender, EventArgs e)
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
                for(intTeller = intAantalElementen - 1; intTeller >= intPositie - 1; intTeller--)
                {
                    arrayGetallen[intTeller + 1] = arrayGetallen[intTeller];

                }

                arrayGetallen[intPositie - 1] = intGetal;

                lblReeks.Text = "";

                for(intTeller = 0; intTeller <= intAantalElementen; intTeller++)
                {
                    lblReeks.Text += arrayGetallen[intTeller].ToString() + " ";
                }
            }
        }


        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);
            intPositie = Convert.ToInt32(tbPositie.Text);
            intGetal = Convert.ToInt16(tbGetal.Text);
            lblNogTeGaan.Text = intAantalElementen.ToString();
        }
    }
}
