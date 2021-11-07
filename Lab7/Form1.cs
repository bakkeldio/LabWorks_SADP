﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //method 3
            string[] items = new string[] { "Excellent", "Good", "Satisfactory", "Unsatisfactory" };
            comboBox1.DataSource = items;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove("First row");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox2.Items.RemoveAt(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //method 2
            comboBox1.Items.Clear();
            string[] items = { "Excellent", "Good", "Satisfactory", "Unsatisfactory" };
            for (int i = 0; i<items.Length; i++)
            {
                comboBox1.Items.Add(items[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clearing the list
            comboBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Getting the selected item
            if (comboBox2.SelectedIndex != 1)
            {
                MessageBox.Show(comboBox2.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("You did not select a value", "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
                MessageBox.Show(comboBox2.SelectedIndex.ToString());
            else
                MessageBox.Show("You did not select a value", "Error");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
            for (int i = 13; i> 0; i--)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Happend click event", "You clicked on the component with the mouse");

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The selectedIndexChanged event has occured", "You clicked the component with the mouse");
            if (comboBox4.SelectedIndex != 1)
            {
                MessageBox.Show("You have selected a value" + comboBox4.SelectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("You did not select a value", "Error");
            }
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The TextChanged event has occurred", "You clicked the component with the mouse");
            if (comboBox5.SelectedIndex != -1)
                MessageBox.Show("You have selected a value" + comboBox5.SelectedText);
            else
                MessageBox.Show("You did not select a value", "Error");

        }
    }
}