using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayEen[0] = 1;
            arrayEen[1] = 2;
            arrayEen[2] = 3;

            arrayTwee[0] = 1;
            arrayTwee[1] = 2;
            arrayTwee[2] = 3;
        }

        int[] arrayEen = new int[3];
        int[] arrayTwee = new int[3];
        int[] arrayCombinatie = new int[6];

        int intTeller, intTeller2, intLengteArrayEen, intLengteArrayTwee;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intLengteArrayEen = 3;
            intLengteArrayTwee = 3;

            for(intTeller = 0; intTeller < intLengteArrayEen; intTeller++)
            {
                arrayCombinatie[intTeller] = arrayEen[intTeller];
            }

            for(intTeller = 0; intTeller < intLengteArrayTwee; intTeller++)
            {
                arrayCombinatie[intTeller + intLengteArrayEen] = arrayTwee[intTeller];
            }

            Array.Sort(arrayCombinatie);

            lblAntwoord.Text = "";

            for(intTeller = 0; intTeller < intLengteArrayEen + intLengteArrayTwee; intTeller++)
            {
                lblAntwoord.Text += arrayCombinatie[intTeller].ToString() + " ";
            }
        }
    }
}
