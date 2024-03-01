using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface_1
{
    public partial class Form1 : Form
    {

        string first = "";//Global variables
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {

            function = '/'; //Calling functions for action buttons
            first = userInput;
            userInput = "";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "0";
            label1.Text += userInput;//To output any number on the display form
        }

        private void num2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "2";
            label1.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "7";
            label1.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "9";
            label1.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "8";
            label1.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "4";
            label1.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "5";
            label1.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "6";
            label1.Text += userInput;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "1";
            label1.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            userInput += "3";//To output any number on the display form because user input variable is called
            label1.Text += userInput;
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {

            function = '*';
            first = userInput;
            userInput = "";
        }

        private void additionbutton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;  //Setting variables fnum and snum for any user input
            firstNum = result + Convert.ToInt32(first);
            secondNum = result + Convert.ToInt32(second);
            //Add
            if(function == '+')
            {
                result = firstNum + secondNum;
                label1.Text = result.ToString();
            }
            //Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                label1.Text = result.ToString();
            }
            //Divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    label1.Text = "Lol Really?";
                }
                else
                {
                    result = firstNum / secondNum;
                    label1.Text = result.ToString();
                }
            }
            //Subtract
            else if (function == '-')
            {
                result = firstNum - secondNum;
                label1.Text = result.ToString();
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
