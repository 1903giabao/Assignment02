namespace SalesWinApp
{
    partial class frmOrderDetailsInfo
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
            label5 = new Label();
            label4 = new Label();
            txtUnitPrice = new TextBox();
            txtOrderID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            cboProID = new ComboBox();
            SuspendLayout();
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(122, 215);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(252, 23);
            txtDiscount.TabIndex = 62;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(122, 174);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(252, 23);
            txtQuantity.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 218);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 59;
            label5.Text = "Discount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 177);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 58;
            label4.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(122, 135);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(252, 23);
            txtUnitPrice.TabIndex = 57;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(122, 58);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(252, 23);
            txtOrderID.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 138);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 54;
            label3.Text = "Unit Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 53;
            label2.Text = "Product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 52;
            label1.Text = "Order ID";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(243, 290);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 29);
            btnClose.TabIndex = 51;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(88, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 29);
            btnSave.TabIndex = 50;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboProID
            // 
            cboProID.FormattingEnabled = true;
            cboProID.Location = new Point(122, 96);
            cboProID.Name = "cboProID";
            cboProID.Size = new Size(252, 23);
            cboProID.TabIndex = 63;
            cboProID.SelectedIndexChanged += cboProID_SelectedIndexChanged;
            // 
            // frmOrderDetailsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 370);
            Controls.Add(cboProID);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtOrderID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmOrderDetailsInfo";
            Text = "frmOrderDetailsInfo";
            Load += frmOrderDetailsInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private Label label5;
        private Label label4;
        private TextBox txtUnitPrice;
        private TextBox txtOrderID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cboProID;
    }
}