using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Orders_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_User));
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
            this.btnCarSearch = new System.Windows.Forms.Button();
            this.txtSearchCars = new System.Windows.Forms.TextBox();
            this.carOrdersDGV = new System.Windows.Forms.DataGridView();
            this.carPartOrdersDGV = new System.Windows.Forms.DataGridView();
            this.btnCarPartSearch = new System.Windows.Forms.Button();
            this.txtSearchCarParts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantityDis = new System.Windows.Forms.Label();
            this.lblCarModelDis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPartNameDis = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderdDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPatNameOrCarModel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartOrdersDGV)).BeginInit();
            this.SuspendLayout();
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
            this.btnCarPartOrder.Location = new System.Drawing.Point(3, 548);
            this.btnCarPartOrder.Name = "btnCarPartOrder";
            this.btnCarPartOrder.Size = new System.Drawing.Size(261, 57);
            this.btnCarPartOrder.TabIndex = 4;
            this.btnCarPartOrder.Text = "Car Part Orders";
            this.btnCarPartOrder.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOrders.Location = new System.Drawing.Point(3, 442);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(261, 57);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCarPart
            // 
            this.btnCarPart.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCarPart.FlatAppearance.BorderSize = 0;
            this.btnCarPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCarPart.Location = new System.Drawing.Point(3, 335);
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
            this.btnCar.Location = new System.Drawing.Point(3, 229);
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
            this.btnDashboard.Location = new System.Drawing.Point(3, 122);
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
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(3, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 32);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "kk";
            // 
            // btnCarSearch
            // 
            this.btnCarSearch.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.search;
            this.btnCarSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarSearch.FlatAppearance.BorderSize = 0;
            this.btnCarSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarSearch.Location = new System.Drawing.Point(1125, 61);
            this.btnCarSearch.Name = "btnCarSearch";
            this.btnCarSearch.Size = new System.Drawing.Size(36, 29);
            this.btnCarSearch.TabIndex = 113;
            this.btnCarSearch.UseVisualStyleBackColor = true;
            this.btnCarSearch.Click += new System.EventHandler(this.btnCarSearch_Click);
            // 
            // txtSearchCars
            // 
            this.txtSearchCars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCars.Location = new System.Drawing.Point(834, 61);
            this.txtSearchCars.Name = "txtSearchCars";
            this.txtSearchCars.Size = new System.Drawing.Size(294, 29);
            this.txtSearchCars.TabIndex = 114;
            // 
            // carOrdersDGV
            // 
            this.carOrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carOrdersDGV.Location = new System.Drawing.Point(294, 96);
            this.carOrdersDGV.Name = "carOrdersDGV";
            this.carOrdersDGV.Size = new System.Drawing.Size(867, 215);
            this.carOrdersDGV.TabIndex = 115;
            this.carOrdersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carOrdersDGV_CellClick);
            // 
            // carPartOrdersDGV
            // 
            this.carPartOrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carPartOrdersDGV.Location = new System.Drawing.Point(294, 352);
            this.carPartOrdersDGV.Name = "carPartOrdersDGV";
            this.carPartOrdersDGV.Size = new System.Drawing.Size(867, 215);
            this.carPartOrdersDGV.TabIndex = 116;
            this.carPartOrdersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carPartOrdersDGV_CellClick);
            // 
            // btnCarPartSearch
            // 
            this.btnCarPartSearch.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.search;
            this.btnCarPartSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarPartSearch.FlatAppearance.BorderSize = 0;
            this.btnCarPartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarPartSearch.Location = new System.Drawing.Point(1125, 317);
            this.btnCarPartSearch.Name = "btnCarPartSearch";
            this.btnCarPartSearch.Size = new System.Drawing.Size(36, 29);
            this.btnCarPartSearch.TabIndex = 117;
            this.btnCarPartSearch.UseVisualStyleBackColor = true;
            this.btnCarPartSearch.Click += new System.EventHandler(this.btnCarPartSearch_Click);
            // 
            // txtSearchCarParts
            // 
            this.txtSearchCarParts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCarParts.Location = new System.Drawing.Point(834, 317);
            this.txtSearchCarParts.Name = "txtSearchCarParts";
            this.txtSearchCarParts.Size = new System.Drawing.Size(294, 29);
            this.txtSearchCarParts.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(834, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 147;
            this.label3.Text = "Your Grand Total (LKR) :";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(1013, 570);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 21);
            this.lblGrandTotal.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 149;
            this.label1.Text = "Username :";
            // 
            // lblQuantityDis
            // 
            this.lblQuantityDis.AutoSize = true;
            this.lblQuantityDis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityDis.Location = new System.Drawing.Point(644, 606);
            this.lblQuantityDis.Name = "lblQuantityDis";
            this.lblQuantityDis.Size = new System.Drawing.Size(77, 21);
            this.lblQuantityDis.TabIndex = 150;
            this.lblQuantityDis.Text = "Quantity :";
            // 
            // lblCarModelDis
            // 
            this.lblCarModelDis.AutoSize = true;
            this.lblCarModelDis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModelDis.Location = new System.Drawing.Point(309, 648);
            this.lblCarModelDis.Name = "lblCarModelDis";
            this.lblCarModelDis.Size = new System.Drawing.Size(89, 21);
            this.lblCarModelDis.TabIndex = 151;
            this.lblCarModelDis.Text = "Car Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 152;
            this.label5.Text = "Order Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 732);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 153;
            this.label6.Text = "Orderd Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 154;
            this.label7.Text = "Price (LKR) :";
            // 
            // lblPartNameDis
            // 
            this.lblPartNameDis.AutoSize = true;
            this.lblPartNameDis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNameDis.Location = new System.Drawing.Point(308, 648);
            this.lblPartNameDis.Name = "lblPartNameDis";
            this.lblPartNameDis.Size = new System.Drawing.Size(90, 21);
            this.lblPartNameDis.TabIndex = 155;
            this.lblPartNameDis.Text = "Part Name :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(404, 606);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 21);
            this.lblUsername.TabIndex = 156;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(404, 691);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(0, 21);
            this.lblOrderStatus.TabIndex = 158;
            // 
            // lblOrderdDate
            // 
            this.lblOrderdDate.AutoSize = true;
            this.lblOrderdDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderdDate.Location = new System.Drawing.Point(404, 732);
            this.lblOrderdDate.Name = "lblOrderdDate";
            this.lblOrderdDate.Size = new System.Drawing.Size(0, 21);
            this.lblOrderdDate.TabIndex = 159;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(727, 606);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 21);
            this.lblQuantity.TabIndex = 160;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(727, 648);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 21);
            this.lblPrice.TabIndex = 161;
            // 
            // lblPatNameOrCarModel
            // 
            this.lblPatNameOrCarModel.AutoSize = true;
            this.lblPatNameOrCarModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatNameOrCarModel.Location = new System.Drawing.Point(404, 648);
            this.lblPatNameOrCarModel.Name = "lblPatNameOrCarModel";
            this.lblPatNameOrCarModel.Size = new System.Drawing.Size(0, 21);
            this.lblPatNameOrCarModel.TabIndex = 162;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(946, 727);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 47);
            this.btnDelete.TabIndex = 163;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(946, 665);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(215, 47);
            this.btnClear.TabIndex = 164;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(946, 604);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(215, 47);
            this.btnPay.TabIndex = 165;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Orders_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 786);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPatNameOrCarModel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblOrderdDate);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPartNameDis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCarModelDis);
            this.Controls.Add(this.lblQuantityDis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCarPartSearch);
            this.Controls.Add(this.txtSearchCarParts);
            this.Controls.Add(this.carPartOrdersDGV);
            this.Controls.Add(this.carOrdersDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCarSearch);
            this.Controls.Add(this.txtSearchCars);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders_User";
            this.Load += new System.EventHandler(this.Orders_User_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carOrdersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartOrdersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Button btnCarSearch;
        private TextBox txtSearchCars;
        private DataGridView carOrdersDGV;
        private DataGridView carPartOrdersDGV;
        private Button btnCarPartSearch;
        private TextBox txtSearchCarParts;
        private Label label3;
        private Label lblGrandTotal;
        private Label label1;
        private Label lblQuantityDis;
        private Label lblCarModelDis;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblPartNameDis;
        private Label lblUsername;
        private Label lblOrderStatus;
        private Label lblOrderdDate;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblPatNameOrCarModel;
        private Button btnDelete;
        private Button btnClear;
        private Button btnPay;
    }
}