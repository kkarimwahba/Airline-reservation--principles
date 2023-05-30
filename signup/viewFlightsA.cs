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

namespace admin
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-34bf6lq;Initial Catalog=flights;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadFlightData();
        }

        private void LoadFlightData()
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [ID], [Departure], [Arrival], [Price], [Date] FROM [flights].[dbo].[flight]", con);
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
            flightt.DataSource = flight;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
