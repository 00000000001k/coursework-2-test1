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

namespace test1
{
    public partial class Form3 : Form
    {
        SqlConnection sqlConnection = null;
        //private object dataGridView1;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\курсач_2курс\test1\test1\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                //MessageBox.Show("Подключение установлено");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        
    }
}
