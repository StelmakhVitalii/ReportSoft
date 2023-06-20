using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Solartec
{
    public partial class Change_panel : Form
    {
        public Change_panel()
        {
            InitializeComponent();
        }


        


        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;





        string Conn = "Data Source=DESKTOP-VITOSS;Initial Catalog=solartec;Integrated Security=True";
        string sqlQuery;
        SqlConnection cn;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Change_panel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.solartecDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "solartecDataSet.subsystem". При необходимости она может быть перемещена или удалена.
            cn = new SqlConnection(Conn);
            cn.Open();
           







        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.solartecDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM " + comboBox2.SelectedItem.ToString(), Conn);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
