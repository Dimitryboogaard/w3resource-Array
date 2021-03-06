﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] arrayMatrix = new int[10, 10];
        int intTeller, intTeller2, intAantalElementen;
        bool booIdentityYesOrNo = true;

        private void btnInvoerMatrix_Click(object sender, EventArgs e)
        {
            if (btnInvoeren2.Text == "Inv. Matrix")
            {
                arrayMatrix[intTeller, intTeller2] = Convert.ToInt32(tbInvoer.Text);
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



            else if (btnInvoeren2.Text == "Antwoord")
            {
                
                for (intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    for (intTeller2 = 0; intTeller2 < intAantalElementen; intTeller2++)
                    {
                        rtMatrix.Text += arrayMatrix[intTeller, intTeller2].ToString() + " ";

                        if(intTeller == intTeller2 && arrayMatrix[intTeller, intTeller2] != 1)
                        {
                            booIdentityYesOrNo = false;
                        }

                        else if(intTeller != intTeller2 && arrayMatrix[intTeller, intTeller2] != 0)
                        {
                            booIdentityYesOrNo = false;
                        }
                    }

                    rtMatrix.Text += Environment.NewLine;
                }

                if(!booIdentityYesOrNo)
                {
                    booIdentityYesOrNo = true;

                    for (intTeller = 0; intTeller < intAantalElementen; intTeller++)
                    {
                        for (intTeller2 = 0; intTeller2 < intAantalElementen; intTeller2++)
                        {

                            if (intTeller == intAantalElementen - 1 - intTeller2 && arrayMatrix[intTeller, intTeller2] != 1)
                            {
                                booIdentityYesOrNo = false;
                            }

                            else if (intTeller != intAantalElementen - 1 - intTeller2 && arrayMatrix[intTeller, intTeller2] != 0)
                            {
                                booIdentityYesOrNo = false;
                            }
                        }

                    }
                }
                lblIdentityYesOrNo.Text = booIdentityYesOrNo.ToString();
            }
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);
            lblNogTeGaan.Text = intAantalElementen.ToString();
            lblNogTeGaan2.Text = intAantalElementen.ToString();
        }
    }
}
