using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Car_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Management));
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCarPartOrders = new System.Windows.Forms.Button();
            this.btnCarOrders = new System.Windows.Forms.Button();
            this.btnCarParts = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarPic = new System.Windows.Forms.Button();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLicensePN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYearManufac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.cmbTransmission = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CarManagementDGV = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarManagementDGV)).BeginInit();
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
            // btnCarPartOrders
            // 
            this.btnCarPartOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPartOrders.FlatAppearance.BorderSize = 0;
            this.btnCarPartOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarPartOrders.Location = new System.Drawing.Point(3, 503);
            this.btnCarPartOrders.Name = "btnCarPartOrders";
            this.btnCarPartOrders.Size = new System.Drawing.Size(261, 57);
            this.btnCarPartOrders.TabIndex = 5;
            this.btnCarPartOrders.Text = "Car Part Orders";
            this.btnCarPartOrders.UseVisualStyleBackColor = false;
            this.btnCarPartOrders.Click += new System.EventHandler(this.btnCarPartOrders_Click);
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
            this.btnCars.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.panel2.Controls.Add(this.btnCarPartOrders);
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
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.home_button;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(1035, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 34);
            this.btnHome.TabIndex = 24;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN - MANAGE CARS";
            // 
            // btnCarPic
            // 
            this.btnCarPic.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPic.FlatAppearance.BorderSize = 0;
            this.btnCarPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPic.Location = new System.Drawing.Point(1055, 373);
            this.btnCarPic.Name = "btnCarPic";
            this.btnCarPic.Size = new System.Drawing.Size(83, 37);
            this.btnCarPic.TabIndex = 72;
            this.btnCarPic.Text = "Browse";
            this.btnCarPic.UseVisualStyleBackColor = false;
            this.btnCarPic.Click += new System.EventHandler(this.btnCarPic_Click);
            // 
            // pbCar
            // 
            this.pbCar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbCar.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.image;
            this.pbCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCar.Location = new System.Drawing.Point(886, 373);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(163, 154);
            this.pbCar.TabIndex = 71;
            this.pbCar.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(822, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 69;
            this.label11.Text = "Notes :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(295, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 47);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(886, 131);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(252, 29);
            this.txtColor.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Colour :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(886, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 29);
            this.txtPrice.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(829, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Fuel Type :";
            // 
            // txtLicensePN
            // 
            this.txtLicensePN.Location = new System.Drawing.Point(469, 306);
            this.txtLicensePN.Name = "txtLicensePN";
            this.txtLicensePN.Size = new System.Drawing.Size(252, 29);
            this.txtLicensePN.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "License Plate Number :";
            // 
            // txtYearManufac
            // 
            this.txtYearManufac.Location = new System.Drawing.Point(469, 245);
            this.txtYearManufac.Name = "txtYearManufac";
            this.txtYearManufac.Size = new System.Drawing.Size(252, 29);
            this.txtYearManufac.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Manufacturing Year :";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(469, 186);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(252, 29);
            this.txtModel.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Transmission :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Car ID :";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(469, 84);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(37, 21);
            this.lblCarID.TabIndex = 73;
            this.lblCarID.Text = "abc";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Items.AddRange(new object[] {
            "=====SELECT=====",
            "Petrol",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.cmbFuelType.Location = new System.Drawing.Point(469, 373);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(252, 29);
            this.cmbFuelType.TabIndex = 74;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(469, 131);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(252, 29);
            this.txtMake.TabIndex = 75;
            // 
            // cmbTransmission
            // 
            this.cmbTransmission.FormattingEnabled = true;
            this.cmbTransmission.Items.AddRange(new object[] {
            "=====SELECT=====",
            "Automatic",
            "Manual"});
            this.cmbTransmission.Location = new System.Drawing.Point(886, 81);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(252, 29);
            this.cmbTransmission.TabIndex = 76;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(886, 245);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(252, 90);
            this.txtNotes.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(815, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 78;
            this.label12.Text = "Picture :";
            // 
            // CarManagementDGV
            // 
            this.CarManagementDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarManagementDGV.Location = new System.Drawing.Point(296, 543);
            this.CarManagementDGV.Name = "CarManagementDGV";
            this.CarManagementDGV.Size = new System.Drawing.Size(858, 233);
            this.CarManagementDGV.TabIndex = 79;
            this.CarManagementDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarManagementDGV_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(296, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 47);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(660, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 47);
            this.btnClear.TabIndex = 81;
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
            this.btnDelete.Location = new System.Drawing.Point(478, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 47);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(296, 508);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 83;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(545, 508);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 29);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Car_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 788);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.CarManagementDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cmbTransmission);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.lblCarID);
            this.Controls.Add(this.btnCarPic);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLicensePN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYearManufac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Car_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car_Management";
            this.Load += new System.EventHandler(this.Car_Management_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarManagementDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnReports;
        private Button btnCarPartOrders;
        private Button btnCarOrders;
        private Button btnCarParts;
        private Button btnCars;
        private Button btnCustomers;
        private Button btnDashboard;
        private Panel panel2;
        private Button btnLogout;
        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private Button btnHome;
        private Button btnCarPic;
        private PictureBox pbCar;
        private Label label11;
        private Button btnSave;
        private DateTimePicker dtpDOB;
        private TextBox txtColor;
        private Label label10;
        private TextBox txtPrice;
        private Label label9;
        private Label label8;
        private TextBox txtLicensePN;
        private Label label7;
        private TextBox txtYearManufac;
        private Label label6;
        private TextBox txtModel;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label1;
        private Label lblCarID;
        private ComboBox cmbFuelType;
        private TextBox txtMake;
        private ComboBox cmbTransmission;
        private TextBox txtNotes;
        private Label label12;
        private DataGridView CarManagementDGV;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}