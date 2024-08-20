using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Car_Parts_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Parts_User));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pbCarPart = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCompatibleCars = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblManufacturedYear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCarPartOrder = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCarPart = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.CarPartsDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(996, 718);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 47);
            this.btnClear.TabIndex = 137;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(802, 718);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(163, 47);
            this.btnOrder.TabIndex = 112;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pbCarPart
            // 
            this.pbCarPart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbCarPart.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.image;
            this.pbCarPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCarPart.Location = new System.Drawing.Point(980, 453);
            this.pbCarPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbCarPart.Name = "pbCarPart";
            this.pbCarPart.Size = new System.Drawing.Size(163, 153);
            this.pbCarPart.TabIndex = 136;
            this.pbCarPart.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(899, 453);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 21);
            this.label21.TabIndex = 135;
            this.label21.Text = "Picture :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(980, 389);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 21);
            this.lblDescription.TabIndex = 130;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(869, 389);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 21);
            this.label16.TabIndex = 129;
            this.label16.Text = "Description :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(980, 347);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 21);
            this.lblUnitPrice.TabIndex = 128;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(844, 347);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 21);
            this.label14.TabIndex = 127;
            this.label14.Text = "Unit Price(LKR) :";
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQuantity.Location = new System.Drawing.Point(980, 303);
            this.lblAvailableQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(0, 21);
            this.lblAvailableQuantity.TabIndex = 126;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(821, 303);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 21);
            this.label12.TabIndex = 125;
            this.label12.Text = "Available Quantity :";
            // 
            // lblCompatibleCars
            // 
            this.lblCompatibleCars.AutoSize = true;
            this.lblCompatibleCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompatibleCars.Location = new System.Drawing.Point(980, 263);
            this.lblCompatibleCars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompatibleCars.Name = "lblCompatibleCars";
            this.lblCompatibleCars.Size = new System.Drawing.Size(0, 21);
            this.lblCompatibleCars.TabIndex = 124;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(833, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 123;
            this.label10.Text = "Compatible Cars :";
            // 
            // lblManufacturedYear
            // 
            this.lblManufacturedYear.AutoSize = true;
            this.lblManufacturedYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturedYear.Location = new System.Drawing.Point(980, 222);
            this.lblManufacturedYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturedYear.Name = "lblManufacturedYear";
            this.lblManufacturedYear.Size = new System.Drawing.Size(0, 21);
            this.lblManufacturedYear.TabIndex = 122;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(817, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 121;
            this.label8.Text = "Manufactured Year :";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.Location = new System.Drawing.Point(980, 179);
            this.lblPartNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(0, 21);
            this.lblPartNumber.TabIndex = 120;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.btnCarPartOrder);
            this.panel2.Controls.Add(this.btnOrders);
            this.panel2.Controls.Add(this.btnCarPart);
            this.panel2.Controls.Add(this.btnCar);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(-1, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 750);
            this.panel2.TabIndex = 110;
            // 
            // btnCarPartOrder
            // 
            this.btnCarPartOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPartOrder.FlatAppearance.BorderSize = 0;
            this.btnCarPartOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarPartOrder.Location = new System.Drawing.Point(4, 548);
            this.btnCarPartOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarPartOrder.Name = "btnCarPartOrder";
            this.btnCarPartOrder.Size = new System.Drawing.Size(261, 57);
            this.btnCarPartOrder.TabIndex = 4;
            this.btnCarPartOrder.Text = "Car Part Orders";
            this.btnCarPartOrder.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOrders.Location = new System.Drawing.Point(4, 442);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(261, 57);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCarPart
            // 
            this.btnCarPart.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCarPart.FlatAppearance.BorderSize = 0;
            this.btnCarPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarPart.Location = new System.Drawing.Point(4, 335);
            this.btnCarPart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarPart.Name = "btnCarPart";
            this.btnCarPart.Size = new System.Drawing.Size(261, 57);
            this.btnCarPart.TabIndex = 2;
            this.btnCarPart.Text = "Car Parts";
            this.btnCarPart.UseVisualStyleBackColor = false;
            this.btnCarPart.Click += new System.EventHandler(this.btnCarPart_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCar.Location = new System.Drawing.Point(4, 228);
            this.btnCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(261, 57);
            this.btnCar.TabIndex = 1;
            this.btnCar.Text = "Cars";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Location = new System.Drawing.Point(4, 122);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(261, 57);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 44);
            this.panel1.TabIndex = 109;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.home_button;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(1035, 5);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 33);
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
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(36, 33);
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
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 42);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(4, 6);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 32);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "kk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(858, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 117;
            this.label4.Text = "Name of Part :";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartName.Location = new System.Drawing.Point(980, 137);
            this.lblPartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(0, 21);
            this.lblPartName.TabIndex = 118;
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartID.Location = new System.Drawing.Point(980, 95);
            this.lblPartID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(0, 21);
            this.lblPartID.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(902, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 115;
            this.label1.Text = "Part ID :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(740, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 29);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(449, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 29);
            this.txtSearch.TabIndex = 114;
            // 
            // CarPartsDGV
            // 
            this.CarPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarPartsDGV.Location = new System.Drawing.Point(288, 95);
            this.CarPartsDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CarPartsDGV.Name = "CarPartsDGV";
            this.CarPartsDGV.Size = new System.Drawing.Size(486, 670);
            this.CarPartsDGV.TabIndex = 111;
            this.CarPartsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarPartsDGV_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(859, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 119;
            this.label6.Text = "Part Number :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(980, 621);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(163, 29);
            this.txtQuantity.TabIndex = 138;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(888, 624);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 139;
            this.label2.Text = "Quantity :";
            // 
            // lblTotPrice
            // 
            this.lblTotPrice.AutoSize = true;
            this.lblTotPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPrice.Location = new System.Drawing.Point(980, 663);
            this.lblTotPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotPrice.Name = "lblTotPrice";
            this.lblTotPrice.Size = new System.Drawing.Size(0, 21);
            this.lblTotPrice.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(841, 663);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 140;
            this.label5.Text = "Total Price(LKR) :";
            // 
            // Car_Parts_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 786);
            this.Controls.Add(this.lblTotPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pbCarPart);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblAvailableQuantity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCompatibleCars);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblManufacturedYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.CarPartsDGV);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Car_Parts_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car_Parts_User";
            this.Load += new System.EventHandler(this.Car_Parts_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClear;
        private Button btnOrder;
        private PictureBox pbCarPart;
        private Label label21;
        private Label lblNotes;
        private Label label20;
        private Label lblPrice;
        private Label label18;
        private Label lblDescription;
        private Label label16;
        private Label lblUnitPrice;
        private Label label14;
        private Label lblAvailableQuantity;
        private Label label12;
        private Label lblCompatibleCars;
        private Label label10;
        private Label lblManufacturedYear;
        private Label label8;
        private Label lblPartNumber;
        private Panel panel2;
        private Button btnCarPartOrder;
        private Button btnOrders;
        private Button btnCarPart;
        private Button btnCar;
        private Button btnDashboard;
        private Panel panel1;
        private Button btnHome;
        private Button btnLogout;
        private Button btnExit;
        private Label lblUser;
        private Label label4;
        private Label lblPartName;
        private Label lblPartID;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView CarPartsDGV;
        private Label label6;
        private TextBox txtQuantity;
        private Label label2;
        private Label lblTotPrice;
        private Label label5;
    }
}