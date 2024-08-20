using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Signup : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        public Signup()
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

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get input values
            var name = txtName.Text;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var confpassword = txtConfirmPW.Text;
            var type = cmbType.SelectedItem.ToString();
            var number = txtNumber.Text;
            var email = txtEmail.Text;
            var address = txtAdd.Text;
            var nic = txtNIC.Text;
            var dob = dtpDOB.Value;
            Image profilepicture = pbProfile.Image;

            // Validate the inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confpassword))
            {
                MessageBox.Show("Fill the empty fields!");
                return;
            }

            if (password != confpassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = HashPassword(password);
            byte[] profilePicBytes = ImageToByteArray(profilepicture);
            SaveUser(name, username, number, email, nic, dob, address, type, profilePicBytes, hashedPassword);

        }

        private void SaveUser(string name, string username, string number, string email, string nic, DateTime dob, string address, string type, byte[] profilepicture, string hashedPassword)
        {
            try
            {
                var query = "INSERT INTO Users VALUES (@username, @password, @type, @name, @number, @email, @nic, @profilepic, @useraddress, @dob)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@profilepic", profilepicture);
                        cmd.Parameters.AddWithValue("@useraddress", address);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record save successfully.");
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string HashPassword(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string hashedPassword = Convert.ToBase64String(hashBytes);
                return hashedPassword;
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnProfilePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif",
                FilterIndex = 1,
                Multiselect = false
            };

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get the file path
                string filePath = ofd.FileName;
                // Load picture into image box
                pbProfile.Image = Image.FromFile(filePath);
                pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ClearForm()
        {
            txtAdd.Clear();
            txtEmail.Clear();
            txtConfirmPW.Clear();
            txtName.Clear();
            txtNIC.Clear();
            txtNumber.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            dtpDOB.Value = DateTime.Now;
            pbProfile.Image = null;
            cmbType.SelectedIndex = 0;
            txtName.Focus();
        }
    }
}
