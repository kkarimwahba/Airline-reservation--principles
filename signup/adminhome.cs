using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signup
{
    public partial class adminhome : Form
    {
        public adminhome()
        {
            InitializeComponent();
        }

        private void addFlights_btn_Click(object sender, EventArgs e)
        {
            addf addflights = new addf();
            this.Hide();
            addflights.Show();
        }

        private void viewReser_btn_Click(object sender, EventArgs e)
        {
            Reservations addflights = new Reservations();
            this.Hide();
            addflights.Show();
        }

       
    }
}
