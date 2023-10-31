namespace SalesWinApp
{
    partial class frmProducts
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
            btnBack = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtWeight = new TextBox();
            txtProName = new TextBox();
            txtCateID = new TextBox();
            txtProID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProduct = new DataGridView();
            txtSrch = new TextBox();
            btnSrchProID = new Button();
            label7 = new Label();
            btnSrchProName = new Button();
            btnSrchUnitPrice = new Button();
            btnSrchUnitsInStock = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(575, 173);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(421, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(278, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(148, 173);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 31;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(489, 117);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(274, 23);
            txtUnitsInStock.TabIndex = 30;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(489, 74);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(274, 23);
            txtUnitPrice.TabIndex = 29;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(489, 28);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(274, 23);
            txtWeight.TabIndex = 28;
            // 
            // txtProName
            // 
            txtProName.Location = new Point(121, 117);
            txtProName.Name = "txtProName";
            txtProName.ReadOnly = true;
            txtProName.Size = new Size(252, 23);
            txtProName.TabIndex = 27;
            // 
            // txtCateID
            // 
            txtCateID.Location = new Point(121, 74);
            txtCateID.Name = "txtCateID";
            txtCateID.ReadOnly = true;
            txtCateID.Size = new Size(252, 23);
            txtCateID.TabIndex = 26;
            // 
            // txtProID
            // 
            txtProID.Location = new Point(121, 28);
            txtProID.Name = "txtProID";
            txtProID.ReadOnly = true;
            txtProID.Size = new Size(252, 23);
            txtProID.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 120);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 24;
            label6.Text = "Units In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 77);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 23;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 36);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 22;
            label4.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 120);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 21;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 20;
            label2.Text = "Category ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 19;
            label1.Text = "Product ID";
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(22, 267);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(741, 239);
            dgvProduct.TabIndex = 18;
            // 
            // txtSrch
            // 
            txtSrch.Location = new Point(112, 226);
            txtSrch.Name = "txtSrch";
            txtSrch.Size = new Size(178, 23);
            txtSrch.TabIndex = 36;
            // 
            // btnSrchProID
            // 
            btnSrchProID.Location = new Point(296, 227);
            btnSrchProID.Name = "btnSrchProID";
            btnSrchProID.Size = new Size(84, 23);
            btnSrchProID.TabIndex = 44;
            btnSrchProID.Text = "Product ID";
            btnSrchProID.UseVisualStyleBackColor = true;
            btnSrchProID.Click += btnSrchProID_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 231);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 45;
            label7.Text = "Search:";
            // 
            // btnSrchProName
            // 
            btnSrchProName.Location = new Point(386, 227);
            btnSrchProName.Name = "btnSrchProName";
            btnSrchProName.Size = new Size(98, 23);
            btnSrchProName.TabIndex = 46;
            btnSrchProName.Text = "Product Name";
            btnSrchProName.UseVisualStyleBackColor = true;
            btnSrchProName.Click += btnSrchProName_Click;
            // 
            // btnSrchUnitPrice
            // 
            btnSrchUnitPrice.Location = new Point(490, 226);
            btnSrchUnitPrice.Name = "btnSrchUnitPrice";
            btnSrchUnitPrice.Size = new Size(79, 23);
            btnSrchUnitPrice.TabIndex = 47;
            btnSrchUnitPrice.Text = "Unit Price";
            btnSrchUnitPrice.UseVisualStyleBackColor = true;
            btnSrchUnitPrice.Click += btnSrchUnitPrice_Click;
            // 
            // btnSrchUnitsInStock
            // 
            btnSrchUnitsInStock.Location = new Point(575, 227);
            btnSrchUnitsInStock.Name = "btnSrchUnitsInStock";
            btnSrchUnitsInStock.Size = new Size(102, 23);
            btnSrchUnitsInStock.TabIndex = 48;
            btnSrchUnitsInStock.Text = "Units In Stock";
            btnSrchUnitsInStock.UseVisualStyleBackColor = true;
            btnSrchUnitsInStock.Click += btnSrchUnitsInStock_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(btnSrchUnitsInStock);
            Controls.Add(btnSrchUnitPrice);
            Controls.Add(btnSrchProName);
            Controls.Add(label7);
            Controls.Add(btnSrchProID);
            Controls.Add(txtSrch);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProName);
            Controls.Add(txtCateID);
            Controls.Add(txtProID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProduct);
            Name = "frmProducts";
            Text = "frmProducts";
            FormClosing += frmProducts_FormClosing;
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProName;
        private TextBox txtCateID;
        private TextBox txtProID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProduct;
        private TextBox txtSrch;
        private Button btnSrchProID;
        private Label label7;
        private Button btnSrchProName;
        private Button btnSrchUnitPrice;
        private Button btnSrchUnitsInStock;
    }
}