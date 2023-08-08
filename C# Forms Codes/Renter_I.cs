using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRental
{
    public partial class Renter_I : Form
    {
        public Renter_I()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inquires inquires = new Inquires();
            inquires.Show();
            this.Hide();
        }

        private void Renter_I_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDataSet.RENTER' table. You can move, or remove it, as needed.
            this.rENTERTableAdapter.Fill(this.gameRentalDataSet.RENTER);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
