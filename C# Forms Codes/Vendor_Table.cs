using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRental
{
    public partial class Vendor_Table : Form
    {
        public Vendor_Table()
        {
            InitializeComponent();
        }

        private void Vendor_Table_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vENDORTableAdapter.Fill(this.gameRentalDataSet.VENDOR);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Insert Into VENDOR Values(" + textBox1.Text + ",'" + textBox2.Text + "',0)";

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("insertion succesful");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Delete from VENDOR";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Vendor Table succesfully emptied");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Delete from VENDOR where VENDOR_ID = " + textBox1.Text + "";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Row succesfully deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
