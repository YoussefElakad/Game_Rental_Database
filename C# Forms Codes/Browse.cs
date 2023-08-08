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
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void Browse_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gAMETableAdapter.Fill(this.gameRentalDataSet.GAME);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Update GAME Set NO_RENTED = NO_RENTED+1 Where GAME_ID = " + textBox1.Text + "";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "Update RENTER Set NO_RENTED = NO_RENTED+1 Where RENTER_ID = " + textBox2.Text + "";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "Update VENDOR Set NO_RENTED = NO_RENTED+1 where VENDOR_ID = "+textBox3.Text+"";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "Update GAME Set TOTAL_INCOME = NO_RENTED*PRICE Where GAME_ID = " + textBox1.Text + "";
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Enjoy Your new Game!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Renter renter = new Renter();
            renter.Show();
            this.Hide();
        }
    }
}
