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
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Подключение БД и проверка,так же в 16 строке
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\курсач_2курс\test1\test1\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            if(sqlConnection.State == ConnectionState.Open)
            {
                //MessageBox.Show("Подключение установлено");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Users] (Name, Scanning, Price) VALUES (@Name, @Scanning, @Price)", sqlConnection);

                command.Parameters.AddWithValue("Name",textBox1.Text);
                command.Parameters.AddWithValue("Scanning", textBox2.Text);
                command.Parameters.AddWithValue("Price", textBox3.Text);

                command.ExecuteNonQuery();

                //MessageBox.Show(command.ExecuteNonQuery().ToString());
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

