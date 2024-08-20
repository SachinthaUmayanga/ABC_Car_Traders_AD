using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Manage_Car_Parts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Car_Parts));
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtManufacturedYear = new System.Windows.Forms.TextBox();
            this.txtCompatibleCars = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtNameofPart = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbCarPart = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.carPartDGV = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartDGV)).BeginInit();
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
            this.btnCarParts.BackColor = System.Drawing.Color.DarkGoldenrod;
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
            this.panel2.Controls.Add(this.btnCarPartOrders);
            this.panel2.Controls.Add(this.btnCarOrders);
            this.panel2.Controls.Add(this.btnCarParts);
            this.panel2.Controls.Add(this.btnCars);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(-1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 750);
            this.panel2.TabIndex = 10;
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
            this.panel1.TabIndex = 9;
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
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN - MANAGE CAR PARTS";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(664, 431);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 47);
            this.btnClear.TabIndex = 107;
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
            this.btnUpdate.Location = new System.Drawing.Point(299, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 47);
            this.btnUpdate.TabIndex = 106;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(809, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 105;
            this.label12.Text = "Picture :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(778, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 97;
            this.label11.Text = "Description :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(299, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 47);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(797, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 94;
            this.label10.Text = "Quantity :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(880, 131);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 29);
            this.txtPrice.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 92;
            this.label9.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 89;
            this.label7.Text = "Compatible Cars :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 87;
            this.label6.Text = "Manufactured Year :";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(472, 186);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(252, 29);
            this.txtPartNumber.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "Part Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "Name of Part :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "ID :";
            // 
            // txtManufacturedYear
            // 
            this.txtManufacturedYear.Location = new System.Drawing.Point(472, 245);
            this.txtManufacturedYear.Name = "txtManufacturedYear";
            this.txtManufacturedYear.Size = new System.Drawing.Size(252, 29);
            this.txtManufacturedYear.TabIndex = 108;
            // 
            // txtCompatibleCars
            // 
            this.txtCompatibleCars.Location = new System.Drawing.Point(472, 309);
            this.txtCompatibleCars.Multiline = true;
            this.txtCompatibleCars.Name = "txtCompatibleCars";
            this.txtCompatibleCars.Size = new System.Drawing.Size(252, 98);
            this.txtCompatibleCars.TabIndex = 109;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(880, 81);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(252, 29);
            this.txtQuantity.TabIndex = 110;
            // 
            // txtNameofPart
            // 
            this.txtNameofPart.Location = new System.Drawing.Point(472, 131);
            this.txtNameofPart.Name = "txtNameofPart";
            this.txtNameofPart.Size = new System.Drawing.Size(252, 29);
            this.txtNameofPart.TabIndex = 111;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(880, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(252, 143);
            this.txtDescription.TabIndex = 112;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(1049, 368);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 37);
            this.btnBrowse.TabIndex = 114;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbCarPart
            // 
            this.pbCarPart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbCarPart.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.image;
            this.pbCarPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCarPart.Location = new System.Drawing.Point(880, 368);
            this.pbCarPart.Name = "pbCarPart";
            this.pbCarPart.Size = new System.Drawing.Size(163, 154);
            this.pbCarPart.TabIndex = 113;
            this.pbCarPart.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(472, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 21);
            this.lblID.TabIndex = 115;
            this.lblID.Text = "abc";
            // 
            // carPartDGV
            // 
            this.carPartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carPartDGV.Location = new System.Drawing.Point(298, 543);
            this.carPartDGV.Name = "carPartDGV";
            this.carPartDGV.Size = new System.Drawing.Size(852, 233);
            this.carPartDGV.TabIndex = 116;
            this.carPartDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carPartDGV_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(482, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 47);
            this.btnDelete.TabIndex = 117;
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
            this.btnSearch.Location = new System.Drawing.Point(547, 508);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 29);
            this.btnSearch.TabIndex = 118;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(298, 508);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 119;
            // 
            // Manage_Car_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 788);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.carPartDGV);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbCarPart);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNameofPart);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCompatibleCars);
            this.Controls.Add(this.txtManufacturedYear);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manage_Car_Parts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Car_Parts";
            this.Load += new System.EventHandler(this.Manage_Car_Parts_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartDGV)).EndInit();
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
        private Button btnHome;
        private Label label2;
        private Button btnClear;
        private Button btnUpdate;
        private Label label12;
        private TextBox txtNotes;
        private ComboBox cmbTransmission;
        private TextBox txtMake;
        private Label lblCarID;
        private Button btnBrowse;
        private PictureBox pbCarPart;
        private Label label11;
        private Button btnSave;
        private TextBox txtColor;
        private Label label10;
        private TextBox txtPrice;
        private Label label9;
        private TextBox txtLicensePN;
        private Label label7;
        private TextBox txtYearManufac;
        private Label label6;
        private TextBox txtPartNumber;
        private Label label5;
        private Label label4;
        private Label lblID;
        private Label label1;
        private TextBox txtManufacturedYear;
        private TextBox txtCompatibleCars;
        private TextBox txtQuantity;
        private TextBox txtNameofPart;
        private TextBox txtDescription;
        private DataGridView carPartDGV;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}