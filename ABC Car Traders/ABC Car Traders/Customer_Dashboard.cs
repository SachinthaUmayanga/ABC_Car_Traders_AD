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
    public partial class Customer_Dashboard : Form
    {

        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";
        private string _username;

        public Customer_Dashboard(string username)
        {
            InitializeComponent();
            _username = username;
            lblUser.Text = "Welcome, " + _username;
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

        private int GetMyCarPartOrdersCount(string username)
        {
            int myCarPartOrdersCount = 0;
            string query = "SELECT COUNT(*) FROM CarPartOrders WHERE username = @username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                try
                {
                    conn.Open();
                    myCarPartOrdersCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return myCarPartOrdersCount;
        }

        private int GetMyCarOrdersCount(string username)
        {
            int myCarOrdersCount = 0;
            string query = "SELECT COUNT(*) FROM CarOrders WHERE username = @username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                try
                {
                    conn.Open();
                    myCarOrdersCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return myCarOrdersCount;
        }

        private int GetCarPartCount()
        {
            int carPartCount = 0;
            string query = "SELECT COUNT(*) FROM CarParts";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    carPartCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return carPartCount;
        }

        private int GetAvailableCarCount()
        {
            int availableCarCount = 0;
            string query = "SELECT COUNT(*) FROM Cars WHERE Status != 'Sold'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    availableCarCount = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return availableCarCount;
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            //Get available car count
            int availableCarCount = GetAvailableCarCount();
            lblCars.Text = $"{availableCarCount}";

            //Get carpart count
            int carPartCount = GetCarPartCount();
            lblCarParts.Text = $"{carPartCount}";

            //Get user car order count
            int myCarOrdersCount = GetMyCarOrdersCount(_username);
            lblCarOrders.Text = $"{myCarOrdersCount}";

            //Get user car part orders
            int myCarPartOrdersCount = GetMyCarPartOrdersCount(_username);
            lblCarPartOrders.Text = $"{myCarPartOrdersCount}";
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
    }
}
