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
    public partial class Customer_Management : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Customer_Management()
        {
            InitializeComponent();
            InitilizeTextbox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Admin_Dashboard frm = new Admin_Dashboard();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard frm = new Admin_Dashboard();
            frm.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customer_Management frm = new Customer_Management();
            frm.Show();
            this.Hide();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            Car_Management frm = new Car_Management();
            frm.Show();
            this.Hide();
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            Manage_Car_Parts frm = new Manage_Car_Parts();
            frm.Show();
            this.Hide();
        }

        private void btnCarOrders_Click(object sender, EventArgs e)
        {
            Car_Orders_Admin frm = new Car_Orders_Admin();
            frm.Show();
            this.Hide();
        }

        private void btnCarPartsOrders_Click(object sender, EventArgs e)
        {
            Car_Parts_Orders_Admin frm = new Car_Parts_Orders_Admin();
            frm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports_Admin frm = new Reports_Admin();
            frm.Show();
            this.Hide();
        }

        private void GetCustomerData()
        {
            string query = "SELECT * FROM Users WHERE username != 'Admin'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    conn.Close();
                    CustomerDGV.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Customer_Management_Load(object sender, EventArgs e)
        {
            GetCustomerData();
            cmbType.SelectedIndex = 0;
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
            var dob = dtpDOB.Text;
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

        private void SaveUser(string name, string username, string number, string email, string nic, string dob, string address, string type, byte[] profilepicture, string hashedPassword)
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
                        GetCustomerData();
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
            if (image == null)
                return null;

            using (var ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Use a fixed format
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error converting image to byte array: " + ex.Message);
                    return null;
                }
            }
        }

        private void ClearForm()
        {
            btnUpdate.Visible = false;
            btnRegister.Visible = true;
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
            txtConfirmPW.Show();
            txtPassword.Show();
            lblCFPW.Show();
            lblPW.Show();
            lblUT.Show();
            cmbType.Show();
            GetCustomerData();
            InitilizeTextbox();
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

        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtConfirmPW.Hide();
            txtPassword.Hide();
            lblCFPW.Hide();
            lblPW.Hide();
            lblUT.Hide();
            cmbType.Hide();
            btnUpdate.Visible = true;
            btnRegister.Visible = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomerDGV.Rows[e.RowIndex];
                txtName.Text = row.Cells["name"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtUsername.ReadOnly = true;
                txtNumber.Text = row.Cells["number"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtNIC.Text = row.Cells["nic"].Value.ToString();
                txtAdd.Text = row.Cells["useraddress"].Value.ToString();

                if (row.Cells["profilepic"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["profilepic"].Value;
                    pbProfile.Image = ByteArrayToImage(imageBytes);
                    pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbProfile.Image = null;
                }

                if (row.Cells["dob"].Value != DBNull.Value)
                {
                    string dobString = row.Cells["dob"].Value.ToString();
                    DateTime dob;
                    if (DateTime.TryParse(dobString, out dob))
                    {
                        dtpDOB.Value = dob;
                    }
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get input values
            var name = txtName.Text;
            var username = txtUsername.Text;
            var number = txtNumber.Text;
            var email = txtEmail.Text;
            var address = txtAdd.Text;
            var nic = txtNIC.Text;
            var dob = dtpDOB.Text;
            Image profilepicture = pbProfile.Image;

            byte[] profilePicBytes = ImageToByteArray(profilepicture);
            UpdateUser(name, username, number, email, nic, dob, address, profilePicBytes);
        }

        private void UpdateUser(string name, string username, string number, string email, string nic, string dob, string address, byte[] profilepicture)
        {
            try
            {
                var query = "UPDATE Users SET name=@name, number=@number, email=@email, nic=@nic, profilepic=@profilepic, useraddress=@useraddress, dob=@dob WHERE username=@username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@nic", nic);

                        // Set the parameter type explicitly for the image
                        SqlParameter imageParameter = new SqlParameter("@profilepic", SqlDbType.VarBinary);
                        imageParameter.Value = (object)profilepicture ?? DBNull.Value;
                        cmd.Parameters.Add(imageParameter);

                        cmd.Parameters.AddWithValue("@useraddress", address);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("User updated successfully.");
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the username to be deleted
            var username = txtUsername.Text;

            //Confirm the delete action
            var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteUser(username);
            }
        }

        private void DeleteUser(string username)
        {
            try
            {
                var query = "DELETE FROM Users WHERE username=@username";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("User deleted successfully.");
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitilizeTextbox()
        {
            txtSearch.Text = placeholderText;
            txtSearch.ForeColor = placeholderColor;

            txtSearch.Enter += RemovePlaceholderText;
            txtSearch.Leave += SetPlaceholderText;
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox textboxSearch = sender as TextBox;
            if (textboxSearch.Text == placeholderText)
            {
                textboxSearch.Text = "";
                textboxSearch.ForeColor = regulerTextColor;
            }
        }

        private void SetPlaceholderText(object sender, EventArgs e)
        {
            TextBox textboxSearch = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textboxSearch.Text))
            {
                textboxSearch.Text = placeholderText;
                textboxSearch.ForeColor = placeholderColor;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (searchQuery == placeholderText)
            {
                searchQuery = ""; //Ignore the placeholder text
            }
            SearchUser(searchQuery);
        }

        private void SearchUser(string searchQuery)
        {
            try
            {
                var query = @"SELECT * FROM Users WHERE (username LIKE @SearchQuery OR nic LIKE @SearchQuery OR name LIKE @SearchQuery OR useraddress LIKE @SearchQuery) AND username != 'Admin'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    CustomerDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
