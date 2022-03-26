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
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerfomed))
                textBox_result.Clear();
                isOperationPerfomed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;
            }
            else
          
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
          

                Button button = (Button)sender;
              if (resultValue!=0)
            {
                button16.PerformClick();
                operationPerformed = button.Text;
                isOperationPerfomed = true;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            }
            else{
            operationPerformed = button.Text;
            resultValue = double.Parse(textBox_result.Text);
            isOperationPerfomed = true;
            labelCurrentOperation.Text = resultValue+ " "+operationPerformed;
        }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
         
        {

        }
    }
}
