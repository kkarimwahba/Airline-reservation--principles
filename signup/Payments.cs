using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace signup
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=KARIMWAHBAPC; Initial Catalog=airline; Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO [dbo].[Payment]
            ([username], [Amount], [CardNum], [CVV], [CardholderName], [ExpireDate])
            VALUES (@username, '15000', @cardNum, @cvv, @holderName, @expDate)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username_text.Text); // Use Text property of the TextBox control
                    cmd.Parameters.AddWithValue("@cardNum", cardNum_text.Text);
                    cmd.Parameters.AddWithValue("@cvv", expDate_text.Text);
                    cmd.Parameters.AddWithValue("@holderName", holdername_text.Text);
                    cmd.Parameters.AddWithValue("@expDate", cvv_text.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        userSession.IsLoggedIn = true;
                        userSession.name = username_text.Text;
                        MessageBox.Show("Purchase is successfully done!");
                        home Obj = new home();
                        this.Hide();
                        Obj.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message);
                    }
                }
            }
        }
    }
}
