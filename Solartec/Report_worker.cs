using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Solartec
{


    public partial class Report_worker : Form
    {

        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        BindingSource bs;

        public Report_worker()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e) {
          
            adapter = new SqlDataAdapter("SELECT id_rep, date,stantion, work, time_of_work FROM reg WHERE [user] = '" + comboBox2.Text + "' AND date >= '" + Convert.ToDateTime(dateTimePicker1.Value) + "' and date <= '" + Convert.ToDateTime(dateTimePicker2.Value) + "'", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView4.DataSource = table;



            adapter = new SqlDataAdapter("SELECT id_rep, date,stantion, work_type, category,work, system, subsystem, disp_name, time_of_work FROM reg WHERE [user] = '" + comboBox2.Text + "' AND date >= '" + Convert.ToDateTime(dateTimePicker1.Value) + "' and date <= '" + Convert.ToDateTime(dateTimePicker2.Value) + "' and work_type ='" +label1.Text + "'", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


            adapter = new SqlDataAdapter("SELECT id_rep, date,stantion, work_type, category,work, system, subsystem, disp_name, time_of_work FROM reg WHERE [user] = '" + comboBox2.Text + "' AND date >= '" + Convert.ToDateTime(dateTimePicker1.Value) + "' and date <= '" + Convert.ToDateTime(dateTimePicker2.Value) + "' and work_type ='" + label2.Text + "'", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;


            adapter = new SqlDataAdapter("SELECT id_rep, date,stantion, work_type, category,work, system, subsystem, disp_name, time_of_work FROM reg WHERE [user] = '" + comboBox2.Text + "' AND date >= '" + Convert.ToDateTime(dateTimePicker1.Value) + "' and date <= '" + Convert.ToDateTime(dateTimePicker2.Value) + "' and work_type ='" + label3.Text + "'", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
            button3.Enabled = true;

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.solartecDataSet.users);
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-VITOSS;Initial Catalog=solartec;Integrated Security=True");
            sqlConnection.Open();
        }

        private void Button2_Click(object sender, EventArgs e) { }

        private void Button3_Click(object sender, EventArgs e) {
            string fileName1 = "C:\\Kursova\\Solartec\\bin\\Debug\\Шаблони\\Звіт по працівнику.xlsx"; //имя Excel файла 
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWb = xlApp.Workbooks.Open(fileName1); //открываем Excel файл
            Excel.Worksheet xlSht = xlWb.Sheets[1];
            Excel.Worksheet xlSht2 = xlWb.Sheets[2];
            Excel.Worksheet xlSht3 = xlWb.Sheets[3];
            Excel.Worksheet xlSht4 = xlWb.Sheets[4];

             for (int i = 0; i < dataGridView1.Rows.Count; i++)
             {
                 for (int j = 0; j < dataGridView1.Columns.Count; j++)
                 {

                     if (dataGridView1.Rows[i].Cells[j].Value != null)
                     {
                         xlSht.Cells[i + 5, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                     }
                     else
                     {
                         xlSht.Cells[i + 5, j + 1] = "";
                     }
                     xlSht.Columns.EntireColumn.AutoFit();
                 }
             }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {

                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        xlSht2.Cells[i + 5, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        xlSht2.Cells[i + 5, j + 1] = "";
                    }
                    xlSht2.Columns.EntireColumn.AutoFit();
                }
            }

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {

                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                    {
                  
                    }
                    else
                    {
                        xlSht3.Cells[i + 5, j + 1] = "";
                    }
                    xlSht3.Columns.EntireColumn.AutoFit();
                }
            }

            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView4.Columns.Count; j++)
                {

                    if (dataGridView4.Rows[i].Cells[j].Value != null)
                    {
                        xlSht4.Cells[i + 5, j + 1] = dataGridView4.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        xlSht4.Cells[i + 5, j + 1] = "";
                    }
                    xlSht4.Columns.EntireColumn.AutoFit();
                }
            }

            xlSht4.Cells[3, 2] = "Звіт по працівнику з " + dateTimePicker1.Text + " по " + dateTimePicker2.Text + " " + " " + comboBox2.Text;
            int kilk = 1;
            for (int i = 1; i < dataGridView4.Rows.Count; i++)
            {

                if (Convert.ToString(dataGridView4.Rows[i].Cells[1].Value) != Convert.ToString(dataGridView4.Rows[i - 1].Cells[1].Value))
                { kilk++; }
            }
            xlSht4.Cells[7, 9] = kilk;
            xlWb.SaveAs("C:\\Kursova\\Solartec\\bin\\Debug\\Звіт по працівнику з " + dateTimePicker1.Text + " по " + dateTimePicker2.Text + " " + " " + comboBox2.Text + ".xlsx");
            xlWb.Close(false);
            xlApp.Quit();
            button4.Enabled = true;
        }// Кнопка "Сформувати звіт"

        private void Button4_Click(object sender, EventArgs e) {

           
   
      
            string path = "C:\\Kursova\\Solartec\\bin\\Debug\\Звіт по працівнику з " + dateTimePicker1.Text + " по " + dateTimePicker2.Text + " " + " " + comboBox2.Text + ".xlsx";

            Process.Start(path);
            comboBox2.Text = " ";
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }// Кнопка "Відкрити звіт"

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Catalog_admin();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
            return;
        }// Кнопка "На головну"

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) { button1.Enabled = true; }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
       
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
}
}
