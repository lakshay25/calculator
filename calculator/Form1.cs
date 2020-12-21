using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pressed 6 ");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_input.Text);
            txt_input.Text = " ";
            operation = "/";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pressed 0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_input.Text = "";
        }


        private void button_Click(object sender, EventArgs e)
        {
            string existingValue = txt_input.Text;
            txt_input.Text = existingValue + "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string existingValue = txt_input.Text;
            txt_input.Text = existingValue + "2";
                
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string extistingValue = txt_input.Text;
            txt_input.Text = extistingValue + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string extistingValue = txt_input.Text;
            txt_input.Text = extistingValue + "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string extistingValue = txt_input.Text;
            txt_input.Text = extistingValue + "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string exstistingValue = txt_input.Text;
            txt_input.Text = exstistingValue + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string exstistingValue = txt_input.Text;
            txt_input.Text = exstistingValue + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string exstistingValue = txt_input.Text;
            txt_input.Text = exstistingValue + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string exstistingValue = txt_input.Text;
            txt_input.Text = exstistingValue + "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string exstistingValue = txt_input.Text;
            txt_input.Text = exstistingValue + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string exstistingValue = txt_input.Text;
            txt_input.Text = exstistingValue + ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_input.Text);

            txt_input.Text = " ";   
            operation = "*";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(txt_input.Text);
            
            if (operation == "+")
            {
                result = (FirstNumber + secondNumber);
                txt_input.Text = Convert.ToString(result);
                FirstNumber = result;
             }
            if( operation == "-")
            {
                result = (FirstNumber - secondNumber);
                txt_input.Text = Convert.ToString(result);
                FirstNumber = result;
              
            }
            if (operation == "*")
            {
                result = (FirstNumber * secondNumber);
                txt_input.Text = Convert.ToString(result);
                FirstNumber = result;

            }
            if (operation == "/")
            {
                if(secondNumber ==0)
                {
                    txt_input.Text = "Cannot divide by zero";
                }
                else
                {
                    result = (FirstNumber / secondNumber);
                    txt_input.Text = Convert.ToString(result);
                    FirstNumber = result;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_input.Text);
            txt_input.Text = " ";
            operation = "-";
        }   

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_input.Text);
            txt_input.Text = " ";
            operation = "+";
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //backspace
            if (txt_input.Text != string.Empty)
            {
                int txtlength = txt_input.Text.Length;
                    if (txtlength != 1)
                {
                    txt_input.Text = txt_input.Text.Remove(txtlength - 1);
                }
                else
                {
                    txt_input.Text = 0.ToString();

                }
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_input.Text);
            txt_input.Text = " ";
            operation = "/";
        }
    }
}
