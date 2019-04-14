using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arrayGetallen[0] = 2;
            arrayGetallen[1] = 5;
            arrayGetallen[2] = 8;
        }

        int[] arrayGetallen = new int[3];
        int intTeller, intSom;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller <=2; intTeller++)
            {
                intSom += arrayGetallen[intTeller];
            }

            tbUitvoer.Text = intSom.ToString();
        }
    }
}
