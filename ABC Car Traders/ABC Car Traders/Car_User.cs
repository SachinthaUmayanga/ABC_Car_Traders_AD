using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABC_Car_Traders
{
    public partial class Car_User : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";
        private string _username;

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Car_User(string username)
        {
            InitializeComponent();
            _username = username;
            lblUser.Text = _username + ", Car Details";
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
            Customer_Dashboard frm = new Customer_Dashboard(_username);
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Customer_Dashboard frm = new Customer_Dashboard(_username);
            frm.Show();
            this.Hide();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Car_User frm = new Car_User(_username);
            frm.Show();
            this.Hide();
        }

        private void btnCarPart_Click(object sender, EventArgs e)
        {
            Car_Parts_User frm = new Car_Parts_User(_username);
            frm.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders_User frm = new Orders_User(_username);
            frm.Show();
            this.Hide();
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
            SearchCarData(searchQuery);
        }

        private void SearchCarData(string searchQuery)
        {
            try
            {
                var query = @"SELECT * FROM Cars WHERE (CarID LIKE @SearchQuery OR CarBrand LIKE @SearchQuery OR CarModel LIKE @SearchQuery)
                                AND Status != 'Sold'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    CarsDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCarDetails()
        {
            string query = "SELECT * FROM Cars WHERE Status = 'Unsold'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();
                    CarsDGV.DataSource = dataTable;

                    // Hide the SerialNo column
                    if (CarsDGV.Columns["SerialNo"] != null)
                    {
                        CarsDGV.Columns["SerialNo"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Car_User_Load(object sender, EventArgs e)
        {
            GetCarDetails();
        }

        private void CarsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CarsDGV.Rows[e.RowIndex];
                lblCarID.Text = row.Cells["CarID"].Value.ToString();
                lblBrand.Text = row.Cells["CarBrand"].Value.ToString();
                lblModel.Text = row.Cells["CarModel"].Value.ToString();
                lblManufacturedYear.Text = row.Cells["ManufacturingYear"].Value.ToString();
                lblPrice.Text = row.Cells["Price"].Value.ToString();
                lblNotes.Text = row.Cells["Notes"].Value.ToString();
                lblColor.Text = row.Cells["CarColor"].Value.ToString();
                lblLicensePlateNumber.Text = row.Cells["LicensePlateNumber"].Value.ToString();
                lblTransmission.Text = row.Cells["Transmission"].Value.ToString();
                lblFuelType.Text = row.Cells["FuelType"].Value.ToString();
                if (row.Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Picture"].Value;
                    pbCar.Image = ByteArrayToImage(imageBytes);
                    pbCar.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbCar.Image = null;
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

        private void ClearForm()
        {
            lblBrand.Text = "";
            lblCarID.Text = "";
            lblColor.Text = "";
            lblFuelType.Text = "";
            lblLicensePlateNumber.Text = "";
            lblManufacturedYear.Text = "";
            lblModel.Text = "";
            lblNotes.Text = "";
            lblPrice.Text = "";
            lblTransmission.Text = "";
            InitilizeTextbox();
            pbCar.Image = null;
            GetCarDetails();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblCarID.Text))
            {
                try
                {
                    string carID = lblCarID.Text;
                    string orderStatus = "Pending";
                    DateTime orderdDate = DateTime.Now;
                    string username = _username;
                    string payment = "Pending";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        //Start a transaction
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            string insertOrderQuery = @"INSERT INTO CarOrders (CarID, username, CarBrand, CarModel, ManufacturingYear, Transmission, CarColor, 
                                                        LicensePlateNumber, FuelType, Price, Notes, Picture, OrderStatus, OrderdDate, Payment)
                                                        SELECT CarID, @username, CarBrand, CarModel, ManufacturingYear, Transmission, CarColor, LicensePlateNumber, 
                                                        FuelType, Price, Notes, Picture, @OrderStatus, @OrderdDate, @Payment FROM Cars WHERE CarID = @CarID";

                            using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@CarID", carID);
                                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                                cmd.Parameters.AddWithValue("@OrderdDate", orderdDate);
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@Payment", payment);
                                cmd.Transaction = transaction;
                                cmd.ExecuteNonQuery();
                            }

                            //Update the Status of the car in the Cars table
                            string updateStatusQuery = "UPDATE Cars SET Status = 'Sold' WHERE CarID = @CarID";
                            using (SqlCommand cmd = new SqlCommand(updateStatusQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@CarID", carID);
                                cmd.Transaction = transaction;
                                cmd.ExecuteNonQuery();
                            }

                            //Commit the transaction
                            transaction.Commit();
                            GetCarDetails();
                            ClearForm();
                            MessageBox.Show("Order placed successfully!");
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of an error
                            transaction.Rollback();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a car to order.");
            }
        }
    }
}
