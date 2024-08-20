using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Car_Orders_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Orders_Admin));
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
            this.carOrdersDGV = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblLicensePlateNumber = new System.Windows.Forms.Label();
            this.lblManufacturedYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Goldenrod;
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
            this.btnCarOrders.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.panel2.TabIndex = 8;
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
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN - MANAGE CAR ORDERS";
            // 
            // carOrdersDGV
            // 
            this.carOrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carOrdersDGV.Location = new System.Drawing.Point(302, 100);
            this.carOrdersDGV.Name = "carOrdersDGV";
            this.carOrdersDGV.Size = new System.Drawing.Size(850, 250);
            this.carOrdersDGV.TabIndex = 9;
            this.carOrdersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carOrdersDGV_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1116, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 29);
            this.btnSearch.TabIndex = 120;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(867, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 121;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(724, 502);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 21);
            this.label21.TabIndex = 132;
            this.label21.Text = "Picture :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(731, 418);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 21);
            this.label20.TabIndex = 131;
            this.label20.Text = "Notes :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(701, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 21);
            this.label18.TabIndex = 130;
            this.label18.Text = "Price(LKR) :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(387, 713);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 21);
            this.label16.TabIndex = 129;
            this.label16.Text = "Colour :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(343, 671);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 21);
            this.label14.TabIndex = 128;
            this.label14.Text = "Transmission :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(369, 629);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 127;
            this.label12.Text = "Fuel Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(283, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 21);
            this.label10.TabIndex = 126;
            this.label10.Text = "License Plate Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 125;
            this.label8.Text = "Manufactured Year :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 123;
            this.label4.Text = "Brand :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 122;
            this.label1.Text = "Car ID :";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(457, 418);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(0, 21);
            this.lblCarID.TabIndex = 133;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(457, 629);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(0, 21);
            this.lblFuelType.TabIndex = 134;
            // 
            // lblLicensePlateNumber
            // 
            this.lblLicensePlateNumber.AutoSize = true;
            this.lblLicensePlateNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicensePlateNumber.Location = new System.Drawing.Point(457, 587);
            this.lblLicensePlateNumber.Name = "lblLicensePlateNumber";
            this.lblLicensePlateNumber.Size = new System.Drawing.Size(0, 21);
            this.lblLicensePlateNumber.TabIndex = 135;
            // 
            // lblManufacturedYear
            // 
            this.lblManufacturedYear.AutoSize = true;
            this.lblManufacturedYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturedYear.Location = new System.Drawing.Point(457, 543);
            this.lblManufacturedYear.Name = "lblManufacturedYear";
            this.lblManufacturedYear.Size = new System.Drawing.Size(0, 21);
            this.lblManufacturedYear.TabIndex = 136;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(457, 502);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 21);
            this.lblModel.TabIndex = 137;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(457, 459);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 21);
            this.lblBrand.TabIndex = 138;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(795, 418);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(0, 21);
            this.lblNotes.TabIndex = 140;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(795, 376);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 21);
            this.lblPrice.TabIndex = 141;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(457, 713);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 21);
            this.lblColor.TabIndex = 142;
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(457, 671);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(0, 21);
            this.lblTransmission.TabIndex = 143;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(685, 671);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 21);
            this.label15.TabIndex = 144;
            this.label15.Text = "Order Status :";
            // 
            // pbCar
            // 
            this.pbCar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbCar.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.image;
            this.pbCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCar.Location = new System.Drawing.Point(795, 502);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(163, 154);
            this.pbCar.TabIndex = 145;
            this.pbCar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 146;
            this.label3.Text = "Username :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(457, 376);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 21);
            this.lblUsername.TabIndex = 147;
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "==== SELECT ====",
            "Pending",
            "Paid",
            "Cancelled"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(795, 668);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(163, 29);
            this.cmbOrderStatus.TabIndex = 148;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(820, 729);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 47);
            this.btnUpdate.TabIndex = 149;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(989, 729);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 47);
            this.btnClear.TabIndex = 150;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(651, 729);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 47);
            this.btnDelete.TabIndex = 151;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Car_Orders_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 788);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbOrderStatus);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturedYear);
            this.Controls.Add(this.lblLicensePlateNumber);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.carOrdersDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Car_Orders_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car_Orders_Admin";
            this.Load += new System.EventHandler(this.Car_Orders_Admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridView carOrdersDGV;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label21;
        private Label label20;
        private Label label18;
        private Label label16;
        private Label label14;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label lblCarID;
        private Label lblFuelType;
        private Label lblLicensePlateNumber;
        private Label lblManufacturedYear;
        private Label lblModel;
        private Label lblBrand;
        private Label lblNotes;
        private Label lblPrice;
        private Label lblColor;
        private Label lblTransmission;
        private Label label15;
        private PictureBox pbCar;
        private Label label3;
        private Label lblUsername;
        private ComboBox cmbOrderStatus;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
    }
}