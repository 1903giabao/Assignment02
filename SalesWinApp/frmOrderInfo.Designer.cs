namespace SalesWinApp
{
    partial class frmOrderInfo
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
            btnClose = new Button();
            btnSave = new Button();
            txtOrderDate = new TextBox();
            txtMemID = new TextBox();
            txtOrderID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFreight = new TextBox();
            txtShippedDate = new TextBox();
            txtRequiredDate = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(242, 308);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 29);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(87, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 29);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(123, 120);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(252, 23);
            txtOrderDate.TabIndex = 43;
            // 
            // txtMemID
            // 
            txtMemID.Location = new Point(123, 81);
            txtMemID.Name = "txtMemID";
            txtMemID.Size = new Size(252, 23);
            txtMemID.TabIndex = 42;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(123, 39);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(252, 23);
            txtOrderID.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 123);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 40;
            label3.Text = "Order date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 39;
            label2.Text = "Member ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 38;
            label1.Text = "Order ID";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(123, 239);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(252, 23);
            txtFreight.TabIndex = 49;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(123, 200);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(252, 23);
            txtShippedDate.TabIndex = 48;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(123, 159);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(252, 23);
            txtRequiredDate.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 242);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 46;
            label6.Text = "Freight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 203);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 45;
            label5.Text = "Shipped date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 162);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 44;
            label4.Text = "Required date";
            // 
            // frmOrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 370);
            Controls.Add(txtFreight);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtOrderDate);
            Controls.Add(txtMemID);
            Controls.Add(txtOrderID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmOrderInfo";
            Text = "OrderInfo";
            Load += OrderInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtOrderDate;
        private TextBox txtMemID;
        private TextBox txtOrderID;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFreight;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}