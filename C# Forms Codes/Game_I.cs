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
    public partial class Game_I : Form
    {
        public Game_I()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inquires inquires = new Inquires();
            inquires.Show();
            this.Hide();
        }

        private void Inquires_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDataSet.GAME' table. You can move, or remove it, as needed.
            this.gAMETableAdapter.Fill(this.gameRentalDataSet.GAME);

            this.reportViewer1.RefreshReport();
        }
    }
}
