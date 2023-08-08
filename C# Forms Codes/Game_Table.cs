using GameRental;
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

namespace Game_Rental
{
    public partial class Game_Table : Form
    {
        public Game_Table()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Insert Into GAME Values(" + textBox1.Text + "," + textBox2.Text + ",'" + textBox3.Text + "'," + textBox9.Text + ",0,0)";

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("insertion succesful");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gAMETableAdapter.Fill(this.gameRentalDataSet.GAME);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Delete from GAME";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Game Table succesfully emptied");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Update GAME Set VENDOR_ID = " + textBox2.Text + ", PRICE = " + textBox9.Text + ", NAME = '"+textBox3.Text+"' Where GAME_ID = " + textBox1.Text + "";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Update succesful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Delete from GAME where GAME_ID = "+textBox1.Text+"";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Row succesfully deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}