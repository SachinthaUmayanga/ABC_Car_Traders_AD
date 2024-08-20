using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Car_Parts_Orders_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Parts_Orders_Admin));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCarParts = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblManufacturedYear = new System.Windows.Forms.Label();
            this.lblCompatibleCars = new System.Windows.Forms.Label();
            this.lblTotPrice = new System.Windows.Forms.Label();
            this.lblPartID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.carPartOrdersDGV = new System.Windows.Forms.DataGridView();
            this.txtOrderdQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarParts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPartOrdersDGV)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.TabIndex = 185;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnClear.TabIndex = 184;
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
            this.btnUpdate.Location = new System.Drawing.Point(820, 729);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 47);
            this.btnUpdate.TabIndex = 183;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "==== SELECT ====",
            "Pending",
            "Paid"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(886, 475);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(224, 29);
            this.cmbOrderStatus.TabIndex = 182;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(502, 434);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 21);
            this.lblUsername.TabIndex = 181;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 180;
            this.label3.Text = "Username :";
            // 
            // pbCarParts
            // 
            this.pbCarParts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbCarParts.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.image;
            this.pbCarParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCarParts.Location = new System.Drawing.Point(886, 529);
            this.pbCarParts.Name = "pbCarParts";
            this.pbCarParts.Size = new System.Drawing.Size(163, 154);
            this.pbCarParts.TabIndex = 179;
            this.pbCarParts.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(776, 478);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 21);
            this.label15.TabIndex = 178;
            this.label15.Text = "Order Status :";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartName.Location = new System.Drawing.Point(502, 517);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(0, 21);
            this.lblPartName.TabIndex = 173;
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.Location = new System.Drawing.Point(502, 560);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(0, 21);
            this.lblPartNumber.TabIndex = 172;
            // 
            // lblManufacturedYear
            // 
            this.lblManufacturedYear.AutoSize = true;
            this.lblManufacturedYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturedYear.Location = new System.Drawing.Point(502, 601);
            this.lblManufacturedYear.Name = "lblManufacturedYear";
            this.lblManufacturedYear.Size = new System.Drawing.Size(0, 21);
            this.lblManufacturedYear.TabIndex = 171;
            // 
            // lblCompatibleCars
            // 
            this.lblCompatibleCars.AutoSize = true;
            this.lblCompatibleCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompatibleCars.Location = new System.Drawing.Point(502, 645);
            this.lblCompatibleCars.Name = "lblCompatibleCars";
            this.lblCompatibleCars.Size = new System.Drawing.Size(0, 21);
            this.lblCompatibleCars.TabIndex = 170;
            // 
            // lblTotPrice
            // 
            this.lblTotPrice.AutoSize = true;
            this.lblTotPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPrice.Location = new System.Drawing.Point(886, 434);
            this.lblTotPrice.Name = "lblTotPrice";
            this.lblTotPrice.Size = new System.Drawing.Size(0, 21);
            this.lblTotPrice.TabIndex = 169;
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartID.Location = new System.Drawing.Point(502, 476);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(0, 21);
            this.lblPartID.TabIndex = 168;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(815, 529);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 21);
            this.label21.TabIndex = 167;
            this.label21.Text = "Picture :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(752, 434);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 21);
            this.label20.TabIndex = 166;
            this.label20.Text = "Total Price (LKR) :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(749, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 21);
            this.label18.TabIndex = 165;
            this.label18.Text = "Orderd Quantity :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(371, 687);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 162;
            this.label12.Text = "Unit Price (LKR) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 645);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 161;
            this.label10.Text = "Compatible Cars :";
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
            this.btnCarPartorders.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.label2.Size = new System.Drawing.Size(478, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN - MANAGE CAR PARTS ORDERS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 160;
            this.label8.Text = "Manufactured Year :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 159;
            this.label6.Text = "Part Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 158;
            this.label4.Text = "Part Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 157;
            this.label1.Text = "Part ID :";
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
            this.btnSearch.TabIndex = 155;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(867, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 156;
            // 
            // carPartOrdersDGV
            // 
            this.carPartOrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carPartOrdersDGV.Location = new System.Drawing.Point(302, 100);
            this.carPartOrdersDGV.Name = "carPartOrdersDGV";
            this.carPartOrdersDGV.Size = new System.Drawing.Size(850, 250);
            this.carPartOrdersDGV.TabIndex = 154;
            this.carPartOrdersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carPartOrdersDGV_CellClick);
            // 
            // txtOrderdQuantity
            // 
            this.txtOrderdQuantity.Location = new System.Drawing.Point(886, 389);
            this.txtOrderdQuantity.Name = "txtOrderdQuantity";
            this.txtOrderdQuantity.Size = new System.Drawing.Size(224, 29);
            this.txtOrderdQuantity.TabIndex = 186;
            this.txtOrderdQuantity.TextChanged += new System.EventHandler(this.txtOrderdQuantity_TextChanged);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(502, 687);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 21);
            this.lblUnitPrice.TabIndex = 187;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(508, 397);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 21);
            this.lblOrderID.TabIndex = 189;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 188;
            this.label7.Text = "Order ID :";
            // 
            // Car_Parts_Orders_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 788);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtOrderdQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbOrderStatus);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbCarParts);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.lblManufacturedYear);
            this.Controls.Add(this.lblCompatibleCars);
            this.Controls.Add(this.lblTotPrice);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.carPartOrdersDGV);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Car_Parts_Orders_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car_Parts_Orders_Admin";
            this.Load += new System.EventHandler(this.Car_Parts_Orders_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPartOrdersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private ComboBox cmbOrderStatus;
        private Label lblUsername;
        private Label label3;
        private PictureBox pbCarParts;
        private Label label15;
        private Label lblPrice;
        private Label lblNotes;
        private Label lblPartName;
        private Label lblPartNumber;
        private Label lblManufacturedYear;
        private Label lblCompatibleCars;
        private Label lblTotPrice;
        private Label lblPartID;
        private Label label21;
        private Label label20;
        private Label label18;
        private Label label12;
        private Label label10;
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
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView carPartOrdersDGV;
        private TextBox txtOrderdQuantity;
        private Label lblUnitPrice;
        private Label lblOrderID;
        private Label label7;
    }
}