using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arrayGetallen[0] = 2;
            arrayGetallen[1] = 2;
            arrayGetallen[2] = 1;
            arrayGetallen[3] = 1;
            arrayGetallen[4] = 5;
            arrayGetallen[5] = 5;
        }

        int[] arrayGetallen = new int[10];
        int[] arrayDuplicaat = new int[10];
        
        int intTeller, intTeller2, intTeller3, intTeller4, intDuplicaatTeller, intDuplicaatTeller2;
        bool booDuplicaat = false;

        private void button1_Click(object sender, EventArgs e)
        {
            for (intTeller = 0; intTeller <= 5; intTeller++)
            {
                for (intTeller2 = intTeller; intTeller2 <= 5; intTeller2++)
                {
                    if(arrayGetallen[intTeller] == arrayGetallen[intTeller2])
                    {
                        do
                        {
                            if (arrayDuplicaat[intTeller3] == arrayGetallen[intTeller])

                            {
                                booDuplicaat = true;
                            }

                            intTeller3++;
                        } while (intTeller3 <= intTeller);

                        if (!booDuplicaat)
                        {

                            intDuplicaatTeller++;
                        }

                        intTeller3 = 0;

                        booDuplicaat = false;
                        
                    }

                    if(intDuplicaatTeller > 1)
                    {
                        arrayDuplicaat[intTeller] = arrayGetallen[intTeller];
                    }


                }

                if (intDuplicaatTeller > 1)
                {
                    intDuplicaatTeller2++;
                }

                intDuplicaatTeller = 0;

            }
           

               

                
            

            lblDuplicaten.Text = intDuplicaatTeller2.ToString();
        }
    }
}
