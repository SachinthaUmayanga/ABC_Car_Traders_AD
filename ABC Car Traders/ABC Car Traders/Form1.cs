using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Login : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";


        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup frm = new Signup();
            frm.Show();
            this.Hide();
        }

        private bool VeryfyPassword(string enterdPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(enterdPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUN.Text;
            string password = txtPW.Text;

            // Check if username or password fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password fields cannot be empty. Please enter valid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT password, type FROM Users WHERE Username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string storedHash = reader["password"].ToString();
                            string userType = reader["type"].ToString();

                            if (VeryfyPassword(password, storedHash))
                            {
                                if (userType == "Admin")
                                {
                                    // Redirect to admin dashboard
                                    Admin_Dashboard adminForm = new Admin_Dashboard();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else if (userType == "User")
                                {
                                    // Redirect to user dashboard
                                    Customer_Dashboard userForm = new Customer_Dashboard(username);
                                    userForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid password. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
