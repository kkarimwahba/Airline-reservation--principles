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
    public partial class addf : Form
    {
        private IFlight adapter;
        public addf()
        {

            InitializeComponent();

            airlineSystem airlineSystem = new airlineSystem();
            adapter = new FlightAdapter(airlineSystem);
        }

        SqlConnection con = new SqlConnection(@"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True");

        private void addf_Load(object sender, EventArgs e)
        { 
         LoadFlightData();
        }

    private void LoadFlightData()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT [ID], [Departure], [Arrival], [Price], [Date] FROM [dbo].[flights]", con);
        SqlDataReader reader = cmd.ExecuteReader();
        DataTable flight = new DataTable();
        flight.Load(reader);
        reader.Close();
        con.Close();
        flightt.DataSource = flight;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[flights] ([Arrival],[Departure],[Date],[Price]) VALUES (@Arrival, @Departure, @Date, @Price)", con);
            
            cmd.Parameters.AddWithValue("@Departure", departureTextBox.Text);
            cmd.Parameters.AddWithValue("@Arrival", arrivalTextBox.Text);
            cmd.Parameters.AddWithValue("@Date", dateTextBox.Text);
            cmd.Parameters.AddWithValue("@Price", priceTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            LoadFlightData(); // Refresh the flight data after adding a new record

            // Clear the input fields
            departureTextBox.Clear();
            arrivalTextBox.Clear();
            priceTextBox.Clear();
            dateTextBox.Clear();
            
            String Departure = departureTextBox.Text;
            String Arrival = arrivalTextBox.Text;
            String Price = priceTextBox.Text;
            String Date = dateTextBox.Text;


            adapter.AddFlight(Departure, Arrival, Price, Date);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void departureTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightt_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
