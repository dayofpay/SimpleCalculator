using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class EasyMode : Form
    {
        public EasyMode()
        {
            InitializeComponent();
        }
        public static string language = "";
        public static int number = 0;
        public static int number2 = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var get = int.Parse(textBox1.Text);
            var a = Convert.ToInt32(get);
            number = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("Number field cannot be null !");
            }
            else
            {
                var FirstNumber = Convert.ToDouble(textBox1.Text);
                var SecondNumber = Convert.ToDouble(textBox4.Text);
                var Result = FirstNumber + SecondNumber;
                textBox3.Text = Result.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var get = int.Parse(textBox4.Text);
            var a = Convert.ToInt32(get);
            number2 = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Advanced advanced = new Advanced();
            advanced.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                language = "Bulgarian";
                button1.Text = "Изчисли";
                button2.Text = "Разширен режим";
            }
            else
            {
                language = "English";
                button1.Text = "Calculate";
                button2.Text = "Advanced Mode";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program developed by dayofpay(https://v-devs.eu) :) ","Program Information");
        }
    }
}
