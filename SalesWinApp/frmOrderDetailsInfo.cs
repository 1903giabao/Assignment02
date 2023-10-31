using BusinessObjects.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetailsInfo : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IOrderDetailsRepository orderDetailsRepository { get; set; }
        public OrderDetail orderDetail { get; set; }
        public Order Order { get; set; }
        IProductRepository productRepository = new ProductRepository();
        public frmOrderDetailsInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ordDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(cboProID.Text),
                    UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtDiscount.Text),
                };
                DialogResult d;
                if (!string.IsNullOrEmpty(ordDetail.OrderId.ToString()) && !string.IsNullOrEmpty(ordDetail.ProductId.ToString()) &&
                    !string.IsNullOrEmpty(ordDetail.UnitPrice.ToString()) && !string.IsNullOrEmpty(ordDetail.Quantity.ToString()) &&
                    !string.IsNullOrEmpty(ordDetail.Discount.ToString()))
                {
                    string check = "";
                    if (!InsertOrUpdate)
                    {
                        orderDetailsRepository.AddOrderDetail(ordDetail);
                        check = "Insert";
                    }
                    else
                    {
                        orderDetailsRepository.UpdateOrderDetail(ordDetail);
                        check = "Update";
                    }
                    d = MessageBox.Show(check + " successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (d == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    d = MessageBox.Show("Please fill all the blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order detail" : "Update an order detail");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderDetailsInfo_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtOrderID.Text = Order.OrderId.ToString();
            if (InsertOrUpdate)
            {
                cboProID.Enabled = false;
                cboProID.Text = orderDetail.ProductId.ToString();
                txtUnitPrice.Text = orderDetail.UnitPrice.ToString();
                txtQuantity.Text = orderDetail.Quantity.ToString();
                txtDiscount.Text = orderDetail.Discount.ToString();
            }
            else
            {
                foreach (var pro in productRepository.GetProducts())
                {
                    cboProID.Items.Add(pro.ProductId);
                }
            }
        }

        private void cboProID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnitPrice.Text = productRepository.GetProductByID(int.Parse(cboProID.SelectedItem.ToString())).UnitPrice.ToString();
        }
    }
}
