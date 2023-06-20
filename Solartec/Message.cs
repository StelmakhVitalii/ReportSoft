using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.IO;

namespace Solartec
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }
        string picPath;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picPath = dlg.FileName.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Catalog_admin();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string to = bunifuTextbox1.text;

            string subj = bunifuTextbox2.text;

            string msj = richTextBox1.Text;

            string mail = textBox1.text;

            string pass = textBox2.text;

            Send(to, subj, msj, mail, pass);
        }


        public void Send(string to, string subject, string msj, string yourMail, string pass)
        {


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";

            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(yourMail, pass);

            using (var message = new MailMessage(yourMail, to))
            {
                try
                {
                    message.Subject = subject;
                    message.Body = msj;
                    message.Attachments.Add(new Attachment(picPath));
                    message.IsBodyHtml = true;
                    smtp.Send(message);

                    MessageBox.Show("Ok");

                }
                catch (Exception ext)
                {
                    MessageBox.Show("Didnt sent !!!!", ext.ToString());
                   // richTextBox1.Text = ext.ToString();
                }
            }
        }

        private void Message_Load(object sender, EventArgs e)
        {
            textBox2._TextBox.PasswordChar = Convert.ToChar("*");
        }
    }
}
