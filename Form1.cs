using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text=="."&& textBox1.Tag.ToString().Contains("."))
            {
                return;
            }
            if (textBox1.Tag.ToString() == "0")
            {
                textBox1.Text = button.Text;
                textBox1.Tag = button.Text;

            }

            else
            {
                textBox1.Text = textBox1.Text + button.Text;
                textBox1.Tag = textBox1.Tag + button.Text;
            }
        }



            
        char Operation = '0';
        double result = 0;
        private void process (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = button.Text[0];
            result = double.Parse(textBox1.Tag.ToString());
            textBox1.Tag = 0;

        }
        private void Delete(object sender, EventArgs e)
        {
            if (textBox1.Tag.ToString().Length > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Tag = textBox1.Tag.ToString().Remove(textBox1.Tag.ToString().Length - 1, 1);
            }
            else
            {
                textBox1.Text = "0";
                textBox1.Tag = "0";
            }
        }
        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Tag = "0";
            result = 0;
            Operation = '0';
        }
        private void Result(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case '+':
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    textBox1.Tag = textBox1.Text;

                    break;
                case '-':
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    textBox1.Tag = textBox1.Text;
                    break;
                case '×':
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    textBox1.Tag = textBox1.Text;
                    break;
                case '÷':
                    if (textBox1.Text.ToString() == "0")
                    {
                        textBox1.Text = "0";
                        textBox1.Tag = 0;
                        break;
                    }
                    else
                    {
                        textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                        textBox1.Tag = textBox1.Text;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
