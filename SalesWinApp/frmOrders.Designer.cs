namespace SalesWinApp
{
    partial class frmOrders
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
            txtFreight = new TextBox();
            txtShippedDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtOrderDate = new TextBox();
            txtMemID = new TextBox();
            txtOrderID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvOrder = new DataGridView();
            btnViewOrderDetail = new Button();
            btnViewSale = new Button();
            label7 = new Label();
            label8 = new Label();
            btnLoad = new Button();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            txtNumOfSales = new TextBox();
            txtTotalPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(650, 173);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(542, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(145, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(35, 173);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 18;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(482, 121);
            txtFreight.Name = "txtFreight";
            txtFreight.ReadOnly = true;
            txtFreight.Size = new Size(274, 23);
            txtFreight.TabIndex = 33;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(482, 78);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.ReadOnly = true;
            txtShippedDate.Size = new Size(274, 23);
            txtShippedDate.TabIndex = 32;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(482, 32);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.ReadOnly = true;
            txtRequiredDate.Size = new Size(274, 23);
            txtRequiredDate.TabIndex = 31;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(102, 121);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(252, 23);
            txtOrderDate.TabIndex = 30;
            // 
            // txtMemID
            // 
            txtMemID.Location = new Point(102, 78);
            txtMemID.Name = "txtMemID";
            txtMemID.ReadOnly = true;
            txtMemID.Size = new Size(252, 23);
            txtMemID.TabIndex = 29;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(102, 32);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(252, 23);
            txtOrderID.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 124);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 27;
            label6.Text = "Freight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 81);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 26;
            label5.Text = "Shipped date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 40);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 25;
            label4.Text = "Required date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 24;
            label3.Text = "Order date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 81);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 23;
            label2.Text = "Member ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 22;
            label1.Text = "Order ID";
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(15, 320);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowTemplate.Height = 25;
            dgvOrder.Size = new Size(741, 239);
            dgvOrder.TabIndex = 34;
            // 
            // btnViewOrderDetail
            // 
            btnViewOrderDetail.Location = new Point(382, 173);
            btnViewOrderDetail.Name = "btnViewOrderDetail";
            btnViewOrderDetail.Size = new Size(129, 23);
            btnViewOrderDetail.TabIndex = 35;
            btnViewOrderDetail.Text = "View Order's Details";
            btnViewOrderDetail.UseVisualStyleBackColor = true;
            btnViewOrderDetail.Click += btnViewOrderDetail_Click;
            // 
            // btnViewSale
            // 
            btnViewSale.Location = new Point(333, 243);
            btnViewSale.Name = "btnViewSale";
            btnViewSale.Size = new Size(91, 40);
            btnViewSale.TabIndex = 36;
            btnViewSale.Text = "View Sales";
            btnViewSale.UseVisualStyleBackColor = true;
            btnViewSale.Click += btnViewSale_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 234);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 39;
            label7.Text = "Start Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 276);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 40;
            label8.Text = "End Date:";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(250, 173);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 23);
            btnLoad.TabIndex = 41;
            btnLoad.Text = "Reload Orders";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(102, 234);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 42;
            dtpStart.Value = new DateTime(2023, 10, 31, 7, 7, 20, 0);
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(102, 276);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(482, 240);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 44;
            label9.Text = "Number of Sales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(482, 276);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 45;
            label10.Text = "Total Price:";
            // 
            // txtNumOfSales
            // 
            txtNumOfSales.Location = new Point(588, 237);
            txtNumOfSales.Name = "txtNumOfSales";
            txtNumOfSales.ReadOnly = true;
            txtNumOfSales.Size = new Size(137, 23);
            txtNumOfSales.TabIndex = 46;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(588, 273);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(137, 23);
            txtTotalPrice.TabIndex = 47;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 580);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtNumOfSales);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(btnLoad);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnViewSale);
            Controls.Add(btnViewOrderDetail);
            Controls.Add(dgvOrder);
            Controls.Add(txtFreight);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtMemID);
            Controls.Add(txtOrderID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Name = "frmOrders";
            Text = "frmOrders";
            FormClosing += frmOrders_FormClosing;
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox txtFreight;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private TextBox txtOrderDate;
        private TextBox txtMemID;
        private TextBox txtOrderID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvOrder;
        private Button btnViewOrderDetail;
        private Button btnViewSale;
        private Label label7;
        private Label label8;
        private Button btnLoad;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label9;
        private Label label10;
        private TextBox txtNumOfSales;
        private TextBox txtTotalPrice;
    }
}