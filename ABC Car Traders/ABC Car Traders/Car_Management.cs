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
    public partial class Car_Management : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        string placeholderText = "Search here...";
        Color placeholderColor = Color.Gray;
        Color regulerTextColor = Color.Black;

        public Car_Management()
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

        private void Car_Management_Load(object sender, EventArgs e)
        {
            cmbFuelType.SelectedIndex = 0;
            cmbTransmission.SelectedIndex = 0;
            CarIDGenarate();
            GetCarData();
        }

        private void CarIDGenarate()
        {
            try
            {
                string getData = "SELECT * FROM Cars";
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
                            string getMaxId = "SELECT MAX(SerialNo) FROM Cars";
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
                        lblCarID.Text = "CAR - " + NewSerial.ToString();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnCarPic_Click(object sender, EventArgs e)
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
                pbCar.Image = Image.FromFile(filePath);
                pbCar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ClearForm()
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            pbCar.Image = null;
            txtColor.Clear();
            txtLicensePN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtNotes.Clear();
            txtPrice.Clear();
            txtYearManufac.Clear();
            cmbFuelType.SelectedIndex = 0;
            cmbTransmission.SelectedIndex = 0;
            CarIDGenarate();
            GetCarData();
            txtMake.Focus();
            InitilizeTextbox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values
            var carID = lblCarID.Text;
            var brand = txtMake.Text;
            var model = txtModel.Text;
            var notes = txtNotes.Text;
            var price = txtPrice.Text;
            var color = txtColor.Text;
            var manufactureYear = txtYearManufac.Text;
            var licensePlateNo = txtLicensePN.Text;
            var fuelType = cmbFuelType.SelectedItem.ToString();
            var transmission = cmbTransmission.SelectedItem.ToString();
            Image carPicture = pbCar.Image;

            byte[] CarPicBytes = ImageToByteArray(carPicture);
            SaveCar(carID, brand, model, manufactureYear, transmission, color, licensePlateNo, fuelType, price, notes, CarPicBytes);
        }

        private void SaveCar(string carID, string brand, string model, string manufactureYear, string transmission, string color, 
            string licensePlateNo, string fuelType, string price, string notes, byte[] CarPicture)
        {
            try
            {
                var query = @"INSERT INTO Cars (CarID, CarBrand, CarModel, ManufacturingYear, Transmission, CarColor, LicensePlateNumber, 
                                FuelType, Price, Notes, Picture, SavedDate, Status)
                                VALUES (@CarID, @CarBrand, @CarModel, @ManufacturingYear, @Transmission, @CarColor, @LicensePlateNumber, 
                                @FuelType, @Price, @Notes, @Picture, @SavedDate, @Status)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carID);
                        cmd.Parameters.AddWithValue("@CarBrand", brand);
                        cmd.Parameters.AddWithValue("@CarModel", model);
                        cmd.Parameters.AddWithValue("@ManufacturingYear", manufactureYear);
                        cmd.Parameters.AddWithValue("@Transmission", transmission);
                        cmd.Parameters.AddWithValue("@CarColor", color);
                        cmd.Parameters.AddWithValue("@LicensePlateNumber", licensePlateNo);
                        cmd.Parameters.AddWithValue("@FuelType", fuelType);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Notes", notes);
                        cmd.Parameters.AddWithValue("@Picture", CarPicture);
                        cmd.Parameters.AddWithValue("@SavedDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Status", "Unsold");

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Car added successfully.");
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCarData()
        {
            string query = "SELECT * FROM Cars";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();
                    CarManagementDGV.DataSource = dataTable;

                    // Hide the SerialNo column
                    if (CarManagementDGV.Columns["SerialNo"] != null)
                    {
                        CarManagementDGV.Columns["SerialNo"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CarManagementDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CarManagementDGV.Rows[e.RowIndex];
                lblCarID.Text = row.Cells["CarID"].Value.ToString();
                txtMake.Text = row.Cells["CarBrand"].Value.ToString();
                txtModel.Text = row.Cells["CarModel"].Value.ToString();
                txtYearManufac.Text = row.Cells["ManufacturingYear"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtNotes.Text = row.Cells["Notes"].Value.ToString();
                txtColor.Text = row.Cells["CarColor"].Value.ToString();
                txtLicensePN.Text = row.Cells["LicensePlateNumber"].Value.ToString();

                string transmission = row.Cells["Transmission"].Value.ToString();
                cmbTransmission.SelectedItem = transmission;

                string fuelType = row.Cells["FuelType"].Value.ToString();
                cmbFuelType.SelectedItem = fuelType;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get input values
            var carID = lblCarID.Text;
            var brand = txtMake.Text;
            var model = txtModel.Text;
            var notes = txtNotes.Text;
            var price = txtPrice.Text;
            var color = txtColor.Text;
            var manufactureYear = txtYearManufac.Text;
            var licensePlateNo = txtLicensePN.Text;
            var fuelType = cmbFuelType.SelectedItem.ToString();
            var transmission = cmbTransmission.SelectedItem.ToString();
            Image carPicture = pbCar.Image;

            byte[] CarPicBytes = ImageToByteArray(carPicture);
            UpdateCar(carID, brand, model, manufactureYear, transmission, color, licensePlateNo, fuelType, price, notes, CarPicBytes);
        }

        private void UpdateCar(string carID, string brand, string model, string manufactureYear, string transmission, string color, 
            string licensePlateNo, string fuelType, string price, string notes, byte[] CarPicture)
        {
            try
            {
                var query = @"UPDATE Cars SET CarBrand=@CarBrand, CarModel=@CarModel, ManufacturingYear=@ManufacturingYear, 
                            Transmission=@Transmission, CarColor=@CarColor, LicensePlateNumber=@LicensePlateNumber, FuelType=@FuelType, 
                            Price=@Price, Notes=@Notes, Picture=@Picture WHERE CarID=@CarID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carID);
                        cmd.Parameters.AddWithValue("@CarBrand", brand);
                        cmd.Parameters.AddWithValue("@CarModel", model);
                        cmd.Parameters.AddWithValue("@ManufacturingYear", manufactureYear);
                        cmd.Parameters.AddWithValue("@Transmission", transmission);
                        cmd.Parameters.AddWithValue("@CarColor", color);
                        cmd.Parameters.AddWithValue("@LicensePlateNumber", licensePlateNo);
                        cmd.Parameters.AddWithValue("@FuelType", fuelType);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Notes", notes);

                        // Set the parameter type explicitly for the image
                        SqlParameter imageParameter = new SqlParameter("@Picture", SqlDbType.VarBinary);
                        imageParameter.Value = (object)CarPicture ?? DBNull.Value;
                        cmd.Parameters.Add(imageParameter);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Car details updated successfully.");
                        ClearForm();
                    }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the car id of the record to be deleted
            var carID = lblCarID.Text;

            //Confirm the delete action
            var confirmResult = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteCar(carID);
            }
        }

        private void DeleteCar(string carID)
        {
            try
            {
                var query = "DELETE FROM Cars WHERE CarID=@CarID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CarID", carID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Car deleted successfully.");
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
                var query = "SELECT * FROM Cars WHERE CarID LIKE @SearchQuery OR CarBrand LIKE @SearchQuery OR CarModel LIKE @SearchQuery";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);
                    conn.Close();

                    //Add data to the datagrid view
                    CarManagementDGV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
