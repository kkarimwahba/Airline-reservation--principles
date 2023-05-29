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
using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;
using Xunit;
using System.Web;

namespace signup
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();

        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_text.Text)&& !string.IsNullOrEmpty(email_text.Text)&& string.IsNullOrEmpty(username_text.Text)&& string.IsNullOrEmpty(password_text.Text)&& string.IsNullOrEmpty(phone_text.Text)&& string.IsNullOrEmpty(PassNo_text.Text)&& string.IsNullOrEmpty(date_text.Text)&&string.IsNullOrEmpty(address_text.Text))

            {
                MessageBox.Show("Error inserting data: Please Enter Your Data!!");

            }
            else
            {
                string connectionString = @"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO [dbo].[users]
            ([name], [email], [username], [phone], [passport_number], [password], [gender], [age], [address],[role])
            VALUES (@name, @email, @username, @phone, @passportNumber, @password, @gender, @dateOfBirth, @address,'user')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name_text.Text);
                        cmd.Parameters.AddWithValue("@email", email_text.Text);
                        cmd.Parameters.AddWithValue("@username", username_text.Text);
                        cmd.Parameters.AddWithValue("@phone", phone_text.Text);
                        cmd.Parameters.AddWithValue("@passportNumber", PassNo_text.Text);
                        cmd.Parameters.AddWithValue("@password", password_text.Text);
                        cmd.Parameters.AddWithValue("@gender", gender_box.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@dateOfBirth", date_text.Text);
                        cmd.Parameters.AddWithValue("@address", address_text.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            userSession.IsLoggedIn = true;
                            userSession.name = name_text.Text;
                            userSession.email = email_text.Text;
                            MessageBox.Show("Registered successfully!");
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
        
        private void login_btn_Click(object sender, EventArgs e)
        {
            logform Obj = new logform();
            this.Hide();
            Obj.Show();
        }
    }
}
