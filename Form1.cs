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
       
        public Form1()
        {
            InitializeComponent();
            
            DataColumn column1 = new DataColumn();//เพิ่มcolumnที่1
            DataColumn column2 = new DataColumn();//เพิ่มcolumnที่2
            DataColumn column3 = new DataColumn();//เพิ่มcolumnที่3
            DataColumn column4 = new DataColumn();//เพิ่มcolumnที่4

            column1.ColumnName = "วันที่";//column1 ชื่อเป็นวันที่
            column2.ColumnName = "รายรับ";//column2 ชื่อรายรับ
            column3.ColumnName = "รายจ่าย";//column3 ชื่อรายจ่าย
            column4.ColumnName = "คงเหลือ";// column4 ชื่อคงเหลือ

            datatable.Columns.Add(column1);//add column1 เพื่อลองรับข้อมูลค่าต่อไป
            datatable.Columns.Add(column2);//add column2 เพื่อลองรับข้อมูลค่าต่อไป
            datatable.Columns.Add(column3);//add column3 เพื่อลองรับข้อมูลค่าต่อไป
            datatable.Columns.Add(column4);//add column4 เพื่อลองรับข้อมูลค่าต่อไป
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                String month = dateTimePicker1.Text;//dateTimePicker1.Text มาเก็บไว้ใน month

                double revenue = double.Parse(textBox1.Text);//รับค่าจากtextBox1มาแปลงค่าแล้วเก็บไว้ใน revenue
                double expense = double.Parse(textBox2.Text);//รับค่าจากtextBox2มาแปลงค่าแล้วเก็บไว้ใน expense
                double sum = revenue - expense;//เอาค่า revenue - expense แล้วมาเก็บไว้ใน sum
                textBox3.Text = sum.ToString();//ให้แสดงค่าsumใน textBox3
                
               
                {
                    DataRow newRow = datatable.NewRow();//คลาส DataRow 
                    newRow["วันที่"] = month;//จะแสดงค่าmonth ในช่องวันที่
                    newRow["รายรับ"] = revenue;//จะแสดงค่าrevenueในช่องรายรับ
                    newRow["รายจ่าย"] = expense;//จะแสดงค่าexpenseในช่องรายจ่าย
                    newRow["คงเหลือ"] = sum;//จะแสดงค่า sum ในช่องคงเหลือ

                    datatable.Rows.Add(newRow);//จะAdd ค่า newRow ลงใน datatable
                }
               
                this.dataGridView1.DataSource = datatable;//จะแสดงค่าdatatableลงในเครื่องมือdataGridView
                this.textBox1.Clear();//เคลียร์textBox1ให้ว่างเพื่อรับค่าต่อไป
                this.textBox2.Clear();//เคลียร์textBox2ให้ว่างเพื่อรับค่าต่อไป
                this.textBox3.Clear();//เคลียร์textBox3ให้ว่างเพื่อรับค่าต่อไป
               
            catch (Exception y) { MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง"); }//ถ้าไม่ทำตามเงื่อนไขของTry ให้เข้ามาทำใน cath เพื่อโชว์MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง")

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
                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))//ถ้าtextBox1 textBox2 ว่าง
                {
                    textBox3.Text = "";//textBox3 ก็จะว่าง
                }
                else
                {
                    double r = double.Parse(textBox1.Text);//รับค่าtextBox1 แล้วมาแปลงค่าเก็บไว้ใน r
                    double b = double.Parse(textBox2.Text);//รับค่าtextBox2แล้วมาแปลงค่าเก็บไว้ใน b
                    double sum = r - b;//r - b แล้วเก็บไว้ในsum
                    textBox3.Text = sum.ToString();//แสดงค่าsum ใน textBox3

                }

            }
            catch (Exception y) { MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง"); }///ถ้าไม่ทำตามเงื่อนไขของTry ให้เข้ามาทำใน cath เพื่อโชว์MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง")


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
