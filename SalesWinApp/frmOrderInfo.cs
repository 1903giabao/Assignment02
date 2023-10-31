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
    public partial class frmOrderInfo : Form
    {
        public IOrderRepository orderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order Order { get; set; }
        public frmOrderInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ord = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                };
                DialogResult d;
                if (!string.IsNullOrEmpty(ord.OrderId.ToString()) && !string.IsNullOrEmpty(ord.MemberId.ToString()) &&
                    !string.IsNullOrEmpty(ord.OrderDate.ToString()))
                {
                    string check = "";
                    if (!InsertOrUpdate)
                    {
                        orderRepository.SaveOrder(ord);
                        check = "Insert";
                    }
                    else
                    {
                        orderRepository.UpdateOrder(ord);
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
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update an order");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;
            txtMemID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtOrderID.Text = Order.OrderId.ToString();
                txtMemID.Text = Order.MemberId.ToString();
                txtOrderDate.Text = Order.OrderDate.ToString();
                txtRequiredDate.Text = Order.RequiredDate.ToString();
                txtShippedDate.Text = Order.ShippedDate.ToString();
                txtFreight.Text = Order.Freight.ToString();
            }
        }
    }
}
