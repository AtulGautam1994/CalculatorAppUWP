using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_UWP_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // textBox.Text = 0.ToString();

        }

        string answer ="0";
        int op;



        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            answer = textBox.Text;
            //answer = Convert.ToString(Convert.ToDouble(answer) + Convert.ToDouble(textBox.Text));

            textBox.Text = string.Empty;
            op = 1;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            answer = textBox.Text;
            textBox.Text = string.Empty;
            op = 2;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            answer = textBox.Text;
            textBox.Text = string.Empty;
            op = 3;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            answer = textBox.Text;
            textBox.Text = string.Empty;
            op = 4;
        }

        private void buttonPlusOrMinus_Click(object sender, EventArgs e)
        {
            textBox.Text = Convert.ToString(Convert.ToDouble(textBox.Text)*(-1));
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            char[] chars = textBox.Text.ToCharArray();
            
            chars[textBox.Text.Length - 1] = Convert.ToChar("");

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        private void buttonIsEqualTo_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case 1:
                    answer = Convert.ToString( Convert.ToDouble( answer) + Convert.ToDouble( textBox.Text));
                    textBox.Text = answer;
                    break;
                case 2:
                    answer = Convert.ToString(Convert.ToDouble(answer) - Convert.ToDouble(textBox.Text));
                    textBox.Text = answer;
                    break;
                case 3:
                    answer = Convert.ToString(Convert.ToDouble(answer)* Convert.ToDouble(textBox.Text));
                    textBox.Text = answer;
                    break;
                case 4:
                    if (Convert.ToDouble(textBox.Text) == 0.0)
                    {
                        textBox.Text="Div by 0 not allowed!";
                    }
                    else
                    {
                        answer = Convert.ToString(Convert.ToDouble(answer) / Convert.ToDouble(textBox.Text));
                        textBox.Text = answer;
                    }
                    break;
            }
        }
    }
}
