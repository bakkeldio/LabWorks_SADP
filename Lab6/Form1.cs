using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_value_btn(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToString());
            textBox1.Clear();
        }

        private void remove_value_btn(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void clear_btn(object sender, EventArgs e)
        {
            string message = "Do you really want to delete all list?";
            string caption = "Deleting the list";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
