using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Advanced : Form
    {
        double FirstNumber;
        string Operation;
        public static string invalidnumber = "0";
        public Advanced()
        {
            InitializeComponent();
            if (EasyMode.language == "Bulgarian")
            {
                button18.Text = "Изход";
            }
            else
            {
                button18.Text = "Exit";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "1";
            }
            else
            {
                resultString.Text = resultString.Text + "1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "2";
            }
            else
            {
                resultString.Text = resultString.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "3";
            }
            else
            {
                resultString.Text = resultString.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "4";
            }
            else
            {
                resultString.Text = resultString.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "5";
            }
            else
            {
                resultString.Text = resultString.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "6";
            }
            else
            {
                resultString.Text = resultString.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "7";
            }
            else
            {
                resultString.Text = resultString.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "8";
            }
            else
            {
                resultString.Text = resultString.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resultString.Text == "0" && resultString.Text != null)
            {
                resultString.Text = "9";
            }
            else
            {
                resultString.Text = resultString.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultString.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultString.Text);
            resultString.Text = "0";
            Operation = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultString.Text);
            resultString.Text = "0";
            Operation = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultString.Text);
            resultString.Text = "0";
            Operation = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(resultString.Text);
            resultString.Text = "0";
            Operation = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultString.Text = resultString.Text + ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(resultString.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                resultString.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                resultString.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                resultString.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    if (EasyMode.language == "Bulgarian")
                    {
                        resultString.Text = "Не може да се извърши деление на число " + invalidnumber;
                    }
                    else
                    {
                        resultString.Text = "You cannot divide by zero !";
                    }

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    resultString.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}