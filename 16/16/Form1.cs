﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intAantalElementen, intMax, intMax2e,intTeller;

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            intAantalElementen = Convert.ToInt32(tbAantalElementen.Text);
            lblNogTeGaan.Text = intAantalElementen.ToString();
        }

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
                for(intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    if(arrayGetallen[intTeller] > intMax)
                    {
                        intMax = arrayGetallen[intTeller];
                    }
                }

                for (intTeller = 0; intTeller < intAantalElementen; intTeller++)
                {
                    if (arrayGetallen[intTeller] > intMax2e && arrayGetallen[intTeller] < intMax)
                    {
                        intMax2e = arrayGetallen[intTeller];
                    }
                }

                lblAntwoord.Text = intMax2e.ToString();
            }
        }
    }
}
