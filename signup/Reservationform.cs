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

namespace signup
{
    public partial class Reservationform : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Reservationform()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (flyingftxt.Text != String.Empty || flyingttxt.Text != String.Empty || departingdate.Text != String.Empty || returningdate.Text != String.Empty || adultslist.Text != String.Empty || childrenlist.Text != String.Empty || classlist.Text != String.Empty)
            {
                if (flyingftxt.Text != flyingttxt.Text)
                {
                    string connectionString = @"Data Source=KARIMWAHBAPC; Initial Catalog=airline; Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO [dbo].[ReservationFlight]([UserName],[FlyingFrom],[FlyingTo],[Departing],[Returning],[Adults],[Children] ,[TravelClass]) VALUES (@username,'1',@FlyingTo,@Departing,@Returning,@Adults,@Children,@TravelClass)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("username", userSession.name);
                            cmd.Parameters.AddWithValue("FlyingFrom", flyingftxt.Text);
                            cmd.Parameters.AddWithValue("FlyingTo", flyingttxt.Text);
                            cmd.Parameters.AddWithValue("Departing", departingdate.Text);
                            cmd.Parameters.AddWithValue("Returning", returningdate.Text);
                            cmd.Parameters.AddWithValue("Adults", adultslist.Text);
                            cmd.Parameters.AddWithValue("Children", childrenlist.Text);
                            cmd.Parameters.AddWithValue("TravelClass", classlist.Text);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            MessageBox.Show("Your Reservation is created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Payments form2 = new Payments();
                            this.Hide();
                            form2.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please inter diffrent values in Flying From and Flying To.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please inter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Reservationform_Load(object sender, EventArgs e)
        {
           
        }

        private void flyingftxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void flyingttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void departingdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void returningdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adultslist_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void childrenlist_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void classlist_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
