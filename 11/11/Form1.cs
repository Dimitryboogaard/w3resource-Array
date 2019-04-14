using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intAantalElementen, intTeller, intGeheugen;
        bool booVlag = false;


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
         
                do
                {
                    booVlag = false;
                    for (intTeller = 0; intTeller < intAantalElementen - 1; intTeller++)
                    {
                        if (arrayGetallen[intTeller + 1] < arrayGetallen[intTeller])
                        {
                            intGeheugen = arrayGetallen[intTeller];
                            arrayGetallen[intTeller] = arrayGetallen[intTeller + 1];
                            arrayGetallen[intTeller + 1] = intGeheugen;
                            booVlag = true;
                        }
                    }

                } while (booVlag);

                lblUitvoer.Text = "";

                for (intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    lblUitvoer.Text += arrayGetallen[intTeller].ToString() + ", ";
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
