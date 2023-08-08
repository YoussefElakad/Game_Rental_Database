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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Insert Into RENTER Values(" + textBox1.Text + ",'" + textBox3.Text + "','" + textBox9.Text + "','" + textBox2.Text + "',0)";

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Sign Up succesful");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Update RENTER Set NAME = '" + textBox2.Text + "', EMAIL = '" + textBox3.Text + "', PASSWORD = '" + textBox9.Text + "' Where RENTER_ID = " + textBox1.Text + "";

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Update succesful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renter renter = new Renter();
            renter.Show();
            this.Hide();
        }
    }
}
