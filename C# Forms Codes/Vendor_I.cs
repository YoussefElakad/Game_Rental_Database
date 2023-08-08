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
    public partial class Vendor_I : Form
    {
        public Vendor_I()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inquires inquires = new Inquires();
            inquires.Show();
            this.Hide();
        }

        private void Vendor_I_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameRentalDataSet.VENDOR' table. You can move, or remove it, as needed.
            this.vENDORTableAdapter.Fill(this.gameRentalDataSet.VENDOR);

            this.reportViewer1.RefreshReport();
        }
    }
}
