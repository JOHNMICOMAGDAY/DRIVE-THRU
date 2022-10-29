//Title: Drive Thru
//Description: We have used queueing on our system. We followed the primary function of it as we stored data in a proper queueing manner, inserting customers first-in and deleting customer's data first-out.Though, we didn't apply the code on our system, but still, our system operates like it has one.
//Programmers:
//1. John Mico Magday
//2. Paulo Padre
//3. Prince Shane Frances
//Date Submitted: October 29 2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMGROUP
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");

        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("DESCRIPTION", Type.GetType("System.String"));
            table.Columns.Add("TITLE", Type.GetType("System.String"));

            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            TXT1.Text = row.Cells[0].Value.ToString();
            TXT2.Text = row.Cells[1].Value.ToString();
            TXT3.Text = row.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TXT1.Text, TXT2.Text, TXT3.Text);
            MessageBox.Show("ADDED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            MessageBox.Show("Item Remove");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = TXT1.Text;
            newData.Cells[1].Value = TXT2.Text;
            newData.Cells[2].Value = TXT3.Text;
            MessageBox.Show("Successfully Updated");



        }
    }
}
