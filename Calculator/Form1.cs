using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number1, number2, result;
        string str;

        private void butzarb_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "*";
            label2.Text=(number1 + " *");
        }

        private void butmaynez_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "-";
            label2.Text = (number1 + " -");
        }

        private void butplas_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "+";
            label2.Text = (number1 + " +");
        }

        private void buttaghsim_Click(object sender, EventArgs e)
        {
            number1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "/";
            label2.Text = (number1 + " /");
        }

        private void butmosavi_Click(object sender, EventArgs e)
        {
             number2 = int.Parse(textBox1.Text);
            int x;
            x = number2;
            switch (str)
            {
                case "+": result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    result = number1 / number2;
                    break;

                case "X²":
                    
                    for (int i = 1; i < x; i++)
                    {
                        if (x == 1)
                            result = number1;
                        else
                            result = number1 * number1;
                    }
                    
                    break;
            }
            textBox1.Text = result.ToString();
            label3.Text = (number2 + " =");
        }

        private void buttavan_Click(object sender, EventArgs e)
        {
            number1=int.Parse(textBox1.Text);
            textBox1.Text = "";
            label2.Text = (number1 + " X²");
            str = "X²";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = label2.Text = null;
        }

        private void butdelate_Click(object sender, EventArgs e)
        {
            textBox1.Text.Count();
        }

        private void butdeleteall_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label3.Text = label2.Text = null;
        }

        private void but1_Click(object sender, EventArgs e)
        {
           Button b = (Button)sender;
           textBox1.Text += b.Text;
           
        }
    }
}
