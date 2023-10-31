namespace SalesWinApp
{
    partial class frmProductDetails
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
            btnClose = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(142, 262);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(252, 23);
            txtUnitsInStock.TabIndex = 42;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(142, 219);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(252, 23);
            txtUnitPrice.TabIndex = 41;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(142, 173);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(252, 23);
            txtWeight.TabIndex = 40;
            // 
            // txtProName
            // 
            txtProName.Location = new Point(142, 132);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(252, 23);
            txtProName.TabIndex = 39;
            // 
            // txtCateID
            // 
            txtCateID.Location = new Point(142, 89);
            txtCateID.Name = "txtCateID";
            txtCateID.Size = new Size(252, 23);
            txtCateID.TabIndex = 38;
            // 
            // txtProID
            // 
            txtProID.Location = new Point(142, 43);
            txtProID.Name = "txtProID";
            txtProID.Size = new Size(252, 23);
            txtProID.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 265);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 36;
            label6.Text = "Units In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 222);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 35;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 181);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 34;
            label4.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 135);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 33;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 92);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 32;
            label2.Text = "Category ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 31;
            label1.Text = "Product ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(260, 321);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 29);
            btnClose.TabIndex = 44;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(105, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 29);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 382);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
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
            Name = "frmProductDetails";
            Text = "frmProductDetails";
            Load += frmProductDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button btnClose;
        private Button btnSave;
    }
}