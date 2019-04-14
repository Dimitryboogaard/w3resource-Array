using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayGetallen[0] = 3;
            arrayGetallen[1] = 5;
            arrayGetallen[2] = 1;
        }

        int[] arrayGetallen = new int[10];
        int[] arrayUniekeGetallen = new int[10];
        int intTeller, intTeller2, intTeller3, intUniekeTeller;


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < 10; intTeller++)
            {
                for(intTeller2 = 0; intTeller2 < 10; intTeller2++)
                {
                    if(arrayGetallen[intTeller] == arrayGetallen[intTeller2])
                    {
                        intUniekeTeller++;
                    }
                }

                if(intUniekeTeller == 1)
                {
                    arrayUniekeGetallen[intTeller3] = arrayGetallen[intTeller];
                    intTeller3++;
                }

                intUniekeTeller = 0;
            }
            lblUniekeElementen.Text = "";
            for (intTeller = 0; intTeller < intTeller3; intTeller++)
            {
               
                lblUniekeElementen.Text += arrayUniekeGetallen[intTeller] + " ";
            }
        }
    }
}
