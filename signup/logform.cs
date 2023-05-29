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
    public partial class logform : Form
    {
        public logform()
        {
            InitializeComponent();
            string userName = userSession.name;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=KARIMWAHBAPC; Initial Catalog=airline ;Integrated Security=True");

            string email, password;
            email = email_text.Text;
            password = password_text.Text;
            try
            {
                String querry="SELECT *FROM users WHERE Email='"+email_text.Text+"'AND Password='"+password_text.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count>0)
                {
                    email = email_text.Text;
                    password = password_text.Text;
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email_text.Clear();
                    password_text.Clear();
                    email_text.Focus();
                }
                userSession.IsLoggedIn = true;
                userSession.name = "SELECT name FROM users Where Email='" + email_text.Text + "'";
                userSession.email = email_text.Text;
                home Obj = new home();
                this.Hide();
                Obj.Show();
            }
            catch
            {
                MessageBox.Show("Invalid email/password");

            }
            finally
            {
                conn.Close();
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            email_text.Clear();
            password_text.Clear();

            email_text.Focus();
        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if(Show.Checked==true)
            {
                password_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
            }
        }

        private void loginform_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup Obj = new signup();
            this.Hide();
            Obj.Show();
        }
    }
}
