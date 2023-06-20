using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Bunifu.Framework.UI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Solartec
{
    public partial class Autorize : Form
    {
    

        public Autorize()
        {
          
            InitializeComponent();
        }

        string sqlQuery;
       
        SqlConnection cn;
        string Conn = "Data Source=DESKTOP-VITOSS;Initial Catalog=solartec;Integrated Security=True";
        private void Button1_Click(object sender, EventArgs e)
        {

 
            sqlQuery = "";
            cn = new SqlConnection(Conn);


            string login = textBox1.text;
            string pass = textBox2.text;
            bool status = false;

            cn.Open();
            SqlCommand cmd1 = cn.CreateCommand();
            sqlQuery = "SELECT id FROM [users] WHERE login=@login AND pass=@pass";
            cmd1.CommandText = sqlQuery;
            cmd1.Parameters.Add("@login", login);
            cmd1.Parameters.Add("@pass", pass);


           


            SqlCommand cmd2 = cn.CreateCommand();
            sqlQuery = "SELECT status FROM [users] WHERE login=@login AND pass=@pass";
            cmd2.CommandText = sqlQuery;
            cmd2.Parameters.Add("@login", login);
            cmd2.Parameters.Add("@pass", pass);

           
        
            string id = Convert.ToString(cmd1.ExecuteScalar());
            status = Convert.ToBoolean(cmd2.ExecuteScalar());
            try
            {
                
                if (Convert.ToInt32(id) >= 0)
                {
                    if (status == true)
                    {
                        this.Hide();
                        var formAdmin = new Catalog_admin();
                       // formAdmin.LoadOrders(id);
                        formAdmin.Show();

                    }
                    else
                    {
                        this.Hide();
                        var form = new Regist_note();
                        form.LoadOrders(id);
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                }
                else MessageBox.Show("Не вірний логін або пароль");
            }
            catch
            {
                MessageBox.Show("Не вірний логін або пароль");
            }

            cn.Close();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2._TextBox.PasswordChar = Convert.ToChar("*");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Register();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
