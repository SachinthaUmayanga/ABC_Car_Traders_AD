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
    public partial class Car_Parts_Orders_Admin : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Car_Parts_Orders_Admin()
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

        private void GetCarPartsData()
        {
            string query = "SELECT * FROM CarPartOrders WHERE DeletedDate is NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable datatTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(datatTable);
                    conn.Close();
                    carPartOrdersDGV.DataSource = datatTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Car_Parts_Orders_Admin_Load(object sender, EventArgs e)
        {
            GetCarPartsData();
            lblTotPrice.Text = "0.00";
            cmbOrderStatus.SelectedIndex = 0;
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
            SearchCarPartOrders(searchQuery);
        }

        private void SearchCarPartOrders(string searchQuery)
        {
            try
            {
                var query = "SELECT * FROM CarPartOrders WHERE PartOrderID LIKE @SearchQuery OR username LIKE @SearchQuery OR PartID LIKE @SearchQuery OR PartName LIKE @SearchQuery OR PartNumber LIKE @SearchQuery OR OrderStatus LIKE @SearchQuery OR CompatibleCars LIKE @SearchQuery";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
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

        private void ClearForm()
        {
            GetCarPartsData();
            InitilizeTextbox();
            pbCarParts.Image = null;
            lblCompatibleCars.Text = "";
            lblManufacturedYear.Text = "";
            lblPartID.Text = "";
            lblPartName.Text = "";
            lblPartNumber.Text = "";
            lblTotPrice.Text = "0.00";
            lblUnitPrice.Text = "";
            lblUsername.Text = "";
            lblOrderID.Text = "";
            txtOrderdQuantity.Clear();
            cmbOrderStatus.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void carPartOrdersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carPartOrdersDGV.Rows[e.RowIndex];
                lblOrderID.Text = row.Cells["PartOrderID"].Value.ToString();
                lblPartID.Text = row.Cells["PartID"].Value.ToString();
                lblUsername.Text = row.Cells["username"].Value.ToString();
                lblPartName.Text = row.Cells["PartName"].Value.ToString();
                lblPartNumber.Text = row.Cells["PartNumber"].Value.ToString();
                lblManufacturedYear.Text = row.Cells["ManufacturingYear"].Value.ToString();
                lblCompatibleCars.Text = row.Cells["CompatibleCars"].Value.ToString();
                lblUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtOrderdQuantity.Text = row.Cells["OrderdQuantity"].Value.ToString();
                cmbOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
                lblTotPrice.Text = row.Cells["TotalPrice"].Value.ToString();

                if (row.Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Picture"].Value;
                    pbCarParts.Image = ByteArrayToImage(imageBytes);
                    pbCarParts.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbCarParts.Image = null;
                }
            }
        }

        private void txtOrderdQuantity_TextChanged(object sender, EventArgs e)
        {
            //Retrive unit price from unitprice lable
            if (decimal.TryParse(lblUnitPrice.Text, out decimal unitPrice))
            {
                //Retrive quantity from quantity textbox
                if (int.TryParse(txtOrderdQuantity.Text, out int quantity))
                {
                    //Calculate total price
                    decimal totPrice = unitPrice * quantity;

                    //Display total price
                    lblTotPrice.Text = totPrice.ToString();
                }
                else
                {
                    lblTotPrice.Text = "0.00";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblPartID.Text))
            {
                MessageBox.Show("Please selact an order to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete this order?", "Delete Order!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int orderdQuantity = GetOrderedQuantity(lblOrderID.Text);

                    //Check if ordered quantity was retrived successfully
                    if (orderdQuantity > 0)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            //Update CarPartOrders to set DeletedDate
                            string deleteQuery = "UPDATE CarPartOrders SET DeletedDate = @DeletedDate WHERE PartOrderID = @PartOrderID";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                            deleteCmd.Parameters.AddWithValue("@DeletedDate", DateTime.Now);
                            deleteCmd.Parameters.AddWithValue("@PartOrderID", lblOrderID.Text);

                            conn.Open();
                            deleteCmd.ExecuteNonQuery();

                            //Update CarParts to restore quantity
                            string updateQuery = "UPDATE CarParts SET Quantity = Quantity + @OrderdQuantity WHERE PartID = @PartID";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@OrderdQuantity", orderdQuantity);
                            updateCmd.Parameters.AddWithValue("@PartID", lblPartID.Text);

                            updateCmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        MessageBox.Show("Order Delete successfully!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ordered quantity. Cannot proceed with deletion");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int GetOrderedQuantity(string partOrderID)
        {
            int orderedQuantity = 0;
            string query = "SELECT OrderdQuantity FROM CarPartOrders WHERE PartOrderID = @PartOrderID AND DeletedDate IS NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PartOrderID", partOrderID);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        orderedQuantity = Convert.ToInt32(result);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return orderedQuantity;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblOrderID.Text))
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to update this order?", "Update Order!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Retrieve the old ordered quantity
                        int oldOrderedQuantity = GetOrderedQuantity(lblOrderID.Text);

                        // Calculate the difference between the new and old quantities
                        int newOrderedQuantity = int.Parse(txtOrderdQuantity.Text);
                        int quantityDifference = newOrderedQuantity - oldOrderedQuantity;

                        if (quantityDifference != 0)
                        {
                            // Update the CarParts table based on whether the quantity is increased or decreased
                            string updatePartsQuery;

                            if (quantityDifference > 0) // Quantity increased, so decrease available parts
                            {
                                updatePartsQuery = "UPDATE CarParts SET Quantity = Quantity - @QuantityDifference WHERE PartID = @PartID";
                            }
                            else // Quantity decreased, so increase available parts
                            {
                                updatePartsQuery = "UPDATE CarParts SET Quantity = Quantity + @QuantityDifference WHERE PartID = @PartID";
                            }

                            SqlCommand updatePartsCmd = new SqlCommand(updatePartsQuery, conn);
                            updatePartsCmd.Parameters.AddWithValue("@QuantityDifference", Math.Abs(quantityDifference)); // Use absolute value
                            updatePartsCmd.Parameters.AddWithValue("@PartID", lblPartID.Text);
                            updatePartsCmd.ExecuteNonQuery();
                        }

                        // Update the CarPartOrders table with new quantity, price, status, and updated date
                        string updateOrderQuery = "UPDATE CarPartOrders SET OrderdQuantity = @OrderdQuantity, TotalPrice = @TotalPrice, OrderStatus = @OrderStatus, UpdatedDate = @UpdatedDate WHERE PartOrderID = @PartOrderID";
                        SqlCommand updateOrderCmd = new SqlCommand(updateOrderQuery, conn);
                        updateOrderCmd.Parameters.AddWithValue("@OrderdQuantity", newOrderedQuantity);
                        updateOrderCmd.Parameters.AddWithValue("@TotalPrice", decimal.Parse(lblTotPrice.Text));
                        updateOrderCmd.Parameters.AddWithValue("@OrderStatus", cmbOrderStatus.SelectedItem.ToString());
                        updateOrderCmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                        updateOrderCmd.Parameters.AddWithValue("@PartOrderID", lblOrderID.Text);
                        updateOrderCmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Order updated successfully!");
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
