using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new int[10];
        int intTeller;

        private void lblInvoeren_Click(object sender, EventArgs e)
        {
            if(btnInvoeren.Text == "Invoeren")
            {
                arrayGetallen[intTeller] = Convert.ToInt32(tbInvoer.Text);
                intTeller++;
                lblAantal.Text = Convert.ToString(Convert.ToInt16(lblAantal.Text) - 1);
                tbInvoer.Text = "";

                if(intTeller == 10)
                {
                    btnInvoeren.Text = "Antwoord";
                }
            }

            else if(btnInvoeren.Text == "Antwoord")
            {
                for(intTeller = 0; intTeller <= 9; intTeller++)
                {
                    rtUitvoer.Text += Convert.ToString(arrayGetallen[intTeller]) + Environment.NewLine;
                }
            }
        }
    }
}
