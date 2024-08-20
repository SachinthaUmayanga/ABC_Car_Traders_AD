using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmPW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.btnProfilePic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(187, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 29);
            this.txtName.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(638, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 29);
            this.txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth :";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(187, 177);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(252, 29);
            this.txtNIC.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "NIC :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(187, 236);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(252, 29);
            this.txtNumber.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone Number :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(187, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 29);
            this.txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email :";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(187, 362);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(252, 118);
            this.txtAdd.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(638, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 29);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password :";
            // 
            // txtConfirmPW
            // 
            this.txtConfirmPW.Location = new System.Drawing.Point(638, 177);
            this.txtConfirmPW.Name = "txtConfirmPW";
            this.txtConfirmPW.Size = new System.Drawing.Size(252, 29);
            this.txtConfirmPW.TabIndex = 18;
            this.txtConfirmPW.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Confirm Password :";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(187, 122);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 29);
            this.dtpDOB.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ABC_Car_Traders.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(934, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 42);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(158, 497);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(281, 47);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSignin.FlatAppearance.BorderSize = 0;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(158, 607);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(281, 47);
            this.btnSignin.TabIndex = 22;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "User Type :";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "=====SELECT=====",
            "User"});
            this.cmbType.Location = new System.Drawing.Point(638, 233);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(252, 29);
            this.cmbType.TabIndex = 24;
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbProfile.Location = new System.Drawing.Point(638, 297);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(163, 154);
            this.pbProfile.TabIndex = 25;
            this.pbProfile.TabStop = false;
            // 
            // btnProfilePic
            // 
            this.btnProfilePic.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProfilePic.FlatAppearance.BorderSize = 0;
            this.btnProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePic.Location = new System.Drawing.Point(807, 297);
            this.btnProfilePic.Name = "btnProfilePic";
            this.btnProfilePic.Size = new System.Drawing.Size(83, 37);
            this.btnProfilePic.TabIndex = 26;
            this.btnProfilePic.Text = "Browse";
            this.btnProfilePic.UseVisualStyleBackColor = false;
            this.btnProfilePic.Click += new System.EventHandler(this.btnProfilePic_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 44);
            this.panel1.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 21);
            this.label12.TabIndex = 34;
            this.label12.Text = "Profile Picture :";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 679);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProfilePic);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtConfirmPW);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private TextBox txtNIC;
        private Label label5;
        private TextBox txtNumber;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtAdd;
        private Label label8;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtConfirmPW;
        private Label label10;
        private DateTimePicker dtpDOB;
        private Button btnExit;
        private Button btnRegister;
        private Button btnSignin;
        private Label label11;
        private ComboBox cmbType;
        private PictureBox pbProfile;
        private Button btnProfilePic;
        private Panel panel1;
        private Label label12;
    }
}