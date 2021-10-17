using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double result = (a + b) / c;
            textBox4.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.1);
            }
            if (radioButton2.Checked == true)
            {
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.2);
            }
            if (radioButton3.Checked == true)
            {
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.5);
            }
        }
    }
}
