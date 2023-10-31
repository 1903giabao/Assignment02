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
    public partial class frmOrders : Form
    {
        public Member mem { get; set; }
        public string role { get; set; }
        BindingSource BindingSource;
        IOrderRepository orderRepository = new OrderRepository();
        public frmOrders()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtMemID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private void Binding(List<Order> list)
        {
            btnLoad.Enabled = true;
            btnViewOrderDetail.Enabled = true;
            try
            {
                var orders = list.Select(o => new
                {
                    o.OrderId,
                    o.MemberId,
                    o.OrderDate,
                    o.RequiredDate,
                    o.ShippedDate,
                    o.Freight
                }).ToList();

                BindingSource = new BindingSource();
                BindingSource.DataSource = orders;

                txtOrderID.DataBindings.Clear();
                txtMemID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", BindingSource, "OrderId");
                txtMemID.DataBindings.Add("Text", BindingSource, "MemberId");
                txtOrderDate.DataBindings.Add("Text", BindingSource, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", BindingSource, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", BindingSource, "ShippedDate");
                txtFreight.DataBindings.Add("Text", BindingSource, "Freight");

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = BindingSource;

                if (orders.Count == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order List");
            }
        }

        private void LoadOrderList()
        {
            var list = orderRepository.GetOrders();
            Binding(list);
        }

        private void LoadOrder()
        {
            var list = orderRepository.GetOrdersByMember(mem);
            Binding(list);
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            if (role.Equals("Admin"))
            {
                LoadOrderList();
            }
            else
            {
                btnViewOrderDetail.Enabled = false;
                btnDelete.Enabled = false;
                LoadOrder();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmOrderInfo frmOrderInfo = new frmOrderInfo
            {
                Text = "Add an order",
                InsertOrUpdate = false,
                orderRepository = orderRepository,
            };
            if (frmOrderInfo.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            if (role.Equals("Admin"))
            {
                LoadOrderList();
            }
            else
            {
                LoadOrder();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderInfo frmOrderInfo = new frmOrderInfo
            {
                Text = "Update an order",
                Order = orderRepository.GetOrderById(int.Parse(txtOrderID.Text)),
                InsertOrUpdate = true,
                orderRepository = orderRepository,
            };
            frmOrderInfo.ShowDialog();
            if (role.Equals("Admin"))
            {
                LoadOrderList();
            }
            else
            {
                LoadOrder();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var ord = orderRepository.GetOrderById(int.Parse(txtOrderID.Text));
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this order?", "Delete Order",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    orderRepository.DeleteOrder(ord);
                }
                if (role.Equals("Admin"))
                {
                    LoadOrderList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete order");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmMain f = new frmMain();
            //f.role = role;
            //f.mem = mem;
            this.Hide();
            //f.Show();
        }

        private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult d;
            //d = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (d == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnViewOrderDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails();
            frm.role = role;
            frm.mem = mem;
            frm.Order = orderRepository.GetOrderById(int.Parse(txtOrderID.Text));
            //this.Hide();
            frm.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (role.Equals("Admin"))
            {
                LoadOrderList();
            }
            else
            {
                LoadOrder();
            }
        }

        private void btnViewSale_Click(object sender, EventArgs e)
        {
            try
            {
                IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();
                var orderList = orderRepository.GetOrders();
                var salesList = new List<object>();
                double total = 0;
                foreach (var order in orderList)
                {
                    if (order.OrderDate >= DateTime.Parse(dtpStart.Text) && order.OrderDate <= DateTime.Parse(dtpEnd.Text))
                    {
                        var orderDetailList = orderDetailsRepository.GetOrderDetailsByOrder(order);
                        double totalOrderPrice = 0;
                        foreach (var orderDetail in orderDetailList)
                        {
                            totalOrderPrice += (double)orderDetail.UnitPrice * orderDetail.Quantity * (1 - orderDetail.Discount);
                            total += totalOrderPrice;
                        }
                        salesList.Add(new
                        {
                            OrderId = order.OrderId,
                            MemberId = order.MemberId,
                            OrderDate = order.OrderDate,
                            RequiredDate = order.RequiredDate,
                            ShippedDate = order.ShippedDate,
                            Freight = order.Freight,
                            Total = totalOrderPrice,
                        });
                    }
                }
                txtNumOfSales.Text = salesList.Count.ToString();
                txtTotalPrice.Text = total.ToString();
                var orderedList = salesList.OrderByDescending(x => (double)x.GetType().GetProperty("Total").GetValue(x, null)).ToList();
                BindingSource = new BindingSource();
                BindingSource.DataSource = orderedList;
                txtOrderID.DataBindings.Clear();
                txtMemID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                txtOrderID.DataBindings.Add("Text", BindingSource, "OrderId");
                txtMemID.DataBindings.Add("Text", BindingSource, "MemberId");
                txtOrderDate.DataBindings.Add("Text", BindingSource, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", BindingSource, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", BindingSource, "ShippedDate");
                txtFreight.DataBindings.Add("Text", BindingSource, "Freight");
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = BindingSource;
                btnViewOrderDetail.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
