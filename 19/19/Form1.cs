using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] arrayMatrix1 = new int[4, 4];
        int[,] arrayMatrix2 = new int[4, 4];
        int intTeller, intTeller2, intAantalElementen;

        private void btnInvoeren2_Click(object sender, EventArgs e)
        {
            if(btnInvoeren2.Text == "Inv. Matr. 1")
            {
                arrayMatrix1[intTeller, intTeller2] = Convert.ToInt32(tbInvoer.Text);
                intTeller2++;

                lblNogTeGaan2.Text = Convert.ToString(intAantalElementen - intTeller2);
                lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);

                tbInvoer.Text = "";

                if (intTeller2 == intAantalElementen)
                {
                    intTeller++;
                    intTeller2 = 0;

                    if (intTeller != intAantalElementen && intTeller2 != intAantalElementen)
                    {
                        lblNogTeGaan2.Text = Convert.ToString(intAantalElementen - intTeller2);
                        lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);
                    }

                    else
                    {
                        lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);

                    }
                }

                if (intTeller == intAantalElementen)
                {
                    btnInvoeren2.Text = "Inv. Matr. 2";
                    intTeller = 0;
                    intTeller2 = 0;

                    lblNogTeGaan2.Text = Convert.ToString(intAantalElementen - intTeller2);
                    lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);

                }
            }

            else if(btnInvoeren2.Text == "Inv. Matr. 2")
            {
                arrayMatrix2[intTeller, intTeller2] = Convert.ToInt32(tbInvoer.Text);
                intTeller2++;

                lblNogTeGaan2.Text = Convert.ToString(intAantalElementen - intTeller2);
                lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);

                tbInvoer.Text = "";

                if (intTeller2 == intAantalElementen)
                {
                    intTeller++;
                    intTeller2 = 0;

                    if (intTeller != intAantalElementen && intTeller2 != intAantalElementen)
                    {
                        lblNogTeGaan2.Text = Convert.ToString(intAantalElementen - intTeller2);
                        lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);
                    }

                    else
                    {
                        lblNogTeGaan.Text = Convert.ToString(intAantalElementen - intTeller);

                    }
                }

                if (intTeller == intAantalElementen)
                {
                    btnInvoeren2.Text = "Antwoord";
                    intTeller = 0;
                    intTeller2 = 0;
                }
            }

            else if(btnInvoeren2.Text == "Antwoord")
            {
                for(intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    for(intTeller2 = 0; intTeller2 < intAantalElementen; intTeller2++)
                    {
                        rtMatrix1.Text += arrayMatrix1[intTeller, intTeller2].ToString() + " ";
                        rtMatrix2.Text += arrayMatrix2[intTeller, intTeller2].ToString() + " ";
                        rtSom.Text += Convert.ToString(arrayMatrix1[intTeller, intTeller2] +
                                      arrayMatrix2[intTeller, intTeller2]) + " ";
                    }

                    rtMatrix1.Text += Environment.NewLine;
                    rtMatrix2.Text += Environment.NewLine;
                    rtSom.Text += Environment.NewLine;
                }
            }
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tbAantalElementen.Text) > 4)
            {
                tbAantalElementen.Text = "Kleiner dan 5";
            }

            else
            {
                intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);
                lblNogTeGaan.Text = intAantalElementen.ToString();
                lblNogTeGaan2.Text = intAantalElementen.ToString();
            }
        }
    }
}
