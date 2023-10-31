namespace SalesWinApp
{
    partial class frmMember
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
            dgvMember = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(24, 199);
            dgvMember.Name = "dgvMember";
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(741, 239);
            dgvMember.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 120);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 36);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 77);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 5;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 120);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 6;
            label6.Text = "Country";
            // 
            // txtMemID
            // 
            txtMemID.Location = new Point(111, 28);
            txtMemID.Name = "txtMemID";
            txtMemID.ReadOnly = true;
            txtMemID.Size = new Size(252, 23);
            txtMemID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(252, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(111, 117);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(252, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(491, 28);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(274, 23);
            txtCompany.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(491, 74);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(274, 23);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(491, 117);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(274, 23);
            txtCountry.TabIndex = 12;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(127, 159);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(257, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(554, 159);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompany);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMember);
            Name = "frmMember";
            Text = "frmMember";
            FormClosing += frmMember_FormClosing;
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
    }
}