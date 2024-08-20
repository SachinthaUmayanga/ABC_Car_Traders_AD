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

namespace ABC_Car_Traders
{
    public partial class Car_Orders_Admin : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Car_Orders_Admin()
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

        private void btnCarPartorders_Click(object sender, EventArgs e)
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

        private void GetCarOrderData()
        {
            string query = "SELECT * FROM CarOrders WHERE DeletedDate is NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable datatTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(datatTable);
                    conn.Close();
                    carOrdersDGV.DataSource = datatTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            SearchCarOrders(searchQuery);
        }

        private void SearchCarOrders(string searchQuery)
        {
            try
            {
                var query = @"SELECT * FROM CarOrders WHERE CarOrderID LIKE @SearchQuery OR username LIKE @SearchQuery 
                                OR CarID LIKE @SearchQuery OR CarBrand LIKE @SearchQuery OR CarModel LIKE @SearchQuery 
                                OR OrderStatus LIKE @SearchQuery OR OrderdDate LIKE @SearchQuery";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    carOrdersDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Car_Orders_Admin_Load(object sender, EventArgs e)
        {
            GetCarOrderData();
            cmbOrderStatus.SelectedIndex = 0;
        }

        private void carOrdersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carOrdersDGV.Rows[e.RowIndex];
                lblCarID.Text = row.Cells["CarID"].Value.ToString();
                lblUsername.Text = row.Cells["username"].Value.ToString();
                lblBrand.Text = row.Cells["CarBrand"].Value.ToString();
                lblModel.Text = row.Cells["CarModel"].Value.ToString();
                lblManufacturedYear.Text = row.Cells["ManufacturingYear"].Value.ToString();
                lblTransmission.Text = row.Cells["Transmission"].Value.ToString();
                lblColor.Text = row.Cells["CarColor"].Value.ToString();
                lblLicensePlateNumber.Text = row.Cells["LicensePlateNumber"].Value.ToString();
                lblFuelType.Text = row.Cells["FuelType"].Value.ToString();
                lblPrice.Text = row.Cells["Price"].Value.ToString();
                lblNotes.Text = row.Cells["Notes"].Value.ToString();
                cmbOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();

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
            GetCarOrderData();
            InitilizeTextbox();
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
            lblUsername.Text = "";
            cmbOrderStatus.SelectedIndex = 0;
            pbCar.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCarID.Text))
            {
                MessageBox.Show("Please selact an order to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Fetch car details from CarOrders table
                        string selectQuery = "SELECT * FROM CarOrders WHERE CarID = @CarID AND username = @username";
                        SqlCommand cmd = new SqlCommand(selectQuery, conn);
                        cmd.Parameters.AddWithValue("@CarID", lblCarID.Text);
                        cmd.Parameters.AddWithValue("@username", lblUsername.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            //Prepare car deatails for insertion into Cars table
                            string carID = reader["CarID"].ToString();
                            string carBrand = reader["CarBrand"].ToString();
                            string carModel = reader["CarModel"].ToString();
                            string manufacturingYear = reader["ManufacturingYear"].ToString();
                            string transmission = reader["Transmission"].ToString();
                            string carColor = reader["CarColor"].ToString();
                            string licensePlateNumber = reader["LicensePlateNumber"].ToString();
                            string fuelType = reader["FuelType"].ToString();
                            decimal price = (decimal)reader["Price"];
                            string notes = reader["Notes"].ToString();
                            byte[] picture = reader["Picture"] != DBNull.Value ? (byte[])reader["Picture"] : null;

                            reader.Close();

                            //Insert car details back to Cars table
                            string insertQuery = @"INSERT INTO Cars (CarID, CarBrand, CarModel, ManufacturingYear, Transmission, CarColor, LicensePlateNumber, 
                                                    FuelType, Price, Notes, Picture)
                                                    VALUES (@CarID, @CarBrand, @CarModel, @ManufacturingYear, @Transmission, @CarColor, @LicensePlateNumber, 
                                                    @FuelType, @Price, @Notes, @Picture)";

                            SqlCommand insetCmd = new SqlCommand(insertQuery, conn);
                            insetCmd.Parameters.AddWithValue("@CarID", carID);
                            insetCmd.Parameters.AddWithValue("@CarBrand", carBrand);
                            insetCmd.Parameters.AddWithValue("@CarModel", carModel);
                            insetCmd.Parameters.AddWithValue("@ManufacturingYear", manufacturingYear);
                            insetCmd.Parameters.AddWithValue("@Transmission", transmission);
                            insetCmd.Parameters.AddWithValue("@CarColor", carColor);
                            insetCmd.Parameters.AddWithValue("@LicensePlateNumber", licensePlateNumber);
                            insetCmd.Parameters.AddWithValue("@FuelType", fuelType);
                            insetCmd.Parameters.AddWithValue("@Price", price);
                            insetCmd.Parameters.AddWithValue("@Notes", notes);
                            insetCmd.Parameters.AddWithValue("@Picture", (object)picture ?? DBNull.Value);

                            insetCmd.ExecuteNonQuery();
                        }

                        //Update DeletedDate in CarOrders table instead of deleting
                        string updateQuery = "UPDATE CarOrders SET DeletedDate = @DeletedDate WHERE CarID = @CarID AND username = @username";
                        SqlCommand upadteCmd = new SqlCommand(updateQuery, conn);
                        upadteCmd.Parameters.AddWithValue("@DeletedDate", DateTime.Now);
                        upadteCmd.Parameters.AddWithValue("@CarID", lblCarID.Text);
                        upadteCmd.Parameters.AddWithValue("@username", lblUsername.Text);

                        upadteCmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Car order deleted successfully!");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCarID.Text))
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //Update the OrderStatus and UpdatedDete in the CarOrders table
                    string updateQuery = @"UPDATE CarOrders SET OrderStatus = @OrderStatus, UpdatedDate = @UpdatedDate 
                                            WHERE CarID = @CarID AND username = @username AND DeletedDate is NULL";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@OrderStatus", cmbOrderStatus.Text);
                    updateCmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                    updateCmd.Parameters.AddWithValue("@CarID", lblCarID.Text);
                    updateCmd.Parameters.AddWithValue("@username", lblUsername.Text);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order updated successfully!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Faild to update the order. Please try again.");
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
