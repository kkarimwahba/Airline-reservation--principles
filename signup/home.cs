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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            string userName = userSession.name;
        }

        private void home_Load(object sender, EventArgs e)
        {
            if (!userSession.IsLoggedIn)
            {
                // If not logged in, redirect back to the login form
                logform loginForm = new logform();
                loginForm.Show();
                this.Close();
            }
            else
            {
            
            }
        }
        private void Flights_button_Click(object sender, EventArgs e)
        {
            Reservationform reservation = new Reservationform();
            reservation.Show();
            this.Close();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            //clear the sessions.
            userSession.name = null;
            userSession.email = null;
            userSession.password = null;
            userSession.passport_number = null;
            userSession.IsLoggedIn = false;

            // Show the login form
            logform loginForm = new logform();
            loginForm.Show();
            this.Close();
        }

    }
}
