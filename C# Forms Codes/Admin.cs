using Game_Rental;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_Table form1 = new Game_Table();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendor_Table vendor_Table = new Vendor_Table();
            vendor_Table.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Renter_Tabel renter_Tabel = new Renter_Tabel();
            renter_Tabel.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inquires inquires = new Inquires();
            inquires.Show();
            this.Hide();
        }
    }
}
