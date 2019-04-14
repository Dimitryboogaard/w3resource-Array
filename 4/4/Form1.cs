using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            arrayGetallen1[0] = 15;
            arrayGetallen1[1] = 10;
            arrayGetallen1[2] = 12;
        }

        int[] arrayGetallen1 = new int[3];
        int[] arrayGetallen2 = new int[3];
        int intTeller;

        private void button1_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller <= 2; intTeller++)
            {
                arrayGetallen2[intTeller] = arrayGetallen1[intTeller];
            }

            for(intTeller = 0; intTeller <= 2; intTeller++)
            {
                lblArray1.Text += arrayGetallen1[intTeller] + " ";
                lblArray2.Text += arrayGetallen2[intTeller] + " ";
            }
        }
    }
}
