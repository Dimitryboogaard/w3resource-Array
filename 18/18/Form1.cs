using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayGetallen[0, 0] = 1;
            arrayGetallen[0, 1] = 2;
            arrayGetallen[0, 2] = 3;
            arrayGetallen[1, 0] = 4;
            arrayGetallen[1, 1] = 5;
            arrayGetallen[1, 2] = 6;
            arrayGetallen[2, 0] = 7;
            arrayGetallen[2, 1] = 8;
            arrayGetallen[2, 2] = 9;

        }

        int[,] arrayGetallen = new int[3, 3];
        int intTeller, intTeller2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller <= 2; intTeller++)
            {
                for(intTeller2 = 0; intTeller2 <= 2; intTeller2++)
                {
                    rtUitvoer.Text += arrayGetallen[intTeller, intTeller2] + " ";
                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
