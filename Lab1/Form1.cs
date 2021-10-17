using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    //Execise #1
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void show_result(object sender, EventArgs e)
        {
            String sign = operationSign.Text;
            if (sign.Length == 1)
            {
                if (sign.Equals("*"))
                {
                    int result = Convert.ToInt32(firstNumber.Text) * Convert.ToInt32(secondNumber.Text);
                    resultTextBox.Text = result.ToString();
                }
                else if (sign.Equals("-"))
                {
                    int result = Convert.ToInt32(firstNumber.Text) - Convert.ToInt32(secondNumber.Text);
                    resultTextBox.Text = result.ToString();
                }
                else if (sign.Equals("/"))
                {
                    int result = Convert.ToInt32(firstNumber.Text) / Convert.ToInt32(secondNumber.Text);
                    resultTextBox.Text = result.ToString();
                }
                else
                {
                    int result = Convert.ToInt32(firstNumber.Text) + Convert.ToInt32(secondNumber.Text);
                    resultTextBox.Text = result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Enter valid sign for performing operation!!!");
            }
        }
    }
}
