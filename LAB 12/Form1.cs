using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        DataTable table;
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Ivanov", "Peter", 12);
            dataGridView1.Rows.Add("Abdylbaev", "Ruslan", 12);
            dataGridView1.Rows.Add("Ruslanova", "Zarina", 12);
            dataGridView1.Rows.Add("Igorov", "Peter", 12);
            dataGridView1.Rows.Add("Ivanov", "Sergey", 12);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending); // sort by the second column
            int viNomRow = 0;
            dataGridView1.Rows[viNomRow].DefaultCellStyle.BackColor = Color.White; // zeroing the color
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().Trim().ToLower().// Trim (). ToLower () - remove spaces and all data convert to lowercase letter whatever is in the grid as in the input field
                    Contains(toolStripTextBox1.Text.Trim().ToLower())) // Contains - comparison of texts from the grid cell and the entered value
                {

                    dataGridView1.CurrentCell = dataGridView1[1, i]; // getting the current value of the row if the cell and thevalue are equal
                    int enteredviNomRow = i;
                    dataGridView1.Rows[viNomRow].DefaultCellStyle.BackColor = Color.Aqua; // coloring the desired cell
                    return;
                }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            DataColumn c = table.Columns.Add("Ключ", typeof(String));
            c.AutoIncrement = true;
            c.AutoIncrementSeed = 10;
            c.AutoIncrementStep = 5;
            table.Columns.Add("Товар", typeof(String));
            table.Columns.Add("Количество", typeof(Int32));
            table.Columns.Add("Цена", typeof(Int32));
            table.Columns.Add("Сумма", typeof(String), "Количество * Цена");
            table.Columns.Add("Налоги", typeof(String), "Количество * Цена * 0.18");

            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            bindingSource.DataSource = table;
            dataGridView2.DataSource = bindingSource;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataRow row = table.NewRow();
            row[1] = "Молоко"; row["Количество"] = 10;
            row["Цена"] = 16;
            table.Rows.Add(row);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0) return;
            table.Rows[0].Delete();
        }
    }
}
