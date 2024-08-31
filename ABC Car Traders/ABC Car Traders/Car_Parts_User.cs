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
    public partial class Car_Parts_User : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";
        private string _username;

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Car_Parts_User(string username)
        {
            InitializeComponent();

            _username = username;
            lblUser.Text = _username + ", Car Parts Details";

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

        private void GetCarPartsDetails()
        {
            string query = "SELECT * FROM CarParts";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();
                    CarPartsDGV.DataSource = dataTable;

                    // Hide the SerialNo column
                    if (CarPartsDGV.Columns["SerialNo"] != null)
                    {
                        CarPartsDGV.Columns["SerialNo"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CarPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CarPartsDGV.Rows[e.RowIndex];
                lblPartID.Text = row.Cells["PartID"].Value.ToString();
                lblPartName.Text = row.Cells["PartName"].Value.ToString();
                lblPartNumber.Text = row.Cells["PartNumber"].Value.ToString();
                lblManufacturedYear.Text = row.Cells["ManufacturingYear"].Value.ToString();
                lblCompatibleCars.Text = row.Cells["CompatibleCars"].Value.ToString();
                lblAvailableQuantity.Text = row.Cells["Quantity"].Value.ToString();
                lblUnitPrice.Text = row.Cells["Price"].Value.ToString();
                lblDescription.Text = row.Cells["Description"].Value.ToString();

                if (row.Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Picture"].Value;
                    pbCarPart.Image = ByteArrayToImage(imageBytes);
                    pbCarPart.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbCarPart.Image = null;
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

        private void Car_Parts_User_Load(object sender, EventArgs e)
        {
            GetCarPartsDetails();
            lblTotPrice.Text = "0.00";
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
            SearchCarPartData(searchQuery);
        }

        private void SearchCarPartData(string searchQuery)
        {
            try
            {
                var query = @"SELECT * FROM CarParts WHERE PartID LIKE @SearchQuery OR PartName LIKE @SearchQuery OR PartNumber LIKE @SearchQuery 
                            OR CompatibleCars LIKE @SearchQuery";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    CarPartsDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            //Retrive unit price from unitprice lable
            if (decimal.TryParse(lblUnitPrice.Text, out decimal unitPrice))
            {
                //Retrive quantity from quantity textbox
                if (int.TryParse(txtQuantity.Text, out int quantity))
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

        private void ClearForm()
        {
            GetCarPartsDetails();
            InitilizeTextbox();
            lblAvailableQuantity.Text = "";
            lblCompatibleCars.Text = "";
            lblDescription.Text = "";
            lblManufacturedYear.Text = "";
            lblPartID.Text = "";
            lblPartName.Text = "";
            lblPartNumber.Text = "";
            lblUnitPrice.Text = "";
            txtQuantity.Clear();
            lblTotPrice.Text = "0.00";
            pbCarPart.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int availableQuantity;
            int orderdQuantity;

            //Get available quantity from the lable
            if (int.TryParse(lblAvailableQuantity.Text, out availableQuantity) && int.TryParse(txtQuantity.Text, out orderdQuantity))
            {
                if (orderdQuantity <= availableQuantity)
                {
                    int newQuantity = availableQuantity - orderdQuantity;

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            //Update car parts quantity
                            string updateQuery = "UPDATE CarParts SET Quantity=@NewQuantity WHERE PartID=@PartID";
                            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                cmd.Parameters.AddWithValue("@PartID", lblPartID.Text);
                                cmd.ExecuteNonQuery();
                            }

                            // Convert the image in pictureBox to a byte array
                            byte[] imageBytes = ImageToByteArray(pbCarPart.Image);

                            //Insert order details into the CarpartOrders table
                            string insertQuery = @"INSERT INTO CarPartOrders (PartID, username, PartName, PartNumber, ManufacturingYear, CompatibleCars, Picture, 
                                                    OrderdQuantity, UnitPrice, TotalPrice, OrderStatus, OrderDate, Payment) 
                                                    VALUES (@PartID, @username, @PartName, @PartNumber, @ManufacturingYear, @CompatibleCars, @Picture, @OrderdQuantity, 
                                                    @UnitPrice, @TotalPrice, @OrderStatus, @OrderDate, @Payment)";
                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@PartID", lblPartID.Text);
                                cmd.Parameters.AddWithValue("@username", _username);
                                cmd.Parameters.AddWithValue("@PartName", lblPartName.Text);
                                cmd.Parameters.AddWithValue("@Partnumber", lblPartNumber.Text);
                                cmd.Parameters.AddWithValue("@ManufacturingYear", lblManufacturedYear.Text);
                                cmd.Parameters.AddWithValue("@CompatibleCars", lblCompatibleCars.Text);
                                cmd.Parameters.AddWithValue("@Picture", imageBytes);
                                cmd.Parameters.AddWithValue("@OrderdQuantity", orderdQuantity);
                                cmd.Parameters.AddWithValue("@UnitPrice", lblUnitPrice.Text);
                                cmd.Parameters.AddWithValue("@TotalPrice", lblTotPrice.Text);
                                cmd.Parameters.AddWithValue("@OrderStatus", "Pending");
                                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@Payment", "Pending");
                                cmd.ExecuteNonQuery();
                            }

                            conn.Close();
                        }

                        MessageBox.Show("Order placed successfully!");
                        GetCarPartsDetails();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient quantity available.");
                }
            }
            else
            {
                MessageBox.Show("Please eter a valid buying quantity.");
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
    }
}
