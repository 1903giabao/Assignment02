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
    public partial class frmProductDetails : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product Product { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            txtProID.Enabled = !InsertOrUpdate;
            txtProName.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtProID.Text = Product.ProductId.ToString();
                txtCateID.Text = Product.CategoryId.ToString();
                txtProName.Text = Product.ProductName;
                txtWeight.Text = Product.Weight;
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = new Product
                {
                    ProductId = int.Parse(txtProID.Text),
                    CategoryId = int.Parse(txtCateID.Text),
                    ProductName = txtProName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                };
                DialogResult d;
                if (!string.IsNullOrEmpty(pro.ProductId.ToString()) && !string.IsNullOrEmpty(pro.CategoryId.ToString()) && 
                    !string.IsNullOrEmpty(pro.ProductName) && !string.IsNullOrEmpty(pro.Weight) &&
                    !string.IsNullOrEmpty(pro.UnitPrice.ToString()) && !string.IsNullOrEmpty(pro.UnitsInStock.ToString()))
                {
                    string check = "";
                    if (!InsertOrUpdate)
                    {
                        ProductRepository.AddProduct(pro);
                        check = "Insert";
                    }
                    else
                    {
                        ProductRepository.UpdateProduct(pro);
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
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }
        }
    }
}
