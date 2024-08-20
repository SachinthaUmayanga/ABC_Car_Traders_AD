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
    public partial class Manage_Car_Parts : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Manage_Car_Parts()
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

        private void btnCarPartOrders_Click(object sender, EventArgs e)
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

        private void btnBrowse_Click(object sender, EventArgs e)
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
                pbCarPart.Image = Image.FromFile(filePath);
                pbCarPart.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ClearForm()
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            pbCarPart.Image = null;
            txtCompatibleCars.Clear();
            txtDescription.Clear();
            txtManufacturedYear.Clear();
            txtNameofPart.Clear();
            txtPartNumber.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtNameofPart.Focus();
            PartIDGenarate();
            GetPartData();
            InitilizeTextbox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void PartIDGenarate()
        {
            try
            {
                string getData = "SELECT * FROM CarParts";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(getData, conn))
                    {
                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }

                        int MaxSerial = 0, NewSerial = 0;
                        string SMax = "0";
                        if (dataTable.Rows.Count > 0)
                        {
                            string getMaxId = "SELECT MAX(SerialNo) FROM CarParts";
                            using (SqlCommand cmdMax = new SqlCommand(getMaxId, conn))
                            {
                                using (SqlDataReader reader = cmdMax.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        SMax = reader.GetValue(0).ToString();
                                    }
                                }
                            }
                            MaxSerial = int.Parse(SMax);
                            NewSerial = MaxSerial + 1;
                        }
                        else
                        {
                            NewSerial = 1;
                        }
                        lblID.Text = "PART - " + NewSerial.ToString();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Manage_Car_Parts_Load(object sender, EventArgs e)
        {
            PartIDGenarate();
            GetPartData();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values
            var partID = lblID.Text;
            var partName = txtNameofPart.Text;
            var partNumber = txtPartNumber.Text;
            var manufacturedYear = txtManufacturedYear.Text;
            var compatibleCars = txtCompatibleCars.Text;
            var quantity = txtQuantity.Text;
            var price = txtPrice.Text;
            var description = txtDescription.Text;
            Image partImage = pbCarPart.Image;

            byte[] PartPicBytes = ImageToByteArray(partImage);
            SaveParts(partID, partName, partNumber, manufacturedYear, compatibleCars, quantity, price, description, PartPicBytes);
        }

        private void SaveParts(string partID, string partName, string partNumber, string manufacturedYear, string compatibleCars, string quantity, string price, string description, byte[] partImage)
        {
            try
            {
                var query = "INSERT INTO CarParts VALUES (@PartID, @PartName, @PartNumber, @ManufacturingYear, @CompatibleCars, @Quantity, @price, @Description, @Picture)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PartID", partID);
                        cmd.Parameters.AddWithValue("@PartName", partName);
                        cmd.Parameters.AddWithValue("@PartNumber", partNumber);
                        cmd.Parameters.AddWithValue("@ManufacturingYear", manufacturedYear);
                        cmd.Parameters.AddWithValue("@CompatibleCars", compatibleCars);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Picture", partImage);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Car part saved successfully.");
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetPartData()
        {
            string query = "SELECT * FROM CarParts";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable datatTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(datatTable);
                    conn.Close();
                    carPartDGV.DataSource = datatTable;

                    // Hide the SerialNo column
                    if (carPartDGV.Columns["SerialNo"] != null)
                    {
                        carPartDGV.Columns["SerialNo"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void carPartDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carPartDGV.Rows[e.RowIndex];
                lblID.Text = row.Cells["PartID"].Value.ToString();
                txtNameofPart.Text = row.Cells["PartName"].Value.ToString();
                txtPartNumber.Text = row.Cells["PartNumber"].Value.ToString();
                txtManufacturedYear.Text = row.Cells["ManufacturingYear"].Value.ToString();
                txtCompatibleCars.Text = row.Cells["CompatibleCars"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get input values
            var partID = lblID.Text;
            var partName = txtNameofPart.Text;
            var partNumber = txtPartNumber.Text;
            var manufacturedYear = txtManufacturedYear.Text;
            var compatibleCars = txtCompatibleCars.Text;
            var quantity = txtQuantity.Text;
            var price = txtPrice.Text;
            var description = txtDescription.Text;
            Image partImage = pbCarPart.Image;

            byte[] PartPicBytes = ImageToByteArray(partImage);
            UpdateParts(partID, partName, partNumber, manufacturedYear, compatibleCars, quantity, price, description, PartPicBytes);
        }

        private void UpdateParts(string partID, string partName, string partNumber, string manufacturedYear, string compatibleCars, string quantity, string price, string description, byte[] partImage)
        {
            try
            {
                var query = "UPDATE CarParts SET PartName=@PartName, PartNumber=@PartNumber, ManufacturingYear=@ManufacturingYear, CompatibleCars=@CompatibleCars, Quantity=@Quantity, Price=@Price, Description=@Description, Picture=@Picture WHERE PartID=@PartID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PartID", partID);
                        cmd.Parameters.AddWithValue("@PartName", partName);
                        cmd.Parameters.AddWithValue("@PartNumber", partNumber);
                        cmd.Parameters.AddWithValue("@ManufacturingYear", manufacturedYear);
                        cmd.Parameters.AddWithValue("@CompatibleCars", compatibleCars);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Description", description);

                        // Set the parameter type explicitly for the image
                        SqlParameter imageParameter = new SqlParameter("@Picture", SqlDbType.VarBinary);
                        imageParameter.Value = (object)partImage ?? DBNull.Value;
                        cmd.Parameters.Add(imageParameter);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Car part updated successfully.");
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
            //Get the part id of the recored to be deleted
            var partID = lblID.Text;

            //Confirm the delete action
            var confirmResult = MessageBox.Show("Are you sure you want to delete this car part?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeletePart(partID);
            }
        }

        private void DeletePart(string partID)
        {
            try
            {
                var query = "DELETE FROM CarParts WHERE partID=@PartID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PartID", partID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Car part deleted successfully.");
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
            SearchCarData(searchQuery);
        }

        private void SearchCarData(string searchQuery)
        {
            try
            {
                var query = "SELECT * FROM CarParts WHERE PartID LIKE @SearchQuery OR PartName LIKE @SearchQuery OR PartNumber LIKE @SearchQuery OR CompatibleCars LIKE @SearchQuery";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    carPartDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
