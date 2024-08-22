using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Reports_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports_Admin));
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCarPartorders = new System.Windows.Forms.Button();
            this.btnCarOrders = new System.Windows.Forms.Button();
            this.btnCarParts = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CarOrdersPanel = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CarOrders1 = new ABC_Car_Traders.CarOrders();
            this.btnCarOrdersPa = new System.Windows.Forms.Button();
            this.btnCarPartOrdersPa = new System.Windows.Forms.Button();
            this.btnPaymentPa = new System.Windows.Forms.Button();
            this.CarPartOrdersPanel = new System.Windows.Forms.Panel();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CarPartOrders1 = new ABC_Car_Traders.CarPartOrders();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.PaymentPanalView = new System.Windows.Forms.Panel();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Payment1 = new ABC_Car_Traders.Payment();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CarOrdersPanel.SuspendLayout();
            this.CarPartOrdersPanel.SuspendLayout();
            this.PaymentPanalView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReports.Location = new System.Drawing.Point(3, 586);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(261, 57);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCarPartorders
            // 
            this.btnCarPartorders.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPartorders.FlatAppearance.BorderSize = 0;
            this.btnCarPartorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartorders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarPartorders.Location = new System.Drawing.Point(3, 503);
            this.btnCarPartorders.Name = "btnCarPartorders";
            this.btnCarPartorders.Size = new System.Drawing.Size(261, 57);
            this.btnCarPartorders.TabIndex = 5;
            this.btnCarPartorders.Text = "Car Part Orders";
            this.btnCarPartorders.UseVisualStyleBackColor = false;
            this.btnCarPartorders.Click += new System.EventHandler(this.btnCarPartorders_Click);
            // 
            // btnCarOrders
            // 
            this.btnCarOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarOrders.FlatAppearance.BorderSize = 0;
            this.btnCarOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarOrders.Location = new System.Drawing.Point(3, 419);
            this.btnCarOrders.Name = "btnCarOrders";
            this.btnCarOrders.Size = new System.Drawing.Size(261, 57);
            this.btnCarOrders.TabIndex = 4;
            this.btnCarOrders.Text = "Car Orders";
            this.btnCarOrders.UseVisualStyleBackColor = false;
            this.btnCarOrders.Click += new System.EventHandler(this.btnCarOrders_Click);
            // 
            // btnCarParts
            // 
            this.btnCarParts.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarParts.FlatAppearance.BorderSize = 0;
            this.btnCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarParts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarParts.Location = new System.Drawing.Point(3, 336);
            this.btnCarParts.Name = "btnCarParts";
            this.btnCarParts.Size = new System.Drawing.Size(261, 57);
            this.btnCarParts.TabIndex = 3;
            this.btnCarParts.Text = "Car Parts";
            this.btnCarParts.UseVisualStyleBackColor = false;
            this.btnCarParts.Click += new System.EventHandler(this.btnCarParts_Click);
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCars.FlatAppearance.BorderSize = 0;
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCars.Location = new System.Drawing.Point(3, 253);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(261, 57);
            this.btnCars.TabIndex = 2;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.Location = new System.Drawing.Point(3, 169);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(261, 57);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Location = new System.Drawing.Point(3, 86);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(261, 57);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.PaymentPanel);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnCarPartorders);
            this.panel2.Controls.Add(this.btnCarOrders);
            this.panel2.Controls.Add(this.btnCarParts);
            this.panel2.Controls.Add(this.btnCars);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(-1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 750);
            this.panel2.TabIndex = 153;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.home_button;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(1035, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 34);
            this.btnHome.TabIndex = 25;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.power;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(1088, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(36, 34);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1138, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 42);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 44);
            this.panel1.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN - REPORTS";
            // 
            // CarOrdersPanel
            // 
            this.CarOrdersPanel.Controls.Add(this.crystalReportViewer1);
            this.CarOrdersPanel.Location = new System.Drawing.Point(269, 78);
            this.CarOrdersPanel.Name = "CarOrdersPanel";
            this.CarOrdersPanel.Size = new System.Drawing.Size(913, 707);
            this.CarOrdersPanel.TabIndex = 155;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CarOrders1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(913, 707);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnCarOrdersPa
            // 
            this.btnCarOrdersPa.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarOrdersPa.FlatAppearance.BorderSize = 0;
            this.btnCarOrdersPa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarOrdersPa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarOrdersPa.Location = new System.Drawing.Point(460, 46);
            this.btnCarOrdersPa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarOrdersPa.Name = "btnCarOrdersPa";
            this.btnCarOrdersPa.Size = new System.Drawing.Size(183, 27);
            this.btnCarOrdersPa.TabIndex = 113;
            this.btnCarOrdersPa.Text = "Car Orders";
            this.btnCarOrdersPa.UseVisualStyleBackColor = false;
            this.btnCarOrdersPa.Click += new System.EventHandler(this.btnCarOrdersPa_Click);
            // 
            // btnCarPartOrdersPa
            // 
            this.btnCarPartOrdersPa.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPartOrdersPa.FlatAppearance.BorderSize = 0;
            this.btnCarPartOrdersPa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartOrdersPa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarPartOrdersPa.Location = new System.Drawing.Point(643, 46);
            this.btnCarPartOrdersPa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarPartOrdersPa.Name = "btnCarPartOrdersPa";
            this.btnCarPartOrdersPa.Size = new System.Drawing.Size(183, 27);
            this.btnCarPartOrdersPa.TabIndex = 156;
            this.btnCarPartOrdersPa.Text = "Car Part Orders";
            this.btnCarPartOrdersPa.UseVisualStyleBackColor = false;
            this.btnCarPartOrdersPa.Click += new System.EventHandler(this.btnCarPartOrdersPa_Click);
            // 
            // btnPaymentPa
            // 
            this.btnPaymentPa.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPaymentPa.FlatAppearance.BorderSize = 0;
            this.btnPaymentPa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentPa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentPa.Location = new System.Drawing.Point(826, 46);
            this.btnPaymentPa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPaymentPa.Name = "btnPaymentPa";
            this.btnPaymentPa.Size = new System.Drawing.Size(183, 27);
            this.btnPaymentPa.TabIndex = 157;
            this.btnPaymentPa.Text = "Payments";
            this.btnPaymentPa.UseVisualStyleBackColor = false;
            this.btnPaymentPa.Click += new System.EventHandler(this.btnPaymentPa_Click);
            // 
            // CarPartOrdersPanel
            // 
            this.CarPartOrdersPanel.Controls.Add(this.PaymentPanalView);
            this.CarPartOrdersPanel.Controls.Add(this.crystalReportViewer2);
            this.CarPartOrdersPanel.Location = new System.Drawing.Point(269, 78);
            this.CarPartOrdersPanel.Name = "CarPartOrdersPanel";
            this.CarPartOrdersPanel.Size = new System.Drawing.Size(915, 704);
            this.CarPartOrdersPanel.TabIndex = 1;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.CarPartOrders1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(915, 704);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.Location = new System.Drawing.Point(270, 38);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(915, 707);
            this.PaymentPanel.TabIndex = 1;
            // 
            // PaymentPanalView
            // 
            this.PaymentPanalView.Controls.Add(this.crystalReportViewer3);
            this.PaymentPanalView.Location = new System.Drawing.Point(0, 1);
            this.PaymentPanalView.Name = "PaymentPanalView";
            this.PaymentPanalView.Size = new System.Drawing.Size(915, 706);
            this.PaymentPanalView.TabIndex = 26;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.Payment1;
            this.crystalReportViewer3.Size = new System.Drawing.Size(915, 706);
            this.crystalReportViewer3.TabIndex = 0;
            // 
            // Reports_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 788);
            this.Controls.Add(this.CarPartOrdersPanel);
            this.Controls.Add(this.btnPaymentPa);
            this.Controls.Add(this.btnCarPartOrdersPa);
            this.Controls.Add(this.btnCarOrdersPa);
            this.Controls.Add(this.CarOrdersPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports_Admin";
            this.Load += new System.EventHandler(this.Reports_Admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CarOrdersPanel.ResumeLayout(false);
            this.CarPartOrdersPanel.ResumeLayout(false);
            this.PaymentPanalView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnReports;
        private Button btnCarPartorders;
        private Button btnCarOrders;
        private Button btnCarParts;
        private Button btnCars;
        private Button btnCustomers;
        private Button btnDashboard;
        private Panel panel2;
        private Button btnHome;
        private Button btnLogout;
        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private Panel CarOrdersPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CarOrders CarOrders1;
        private Button btnCarOrdersPa;
        private Button btnCarPartOrdersPa;
        private Button btnPaymentPa;
        private Panel CarPartOrdersPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CarPartOrders CarPartOrders1;
        private Panel PaymentPanel;
        private Panel PaymentPanalView;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private Payment Payment1;
    }
}