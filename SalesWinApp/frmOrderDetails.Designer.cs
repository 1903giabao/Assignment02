namespace SalesWinApp
{
    partial class frmOrderDetails
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
            txtDiscount = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProID = new TextBox();
            txtOrderID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dgvOrderDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(487, 117);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(274, 23);
            txtDiscount.TabIndex = 42;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(487, 74);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(274, 23);
            txtQuantity.TabIndex = 41;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(487, 28);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(274, 23);
            txtUnitPrice.TabIndex = 40;
            // 
            // txtProID
            // 
            txtProID.Location = new Point(118, 94);
            txtProID.Name = "txtProID";
            txtProID.ReadOnly = true;
            txtProID.Size = new Size(252, 23);
            txtProID.TabIndex = 38;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(118, 48);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(252, 23);
            txtOrderID.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 120);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 36;
            label6.Text = "Discount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 77);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 35;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 36);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 34;
            label4.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 32;
            label2.Text = "Product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 31;
            label1.Text = "Order ID";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(549, 164);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 46;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(395, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(252, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(122, 164);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 43;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(29, 199);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowTemplate.Height = 25;
            dgvOrderDetail.Size = new Size(741, 239);
            dgvOrderDetail.TabIndex = 47;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOrderDetail);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProID);
            Controls.Add(txtOrderID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrderDetails";
            Text = "frmOrderDetails";
            FormClosing += frmOrderDetails_FormClosing;
            Load += frmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProID;
        private TextBox txtOrderID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dgvOrderDetail;
    }
}