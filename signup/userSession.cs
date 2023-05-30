using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signup
{
    public class userSession
    {
        //here if we need to add more session for the user info.
        public static bool IsLoggedIn { get; set; }
        public static int id { get; set; }
        public static string name { get; set; }
        public static string email { get; set; }
        public static string username { get; set; }
        public static string phone { get; set; }
        public static string passport_number { get; set; }
        public static string password { get; set; }
        public static string gender { get; set; }
        public static string age { get; set; }
        public static string address { get; set; }
        public static string role { get; }
        public userSession()
        {

        }

        public userSession(int id, string name, string email, string username, string phone, string passport_number, string password, string gender, string age, string address)
        {
            id = id;
            name = name;
            email = email;
            username = username;
            phone = phone;
            passport_number = passport_number;
            password = password;
            gender = gender;
            age = age;
            address = address;
        }
        public static bool Login(string email, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT * FROM users WHERE Email=@Email AND Password=@Password";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];

                            IsLoggedIn = true;
                            name = row["name"].ToString();
                            email = row["Email"].ToString();

                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        private bool ValidateData(string name, string email, string username, string password, string phone, string passportNumber, string gender, string dateOfBirth, string address)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(passportNumber) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(address))
            {
                return false;
            }

            return true;
        }

        private bool RegisterUser(string name, string email, string username, string password, string phone, string passportNumber, string gender, string dateOfBirth, string address)
        {
            string connectionString = @"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO [dbo].[users] ([name], [email], [username], [phone], [passport_number], [password], [gender], [age], [address], [role]) VALUES (@name, @email, @username, @phone, @passportNumber, @password, @gender, @dateOfBirth, @address, 'user')";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@passportNumber", passportNumber);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@address", address);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        userSession.IsLoggedIn = true;
                        userSession.name = name;
                        userSession.email = email;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}