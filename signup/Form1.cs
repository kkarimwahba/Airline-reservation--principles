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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True");
        private void flightt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFlightData();
        }

        private void LoadFlightData()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [ID], [Departure], [Arrival], [Price], [Date] FROM [dbo].[flights]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable flight = new DataTable();
            flight.Columns.Add("ID");
            flight.Columns.Add("Departure");
            flight.Columns.Add("Arrival");
            flight.Columns.Add("Price");
            flight.Columns.Add("Date");
            DataRow row;
            while (reader.Read())
            {
                row = flight.NewRow();
                row["ID"] = reader["ID"];
                row["Departure"] = reader["Departure"];
                row["Arrival"] = reader["Arrival"];
                row["Price"] = reader["Price"];
                row["Date"] = reader["Date"];
                flight.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            flight2.DataSource = flight;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadFlightData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reserve_btn_Click(object sender, EventArgs e)
        {
            Reservationform reservation = new Reservationform();
            reservation.Show();
            this.Close();
        }
    }
}
