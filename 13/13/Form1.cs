using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intAantalElementen, intGetal, intTeller, intTeller2;

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
                lblOplopend.Text = "";
                lblOplopendMetExtraGetal.Text = "";

                for(intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    lblOplopend.Text += arrayGetallen[intTeller].ToString() + " ";
                }

                intTeller = 0;

                while (intGetal > arrayGetallen[intTeller])
                {

                    intTeller++;

                }

                for (intTeller2 = intAantalElementen - 1; intTeller2 >= intAantalElementen -
                    (intAantalElementen - intTeller);
                    intTeller2--)
                {
                    arrayGetallen[intTeller2 + 1] = arrayGetallen[intTeller2];
                }

                arrayGetallen[intTeller] = intGetal;

                for (intTeller = 0; intTeller <= intAantalElementen; intTeller++)
                {
                    lblOplopendMetExtraGetal.Text += arrayGetallen[intTeller].ToString() + " ";
                }
            }
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);
            intGetal = Convert.ToInt32(tbGetal.Text);
            lblNogTeGaan.Text = intAantalElementen.ToString();
        }
    }
}
