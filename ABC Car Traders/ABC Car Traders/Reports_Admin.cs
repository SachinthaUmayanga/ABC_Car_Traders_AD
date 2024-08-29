using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Reports_Admin : Form
    {
        String connectionString = "Server=DESKTOP-42GGUK9\\MSSQLSERVER01;Database=CarTraders;Trusted_Connection=True;";

        public Reports_Admin()
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

        private void RP11_InitReport(object sender, EventArgs e)
        {

        }

        private void btnCarOrdersPa_Click(object sender, EventArgs e)
        {
            //show carorders panel and hide others
            cRCarOrders.Visible = true;
            crCarPartOrders.Visible = false;
            crPayment.Visible = false;

            //Change button colors
            btnCarOrdersPa.BackColor = Color.DarkGoldenrod;
            btnCarPartOrdersPa.BackColor = Color.Goldenrod;
            btnPaymentPa.BackColor = Color.Goldenrod;
        }

        private void Reports_Admin_Load(object sender, EventArgs e)
        {
            //Initially show carorderpanel and hide other panels
            cRCarOrders.Visible = true;
            crCarPartOrders.Visible = false;
            crPayment.Visible = false;

            //Set defalt colors for buttons
            btnCarOrdersPa.BackColor = Color.DarkGoldenrod;
            btnCarPartOrdersPa.BackColor = Color.Goldenrod;
            btnPaymentPa.BackColor = Color.Goldenrod;
        }

        private void btnCarPartOrdersPa_Click(object sender, EventArgs e)
        {
            //show carpartorders panel and hide others
            cRCarOrders.Visible = false;
            crCarPartOrders.Visible = true;
            crPayment.Visible = false;

            //Change button colors
            btnCarOrdersPa.BackColor = Color.Goldenrod;
            btnCarPartOrdersPa.BackColor = Color.DarkGoldenrod;
            btnPaymentPa.BackColor = Color.Goldenrod;
        }

        private void btnPaymentPa_Click(object sender, EventArgs e)
        {
            //show payment panel and hide others
            cRCarOrders.Visible = false;
            crCarPartOrders.Visible = false;
            crPayment.Visible = true;

            //Change button colors
            btnCarOrdersPa.BackColor = Color.Goldenrod;
            btnCarPartOrdersPa.BackColor = Color.Goldenrod;
            btnPaymentPa.BackColor = Color.DarkGoldenrod;
        }

    }
}
