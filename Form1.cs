using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_2
{
    public partial class Form1 : Form
    {
        DataTable datatable = new DataTable();
        int counth = 1;
        public Form1()
        {
            InitializeComponent();
            
            DataColumn column1 = new DataColumn();
            DataColumn column2 = new DataColumn();
            DataColumn column3 = new DataColumn();
            DataColumn column4 = new DataColumn();

            column1.ColumnName = "วันที่";
            column2.ColumnName = "รายรับ";
            column3.ColumnName = "รายจ่าย";
            column4.ColumnName = "คงเหลือ";

            datatable.Columns.Add(column1);
            datatable.Columns.Add(column2);
            datatable.Columns.Add(column3);
            datatable.Columns.Add(column4);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String month = dateTimePicker1.Text;

                double revenue = double.Parse(textBox1.Text);
                double expense = double.Parse(textBox2.Text);
                double sum = revenue - expense;
                textBox3.Text = "";
                
               
                {
                    DataRow newRow = datatable.NewRow();
                    newRow["วันที่"] = month;
                    newRow["รายรับ"] = revenue;
                    newRow["รายจ่าย"] = expense;
                    newRow["คงเหลือ"] = sum;

                    datatable.Rows.Add(newRow);
                }
               
                this.dataGridView1.DataSource = datatable;
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox3.Clear();
                counth++;
            }
            catch (Exception y) { MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง"); }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)

        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    textBox3.Text = "";
                }
                else
                {
                    double r = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double sum = r - b;
                    textBox3.Text = sum.ToString();

                }

            }
            catch (Exception y) { MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง"); }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*for (int i = 0; i < datatable.Rows.Count; i++)
               {
                   if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "รวม")
                   {
                       dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                   }
               }*/
        }
    }
}
