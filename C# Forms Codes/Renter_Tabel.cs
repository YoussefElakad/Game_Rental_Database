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
    public partial class Renter_Tabel : Form
    {
        public Renter_Tabel()
        {
            InitializeComponent();
        }

        private void Renter_Tabel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rENTERTableAdapter.Fill(this.gameRentalDataSet.RENTER);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFB69IO\SQL2019;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlConnection.Open();

            sqlCommand.CommandText = "Delete from RENTER where RENTER_ID = " + textBox1.Text + "";
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
