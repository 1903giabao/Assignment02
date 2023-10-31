namespace SalesWinApp
{
    partial class frmMemberDetails
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
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtMemID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtCompany = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(118, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 23);
            txtPassword.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtMemID
            // 
            txtMemID.Location = new Point(118, 51);
            txtMemID.Name = "txtMemID";
            txtMemID.Size = new Size(252, 23);
            txtMemID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 10;
            label1.Text = "Member ID";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(118, 270);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(252, 23);
            txtCountry.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(118, 227);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(252, 23);
            txtCity.TabIndex = 20;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(118, 184);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(252, 23);
            txtCompany.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 273);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 18;
            label6.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 230);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 17;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 187);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 16;
            label4.Text = "Company";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(99, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(254, 334);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 29);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 400);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberDetails";
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtMemID;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompany;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnSave;
        private Button btnClose;
    }
}