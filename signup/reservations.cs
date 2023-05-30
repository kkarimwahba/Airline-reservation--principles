using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace signup
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservations_Load(object sender, EventArgs e)
        {
                LoadFlightData();
         }

            private void LoadFlightData()
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[ReservationFlight]", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable flight = new DataTable();
                flight.Load(reader);
                reader.Close();
                con.Close();
            dataGridView1.DataSource = flight;
            }
        }
}
