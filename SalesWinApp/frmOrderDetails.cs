using BusinessObjects.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        public Member mem { get; set; }
        public string role { get; set; }
        public Order Order { get; set; }
        IOrderDetailsRepository OrderDetailsRepository = new OrderDetailsRepository();
        BindingSource BindingSource { get; set; }

        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtProID.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

        private void Binding(List<OrderDetail> list)
        {
            try
            {
                var orderDetails = list.Select(p => new
                {
                    p.OrderId,
                    p.ProductId,
                    p.UnitPrice,
                    p.Quantity,
                    p.Discount
                }).ToList();

                BindingSource = new BindingSource();
                BindingSource.DataSource = orderDetails;

                txtOrderID.DataBindings.Clear();
                txtProID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", BindingSource, "OrderId");
                txtProID.DataBindings.Add("Text", BindingSource, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", BindingSource, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", BindingSource, "Quantity");
                txtDiscount.DataBindings.Add("Text", BindingSource, "Discount");

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = BindingSource;

                if (orderDetails.Count == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Detail List");
            }
        }

        private void LoadOrderDetailList()
        {
            var list = OrderDetailsRepository.GetOrderDetailsByOrder(Order);
            Binding(list);
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (!role.Equals("Admin"))
            {
                btnDelete.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
            }
            LoadOrderDetailList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmOrderDetailsInfo frmOrderDetailsInfo = new frmOrderDetailsInfo
            {
                Text = "Add an order detail",
                Order = Order,
                InsertOrUpdate = false,
                orderDetailsRepository = OrderDetailsRepository,
            };
            if (frmOrderDetailsInfo.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            LoadOrderDetailList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderDetailsInfo frmOrderDetailsInfo = new frmOrderDetailsInfo
            {
                Text = "Update an order",
                Order = Order,
                orderDetail = OrderDetailsRepository.GetOrderDetailByOrderIdAndProductId(int.Parse(txtOrderID.Text), int.Parse(txtProID.Text)),
                InsertOrUpdate = true,
                orderDetailsRepository = OrderDetailsRepository,
            };
            frmOrderDetailsInfo.ShowDialog();
            LoadOrderDetailList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var ordDetail = OrderDetailsRepository.GetOrderDetailByOrderIdAndProductId(int.Parse(txtOrderID.Text), int.Parse(txtProID.Text));
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this order detail?", "Delete Order Detail",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    OrderDetailsRepository.DeleteOrderDetail(ordDetail);
                }
                LoadOrderDetailList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete order detail");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmOrders f = new frmOrders();
            //f.role = role;
            //f.mem = mem;
            this.Hide();
            //f.Show();
        }

        private void frmOrderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult d;
            //d = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (d == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
