using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProperCalculator1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            
            this.screen.Text = "";
            input += "0";
            this.screen.Text += input;
        }

   
        private void One_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "1";
            this.screen.Text += input;
            
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "2";
            this.screen.Text += input;
            
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "3";
            this.screen.Text += input;
            
        }
     

        private void Four_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "4";
            this.screen.Text += input;
            
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "5";
            this.screen.Text += input;
            
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "6";
            this.screen.Text += input;
            
        }

     
        private void Seven_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "7";
            this.screen.Text += input;
            
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "8";
            this.screen.Text += input;
            
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "9";
            this.screen.Text += input;
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = 'C';
            input = string.Empty;
            this.screen.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

        }


        private void Plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;

        }

        private void Decimalpoint_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '.';
            input = string.Empty;

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }
        private void Equal_Click(object sender, EventArgs e)
        {
            //operand1 = input;
            //operation = '=';
            //input = string.Empty;
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            //clear input and operand string so calc ready for next op
            this.screen.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;


            if (operation == '+')
            {
                result = num1 + num2;
                screen.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                screen.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                screen.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    screen.Text = result.ToString();
                }
                else
                {
                    screen.Text = "DIV/Zero!";
                }

            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
