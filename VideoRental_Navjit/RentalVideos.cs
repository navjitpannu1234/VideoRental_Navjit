using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_Navjit
{
    public partial class RentalVideos : Form
    {
        public RentalVideos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies movies = new Movies();
            movies.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental rental = new Rental();
            rental.ShowDialog();
        }

        private void RentalVideos_Load(object sender, EventArgs e)
        {

        }
    }
}
