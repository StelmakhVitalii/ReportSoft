using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using Microsoft.Office.Tools.Excel;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Solartec
{
    public partial class Report_stantion : Form
    {

        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private SqlDataAdapter adapter1= null;
        private DataTable table = null;
        BindingSource bs;

        public Report_stantion()
        {
            InitializeComponent();
        } 
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.work_type". При необходимости она может быть перемещена или удалена.
            this.work_typeTableAdapter.Fill(this.solartecDataSet.work_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.stantion". При необходимости она может быть перемещена или удалена.
            this.stantionTableAdapter.Fill(this.solartecDataSet.stantion);
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-VITOSS;Initial Catalog=solartec;Integrated Security=True");
            sqlConnection.Open();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string gosp = "1. Територія ФЕС та будівлі";
            adapter = new SqlDataAdapter("SELECT [work] , count([user]) as 'user',  sum(((DATEPART(hour, [time_of_work]) * 3600) + (DATEPART(minute, [time_of_work]) * 60) + DATEPART(second, [time_of_work]))) / 60  FROM reg WHERE stantion = '" + comboBox1.Text + "'AND work_type = '" + comboBox2.Text + "'AND category !='" + gosp + "' AND date >= '"+ Convert.ToDateTime(dateTimePicker1.Value) + "' and date <= '" + Convert.ToDateTime(dateTimePicker2.Value)+ "' group by  [work]", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;


            adapter = new SqlDataAdapter("SELECT [work] , count([user]) as 'user',  sum(((DATEPART(hour, [time_of_work]) * 3600) + (DATEPART(minute, [time_of_work]) * 60) + DATEPART(second, [time_of_work]))) / 60  FROM reg WHERE stantion = '" + comboBox1.Text + "'AND work_type = '" + comboBox2.Text + "'AND category ='" + gosp + "' AND date >= '" + Convert.ToDateTime(dateTimePicker1.Value) + "' and date <= '" + Convert.ToDateTime(dateTimePicker2.Value) + "'group by  [work]", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            button7.Visible = true;
            button7.Enabled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string pf5b7 = @"C:\Kursova\Solartec\bin\Debug\Шаблони\";
            string pb7 = "";
            string fileName1 = "";
            int zsuv = 1;
          
            if ((comboBox2.Text == "Планові роботи") && comboBox1.Text == "Р1-Солар_ІФ")
                pb7 = "STC_P1.xlsx";

            else if ((comboBox2.Text == "Планові роботи") && comboBox1.Text == "Р2-Геліос_Енерджі")
                pb7 = "STC_P2.xlsx";

            else if ((comboBox2.Text == "Планові роботи") && comboBox1.Text == "Р3-Геліос_ІФ")
                pb7 = "STC_P3.xlsx";

            else if ((comboBox2.Text == "Планові роботи") && comboBox1.Text == "Р4-Фото_Енерджі")
                pb7 = "STC_P4.xlsx";

            else if ((comboBox2.Text == "Планові роботи") && comboBox1.Text == "Р5-Солар_Енерджі")
                pb7 = "STC_P5.xlsx";




            else if ((comboBox2.Text == "Додаткові роботи" || comboBox2.Text == "Несправності") && (comboBox1.Text == "Р1-Солар_ІФ"))
                pb7 = "Р1.xlsx";

            else if ((comboBox2.Text == "Додаткові роботи" || comboBox2.Text == "Несправності") && (comboBox1.Text == "Р2-Геліос_Енерджі"))
                pb7 = "Р2.xlsx";

            else if ((comboBox2.Text == "Додаткові роботи" || comboBox2.Text == "Несправності") && (comboBox1.Text == "Р3-Геліос_ІФ"))
                pb7 = "Р3.xlsx";

            else if ((comboBox2.Text == "Додаткові роботи" || comboBox2.Text == "Несправності") && (comboBox1.Text == "Р4-Фото_Енерджі"))
                pb7 = "Р4.xlsx";

            else if ((comboBox2.Text == "Додаткові роботи" || comboBox2.Text == "Несправності") && (comboBox1.Text == "Р5-Солар_Енерджі"))
                pb7 = "Р5.xlsx";




          

            fileName1 = pf5b7 + pb7;

         

            if (comboBox2.Text == "Планові роботи")
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWb = xlApp.Workbooks.Open(fileName1);
                Excel.Worksheet xlSht = xlWb.Sheets[1];
                    Excel.Range line = (Excel.Range)xlSht.Rows[6];
                for (int a = 1; a < dataGridView2.RowCount + 1; a++)
                {

                    line.Insert();
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[6, 2], xlApp.Sheets[1].Cells[a + 6, 5]].Cells.HorizontalAlignment =
                       Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[6, 1], xlApp.Sheets[1].Cells[a + 6, 5]].Cells.Font.Underline = false;
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[6, 1], xlApp.Sheets[1].Cells[a + 6, 1]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[6, 1], xlApp.Sheets[1].Cells[a + 6, 8]].Cells.Font.Italic = false;
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[6, 1], xlApp.Sheets[1].Cells[a + 6 - 1, 8]].Cells.Font.Bold = false;

                }


                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {

                            xlSht.Cells[i + 4+2, j + 1 + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                            xlSht.Rows.EntireRow.AutoFit();
                        }

                    }
                }



                xlWb.SaveAs("C:\\Kursova\\Solartec\\bin\\Debug\\" + dateTimePicker1.Text + " " + dateTimePicker2.Text + " " + comboBox1.Text + " " + comboBox2.Text + ".xlsx");
                xlWb.Close(false);
                xlApp.Quit();

            }

            else if (comboBox2.Text == "Додаткові роботи" || comboBox2.Text == "Несправності")

            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWb = xlApp.Workbooks.Open(fileName1);
                Excel.Worksheet xlSht = xlWb.Sheets[1];



                xlSht.Cells[3, 7] = dateTimePicker2.Text;
                xlSht.Cells[8, 2] = "В період з " + dateTimePicker1.Text + " р. по " + dateTimePicker2.Text + " р. Підрядник виконав та передав наступні роботи: ";
                for (int a = 1; a < dataGridView2.RowCount + 1; a++)
                {
                    Excel.Range line = (Excel.Range)xlSht.Rows[10];
                    line.Insert();
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[3, 7], xlApp.Sheets[1].Cells[3, 7]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    xlApp.Sheets[1].Range[xlApp.Sheets[1].Cells[10, 2], xlApp.Sheets[1].Cells[a + 10, 2]].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                }


                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {

                            xlSht.Cells[i + 10, j + 1+1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                            xlSht.Rows.EntireRow.AutoFit();
                        }

                    }
                }

                xlSht.Rows[dataGridView2.RowCount + 16].RowHeight = 35;
                xlSht.Rows[4].RowHeight = 45;
                xlSht.Rows[6].RowHeight = 45;
                xlSht.Rows[7].RowHeight = 45;
                xlWb.SaveAs("C:\\Kursova\\Solartec\\bin\\Debug\\" + dateTimePicker1.Text + " " + dateTimePicker2.Text + " " + comboBox1.Text + " " + comboBox2.Text + ".xlsx");
                xlWb.Close(false);
                xlApp.Quit();

            }


            button10.Visible = true;
            button10.Enabled = true;
        }

        private void Button8_Click(object sender, EventArgs e) { 
        
        }

        private void Button9_Click(object sender, EventArgs e) { 
        }

        private void Button10_Click(object sender, EventArgs e) 
        {
            string path = "C:\\Kursova\\Solartec\\bin\\Debug\\" + dateTimePicker1.Text + " " + dateTimePicker2.Text + " " + comboBox1.Text + " " + comboBox2.Text + ".xlsx";

            Process.Start(path);

        }

        private void Button11_Click(object sender, EventArgs e) 
        {
            this.Hide();
            var form4 = new Catalog_admin();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
       
            return;
        }

       
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button7.Visible = false;
            button10.Visible = false;
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

