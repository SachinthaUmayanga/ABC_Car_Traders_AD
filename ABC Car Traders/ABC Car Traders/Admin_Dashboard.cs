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
    public partial class Admin_Dashboard : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        public Admin_Dashboard()
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

        private int GetUserCount()
        {
            int userCount = 0;
            string query = "SELECT COUNT(*) FROM Users WHERE type != 'Admin'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    userCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return userCount;
        }

        private int GetCarCount()
        {
            int carCount = 0;
            string query = "SELECT COUNT(*) FROM Cars WHERE Status != 'Sold'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    carCount = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return carCount;
        }

        private int GetPartCount()
        {
            int partCount = 0;
            string query = "SELECT COUNT(*) FROM CarParts WHERE Quantity > 0";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    partCount = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return partCount;
        }

        private int GetCarOrdersCount()
        {
            int carOrdersCount = 0;
            string query = "SELECT COUNT(*) FROM CarOrders WHERE DeletedDate is NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    carOrdersCount = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return carOrdersCount;
        }

        private int GetCarPartOrdersCount()
        {
            int carPartOrcersCount = 0;
            string query = "SELECT COUNT(*) FROM CarPartOrders WHERE DeletedDate is NULL";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    carPartOrcersCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return carPartOrcersCount;
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            //Get user count and display it
            int userCount = GetUserCount();
            lblCustomers.Text = $"{userCount}";

            //Get car count and display it
            int carCount = GetCarCount();
            lblCars.Text = $"{carCount}";

            //Get parts count and display it
            int partCount = GetPartCount();
            lblCarParts.Text = $"{partCount}";

            //Get car orders count and display it
            int carOrdersCount = GetCarOrdersCount();
            lblCarOrders.Text = $"{carOrdersCount}";

            //Get car part orders count and display it
            int carpartOrderCount = GetCarPartOrdersCount();
            lblCarPartOrders.Text = $"{carpartOrderCount}";
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
    }
}
