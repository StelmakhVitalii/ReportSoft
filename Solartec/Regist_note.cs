using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Solartec
{
    public partial class Regist_note : Form
    {


        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
       


        public Regist_note()
        {
            InitializeComponent();
        }

        string Conn = "Data Source=DESKTOP-VITOSS;Initial Catalog=solartec;Integrated Security=True";
        string sqlQuery;
        SqlConnection cn;
        string userid;
        SqlCommand cmd;
        private void Button1_Click(object sender, EventArgs e) {


            cn = new SqlConnection(Conn);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sqlQuery;

            //     sqlQuery = "INSERT INTO regist_note (date, stantion, work_type, category, [work], note, system, subsystem, disp_name, name_obl,inv_numb, [user])" + "VALUES ('" + dateTimePicker1.Value + "', '"
            //     + comboBox1.SelectedValue +
            //     "', '" + comboBox2.SelectedValue.ToString() +
            //     "', '" + comboBox3.SelectedValue.ToString() +
            //     "', '" + comboBox4.SelectedValue.ToString() +
            //     "', '" + textBox1.Text +
            //     "', '" + comboBox5.SelectedValue.ToString() +
            //     "', '" + comboBox6.SelectedValue.ToString() +
            //     "', '" + textBox2.Text +
            //     "', '" + textBox3.Text +
            //     "', '" + textBox4.Text +
            //     "', '" + label14.Text + "')";

            if ((Convert.ToDateTime(textBox6.Text) - Convert.ToDateTime(textBox5.Text)).TotalMilliseconds < 0)
            {
                MessageBox.Show("Перевірте правильність введення даних");
            }
            else
            {

                sqlQuery = "INSERT INTO reg (date, stantion, work_type, category, [work], note, system, subsystem, disp_name, name_obl,inv_numb, [user], time_of_work, photo)" + "VALUES ('" + dateTimePicker1.Value + "', '"
     + comboBox1.Text +
     "', '" + comboBox2.Text.ToString() +
     "', '" + comboBox3.Text.ToString() +
     "', '" + comboBox4.Text.ToString() +
     "', '" + textBox1.Text +
     "', '" + comboBox5.Text.ToString() +
     "', '" + comboBox6.Text.ToString() +
     "', '" + textBox2.Text +
     "', '" + textBox3.Text +
     "', '" + textBox4.Text +
     "', '" + label14.Text +
     "', '" + (Convert.ToDateTime(textBox6.Text) - Convert.ToDateTime(textBox5.Text)) +
     "', '" + pictureBox1.Image + "')";


               

                cmd.CommandText = sqlQuery;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Упішно додано");
                cn.Close();


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                comboBox6.Text = "";
                pictureBox1.Image = null;
            }
        }
        
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            comboBox4.Enabled = true;
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) {



           
            comboBox3.Enabled = true;

            /*MessageBox.Show(comboBox1.SelectedValue.ToString());*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.subsystem". При необходимости она может быть перемещена или удалена.
            this.subsystemTableAdapter.Fill(this.solartecDataSet.subsystem);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.system". При необходимости она может быть перемещена или удалена.
            this.systemTableAdapter.Fill(this.solartecDataSet.system);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.work". При необходимости она может быть перемещена или удалена.
            this.workTableAdapter.Fill(this.solartecDataSet.work);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.solartecDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.work_type". При необходимости она может быть перемещена или удалена.
            this.work_typeTableAdapter.Fill(this.solartecDataSet.work_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.stantion". При необходимости она может быть перемещена или удалена.
            this.stantionTableAdapter.Fill(this.solartecDataSet.stantion);


            sqlQuery = "";
       
            cn = new SqlConnection(Conn);
            cn.Open();
            label14.Text = userid;
            string idid = "";
            idid = label14.Text;
            label14.Text=idid;


            cmd = cn.CreateCommand();
            sqlQuery = "SELECT login From [users] WHERE id=@userid";
            cmd.Parameters.Add("@userid", idid);
            cmd.CommandText = sqlQuery;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    label14.Text = reader["login"].ToString();
                }
            }

            dateTimePicker1.Value = DateTime.Now;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Text = "";
            textBox2.Text = "";
            textBox3.Enabled = false;
            textBox4.Text = "";
            textBox4.Enabled = false;
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox5.Enabled = true;
        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Enabled = true;
            textBox3.Text = "";
            textBox3.Enabled = true;
            textBox4.Text = "";
            textBox4.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e) { }

        private void Button3_Click(object sender, EventArgs e) {


            this.Hide();
            var form1 = new Autorize();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            return;

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = image;

                    MessageBox.Show("Зображення завантажено");
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e) { }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox3.Text = "";
            textBox3.Enabled = false;
            textBox4.Text = "";
            textBox4.Enabled = false;
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox3.Enabled = false;
            comboBox4.Text = "";
            comboBox4.Enabled = false;
            comboBox5.Text = "";
            comboBox5.Enabled = false;
            comboBox6.Text = "";
            comboBox6.Enabled = false;

            if (comboBox1.Text != "") comboBox2.Enabled = true;

        }

        private void Label1_Click(object sender, EventArgs e) { }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e) { comboBox6.Enabled = true; }
        private void TextBox1_TextChanged(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal void LoadOrders(string id)
        {
           userid=id;
        }

    }
}
