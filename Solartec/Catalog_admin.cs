using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Solartec
{
    public partial class Catalog_admin : Form
    {
        public Catalog_admin()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form6 = new Regist_note();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form1 = new Autorize();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            return;

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Report_stantion();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form7 = new Report_worker();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form8 = new Message();
            form8.Closed += (s, args) => this.Close();
            form8.Show();
        }
    }
}
