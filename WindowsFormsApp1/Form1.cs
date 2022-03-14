using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null )
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "-";
        }

        private void btnMultipy_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "/";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; 
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Sonuc;

            SecondNumber = Convert.ToDouble(textBox1.Text);
            if (Operator == "+")
            {
                Sonuc = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Sonuc);
            }

            if (Operator == "-")
            {
                Sonuc = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Sonuc);
            }

            if (Operator == "*")
            {
                Sonuc = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Sonuc);
            }
            if (Operator == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "İkinci sayı sıfır olamaz!";
                }
                else
                {
                    Sonuc = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Sonuc);
                    FirstNumber = Sonuc;
                }
                
            }
        }
    }
}
