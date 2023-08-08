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
    public partial class Inquires : Form
    {
        public Inquires()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendor_I vendor_I = new Vendor_I();
            vendor_I.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game_I game_I = new Game_I();
            game_I.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renter_I renter_I = new Renter_I();
            renter_I.Show();
            this.Hide();
        }
    }
}
