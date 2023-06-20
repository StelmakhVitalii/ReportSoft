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
using System.Data.SqlClient;
namespace Solartec
{
    public partial class Register : Form
    {
        
       
        public Register()
        {
            InitializeComponent();
        }

        string Conn = "Data Source=DESKTOP-VITOSS;Initial Catalog=solartec;Integrated Security=True";
        string sqlQuery;
        SqlConnection cn;


        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)

        {
            sqlQuery = "SELECT login FROM[users] WHERE login=@login";
          
            cn = new SqlConnection(Conn);

            string login = textBox1.text;
            string pass = textBox2.text;
            string confirmPass = textBox3.text;



            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sqlQuery;

            cmd.Parameters.Add("@login", login);
            if (login.Length <= 3 || pass.Length <= 3)
            {
                MessageBox.Show("Поля занадто корткі");

                textBox2.text = "";
                textBox3.text = "";
            }
            else
            {

                var m = cmd.ExecuteScalar();
                if (m != null)
                {

                    MessageBox.Show("Такий користувач вже є");
                    textBox1.text = "";
                    textBox2.text = "";
                    textBox3.text = "";
                }
                else
                {
                    if (pass == confirmPass)
                    {
                        sqlQuery = "INSERT INTO [users] (login, pass, status) VALUES (@login, @pass, 0)";
                        cmd.CommandText = sqlQuery;
                    
                        cmd.Parameters.Add("@pass", pass);
                        int kl = cmd.ExecuteNonQuery();
                        MessageBox.Show("Упішно додано");
                        textBox1.text = "";
                        textBox2.text = "";
                        textBox3.text = "";
                    }
                    else
                    {
                        MessageBox.Show("Паролі не збігаються");

                        textBox2.text = "";
                        textBox3.text = "";
                    }

                }
            }


            cn.Close();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Autorize();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

      
    }
}
