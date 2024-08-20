using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Customer_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Management));
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCarPartsOrders = new System.Windows.Forms.Button();
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
            this.btnProfilePic = new System.Windows.Forms.Button();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblUT = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtConfirmPW = new System.Windows.Forms.TextBox();
            this.lblCFPW = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
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
            // btnCarPartsOrders
            // 
            this.btnCarPartsOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPartsOrders.FlatAppearance.BorderSize = 0;
            this.btnCarPartsOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartsOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarPartsOrders.Location = new System.Drawing.Point(3, 503);
            this.btnCarPartsOrders.Name = "btnCarPartsOrders";
            this.btnCarPartsOrders.Size = new System.Drawing.Size(261, 57);
            this.btnCarPartsOrders.TabIndex = 5;
            this.btnCarPartsOrders.Text = "Car Parts Orders";
            this.btnCarPartsOrders.UseVisualStyleBackColor = false;
            this.btnCarPartsOrders.Click += new System.EventHandler(this.btnCarPartsOrders_Click);
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
            this.btnCustomers.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.panel2.Controls.Add(this.btnCarPartsOrders);
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
            this.btnHome.TabIndex = 25;
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
            this.label2.Size = new System.Drawing.Size(388, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN - MANAGE CUSTOMERS";
            // 
            // btnProfilePic
            // 
            this.btnProfilePic.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProfilePic.FlatAppearance.BorderSize = 0;
            this.btnProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePic.Location = new System.Drawing.Point(1040, 343);
            this.btnProfilePic.Name = "btnProfilePic";
            this.btnProfilePic.Size = new System.Drawing.Size(83, 37);
            this.btnProfilePic.TabIndex = 49;
            this.btnProfilePic.Text = "Browse";
            this.btnProfilePic.UseVisualStyleBackColor = false;
            this.btnProfilePic.Click += new System.EventHandler(this.btnProfilePic_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbProfile.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.image;
            this.pbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProfile.Location = new System.Drawing.Point(871, 343);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(163, 154);
            this.pbProfile.TabIndex = 48;
            this.pbProfile.TabStop = false;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "=====SELECT=====",
            "User"});
            this.cmbType.Location = new System.Drawing.Point(871, 279);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(252, 29);
            this.cmbType.TabIndex = 47;
            // 
            // lblUT
            // 
            this.lblUT.AutoSize = true;
            this.lblUT.Location = new System.Drawing.Point(780, 282);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(85, 21);
            this.lblUT.TabIndex = 46;
            this.lblUT.Text = "User Type :";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(294, 440);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(163, 47);
            this.btnRegister.TabIndex = 45;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(423, 123);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 29);
            this.dtpDOB.TabIndex = 44;
            // 
            // txtConfirmPW
            // 
            this.txtConfirmPW.Location = new System.Drawing.Point(871, 223);
            this.txtConfirmPW.Name = "txtConfirmPW";
            this.txtConfirmPW.Size = new System.Drawing.Size(252, 29);
            this.txtConfirmPW.TabIndex = 43;
            this.txtConfirmPW.UseSystemPasswordChar = true;
            // 
            // lblCFPW
            // 
            this.lblCFPW.AutoSize = true;
            this.lblCFPW.Location = new System.Drawing.Point(721, 226);
            this.lblCFPW.Name = "lblCFPW";
            this.lblCFPW.Size = new System.Drawing.Size(144, 21);
            this.lblCFPW.TabIndex = 42;
            this.lblCFPW.Text = "Confirm Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(871, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 29);
            this.txtPassword.TabIndex = 41;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(782, 171);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(83, 21);
            this.lblPW.TabIndex = 40;
            this.lblPW.Text = "Password :";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(423, 282);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(252, 118);
            this.txtAdd.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Address :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(871, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 29);
            this.txtEmail.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(810, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Email :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(423, 237);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(252, 29);
            this.txtNumber.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone Number :";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(423, 178);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(252, 29);
            this.txtNIC.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "NIC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date of Birth :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(871, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 29);
            this.txtUsername.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Username :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(423, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 29);
            this.txtName.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Full Name :";
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Location = new System.Drawing.Point(294, 543);
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.Size = new System.Drawing.Size(858, 233);
            this.CustomerDGV.TabIndex = 50;
            this.CustomerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(751, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "Profile Picture :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(676, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 47);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(294, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 47);
            this.btnUpdate.TabIndex = 82;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(484, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 47);
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(543, 509);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 29);
            this.btnSearch.TabIndex = 120;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(294, 509);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 121;
            // 
            // Customer_Management
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CustomerDGV);
            this.Controls.Add(this.btnProfilePic);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblUT);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtConfirmPW);
            this.Controls.Add(this.lblCFPW);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Management";
            this.Load += new System.EventHandler(this.Customer_Management_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnReports;
        private Button btnCarPartsOrders;
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
        private Button btnProfilePic;
        private PictureBox pbProfile;
        private ComboBox cmbType;
        private Label lblUT;
        private Button btnRegister;
        private DateTimePicker dtpDOB;
        private TextBox txtConfirmPW;
        private Label lblCFPW;
        private TextBox txtPassword;
        private Label lblPW;
        private TextBox txtAdd;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtNumber;
        private Label label6;
        private TextBox txtNIC;
        private Label label5;
        private Label label4;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtName;
        private Label label1;
        private DataGridView CustomerDGV;
        private Button btnHome;
        private Label label12;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}