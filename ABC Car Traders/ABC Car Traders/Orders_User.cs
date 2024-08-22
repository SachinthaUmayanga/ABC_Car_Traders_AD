using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Orders_User : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";
        private string _username;

        string placeholderTextCar = "Search car orders here...";
        string placeholderTextCarParts = "Search car part orders here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Orders_User(string username)
        {
            InitializeComponent();
            _username = username;
            lblUser.Text = _username + ", Orders";
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
            txtSearchCars.Text = placeholderTextCar;
            txtSearchCars.ForeColor = placeholderColor;

            txtSearchCars.Enter += RemovePlaceholderText;
            txtSearchCars.Leave += SetPlaceholderText;

            txtSearchCarParts.Text = placeholderTextCarParts;
            txtSearchCarParts.ForeColor = placeholderColor;

            txtSearchCarParts.Enter += RemovePlaceholderText;
            txtSearchCarParts.Leave += SetPlaceholderText;
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox textboxSearchCar = sender as TextBox;
            if (textboxSearchCar.Text == placeholderTextCar)
            {
                textboxSearchCar.Text = "";
                textboxSearchCar.ForeColor = regulerTextColor;
            }

            TextBox textboxSearchCarPart = sender as TextBox;
            if (textboxSearchCarPart.Text == placeholderTextCarParts)
            {
                textboxSearchCarPart.Text = "";
                textboxSearchCarPart.ForeColor = regulerTextColor;
            }
        }

        private void SetPlaceholderText(object sender, EventArgs e)
        {
            TextBox textboxSearchCar = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textboxSearchCar.Text))
            {
                textboxSearchCar.Text = placeholderTextCar;
                textboxSearchCar.ForeColor = placeholderColor;
            }

            TextBox textboxSearchCarPart = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textboxSearchCarPart.Text))
            {
                textboxSearchCarPart.Text = placeholderTextCarParts;
                textboxSearchCarPart.ForeColor = placeholderColor;
            }
        }

        private void GetCarOrders(string username)
        {
            string query = "SELECT * FROM CarOrders WHERE username = @username AND DeletedDate is NULL AND Payment = 'Pending'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();
                    carOrdersDGV.DataSource = dataTable;

                    //Hide specific columns
                    carOrdersDGV.Columns["DeletedDate"].Visible = false;
                    carOrdersDGV.Columns["Notes"].Visible = false;
                    carOrdersDGV.Columns["FuelType"].Visible = false;
                    carOrdersDGV.Columns["CarColor"].Visible = false;
                    carOrdersDGV.Columns["Transmission"].Visible = false;
                    carOrdersDGV.Columns["LicensePlateNumber"].Visible = false;
                    carOrdersDGV.Columns["ManufacturingYear"].Visible = false;
                    carOrdersDGV.Columns["CarBrand"].Visible = false;
                    carOrdersDGV.Columns["CarID"].Visible = false;
                    carOrdersDGV.Columns["CarOrderID"].Visible = false;
                    carOrdersDGV.Columns["Picture"].Visible = false;
                    carOrdersDGV.Columns["PaidDate"].Visible = false;
                    carOrdersDGV.Columns["UpdatedDate"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GetCarPartOrders(string username)
        {
            string query = "SELECT * FROM CarPartOrders WHERE username = @username AND DeletedDate is NULL AND Payment = 'Pending'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();
                    carPartOrdersDGV.DataSource = dataTable;

                    //Hide specific columns
                    carPartOrdersDGV.Columns["PartOrderID"].Visible = false;
                    carPartOrdersDGV.Columns["PartID"].Visible = false;
                    carPartOrdersDGV.Columns["PartNumber"].Visible = false;
                    carPartOrdersDGV.Columns["ManufacturingYear"].Visible = false;
                    carPartOrdersDGV.Columns["CompatibleCars"].Visible = false;
                    carPartOrdersDGV.Columns["Picture"].Visible = false;
                    carPartOrdersDGV.Columns["DeletedDate"].Visible = false;
                    carPartOrdersDGV.Columns["UpdatedDate"].Visible = false;
                    carPartOrdersDGV.Columns["PaidDate"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Orders_User_Load(object sender, EventArgs e)
        {
            GetCarOrders(_username);
            GetCarPartOrders(_username);

            //Display the Grand toal
            ClalculateAndDisplayTotalPrice(_username);
        }

        private void ClalculateAndDisplayTotalPrice(string username)
        {
            decimal carordersTotal = 0;
            decimal carpartOrdersTotal = 0;

            string carOrderQuery = "SELECT COALESCE(SUM(Price), 0) FROM CarOrders WHERE username = @username AND DeletedDate is NULL AND Payment = 'Pending'";
            string carPartOrderQuery = "SELECT COALESCE(SUM(TotalPrice), 0) FROM CarPartOrders WHERE username = @username AND DeletedDate is NULL AND Payment = 'Pending'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand carOrderCmd = new SqlCommand(carOrderQuery, conn);
                SqlCommand carPartOrderCmd = new SqlCommand(carPartOrderQuery, conn);

                // Assign the username parameter to each command
                carOrderCmd.Parameters.AddWithValue("@username", username);
                carPartOrderCmd.Parameters.AddWithValue("@username", username);

                try
                {
                    conn.Open();

                    // Execute car orders total query
                    carordersTotal = (decimal)carOrderCmd.ExecuteScalar();

                    // Execute car part orders total query
                    carpartOrdersTotal = (decimal)carPartOrderCmd.ExecuteScalar();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            decimal grandTotal = carordersTotal + carpartOrdersTotal;
            lblGrandTotal.Text = $"{grandTotal:F2}";
        }

        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            string carSearchQuery = txtSearchCars.Text.Trim();

            if (carSearchQuery == placeholderTextCar)
            {
                carSearchQuery = ""; // Ignore the placeholder text
            }
            SearchCarOrders(carSearchQuery);
        }

        private void SearchCarOrders(string carSearchQuery)
        {
            try
            {
                var query = @"SELECT * FROM CarOrders WHERE (CarModel LIKE @SearchQuery OR OrderStatus LIKE @SearchQuery)
                                AND username = @username AND DeletedDate is NULL AND Payment = 'Pending'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + carSearchQuery + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@username", _username);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    // Add data to the DataGridView
                    carOrdersDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCarPartSearch_Click(object sender, EventArgs e)
        {
            string carPartSearchQuery = txtSearchCars.Text.Trim();

            if (carPartSearchQuery == placeholderTextCar)
            {
                carPartSearchQuery = ""; // Ignore the placeholder text
            }
            SearchCarPartOrders(carPartSearchQuery);
        }

        private void SearchCarPartOrders(string carPartSearchQuery)
        {
            try
            {
                var query = @"SELECT * FROM CarPartOrders WHERE (PartName LIKE @SearchQuery OR OrderStatus LIKE @SearchQuery)
                                AND username = @username AND DeletedDate is NULL AND Payment = 'Pending'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + carPartSearchQuery + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@username", _username);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    carPartOrdersDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carOrdersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPartNameDis.Visible = false;
            lblQuantity.Visible = false;
            lblQuantityDis.Visible = false;
            lblCarModelDis.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carOrdersDGV.Rows[e.RowIndex];
                lblUsername.Text = row.Cells["username"].Value.ToString();
                lblPatNameOrCarModel.Text = row.Cells["CarModel"].Value.ToString();
                lblPrice.Text = row.Cells["Price"].Value.ToString();
                lblOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
                lblOrderdDate.Text = row.Cells["OrderdDate"].Value.ToString();
            }
        }

        private void carPartOrdersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCarModelDis.Visible = false;
            lblPartNameDis.Visible = true;
            lblQuantity.Visible = true;
            lblQuantityDis.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carPartOrdersDGV.Rows[e.RowIndex];
                lblUsername.Text = row.Cells["username"].Value.ToString();
                lblPatNameOrCarModel.Text = row.Cells["PartName"].Value.ToString();
                lblPrice.Text = row.Cells["TotalPrice"].Value.ToString();
                lblOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
                lblOrderdDate.Text = row.Cells["OrderDate"].Value.ToString();
                lblQuantity.Text = row.Cells["OrderdQuantity"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            GetCarOrders(_username);
            GetCarPartOrders(_username);
            ClalculateAndDisplayTotalPrice(_username);
            InitilizeTextbox();
            lblOrderdDate.Text = "";
            lblOrderStatus.Text = "";
            lblPatNameOrCarModel.Text = "";
            lblPrice.Text = "";
            lblQuantity.Text = "";
            lblUsername.Text = "";
            lblQuantityDis.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal totPrice;
            if (decimal.TryParse(lblGrandTotal.Text, out totPrice) && totPrice > 0)
            {
                DialogResult result = MessageBox.Show($"Your total price is {totPrice:F2}. Do you want to proceed with the payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string paymentQuery = "INSERT INTO Payments (username, GrandTotal, PaymentDate) VALUES (@username, @GrandTotal, @PaymentDate); SELECT SCOPE_IDENTITY();";
                    string updateCarOrderQuery = "UPDATE CarOrders SET Payment = 'Paid', PaidDate = @PaymentDate WHERE username = @username AND Payment = 'Pending' AND DeletedDate is NULL";
                    string updateCarPartOrderQuery = "UPDATE CarPartOrders SET Payment = 'Paid', PaidDate = @PaymentDate WHERE username = @username AND Payment = 'Pending' AND DeletedDate is NULL";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn);
                        SqlCommand updateCarOrderCmd = new SqlCommand(updateCarOrderQuery, conn);
                        SqlCommand updateCarPartOrderCmd = new SqlCommand(updateCarPartOrderQuery, conn);

                        // Set parameters for the payment
                        paymentCmd.Parameters.AddWithValue("@username", _username);
                        paymentCmd.Parameters.AddWithValue("@GrandTotal", totPrice);
                        paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);

                        // Set parameters for updating the car orders
                        updateCarOrderCmd.Parameters.AddWithValue("@username", _username);
                        updateCarOrderCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);

                        // Set parameters for updating the car part orders
                        updateCarPartOrderCmd.Parameters.AddWithValue("@username", _username);
                        updateCarPartOrderCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);

                        try
                        {
                            conn.Open();

                            // Execute payment command
                            int paymentID = Convert.ToInt32(paymentCmd.ExecuteScalar());

                            // Update car orders and car part orders
                            updateCarOrderCmd.ExecuteNonQuery();
                            updateCarPartOrderCmd.ExecuteNonQuery();

                            MessageBox.Show($"Payment of {totPrice:F2} was successful! Your payment ID is {paymentID}.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no pending orders to pay for.", "No Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
