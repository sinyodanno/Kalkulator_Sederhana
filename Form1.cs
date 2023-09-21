using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtBox.Text = " ";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtBox.Text = "x";
            txtDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtBox.Text = "/";
            txtDisplay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtBox.Text = "+";
            txtDisplay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtBox.Text = "-";
            txtDisplay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay.Text);
            {
                switch (opr)
                {
                    case 1:
                        txtDisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        txtDisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        txtDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                    case 4:
                        txtDisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}
