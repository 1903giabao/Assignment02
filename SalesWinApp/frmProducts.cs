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
    public partial class frmProducts : Form
    {
        public Member mem { get; set; }
        public string role { get; set; }
        BindingSource BindingSource;
        IProductRepository productRepository = new ProductRepository();
        public frmProducts()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtProID.Text = string.Empty;
            txtCateID.Text = string.Empty;
            txtProName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        private void Binding(List<Product> list)
        {
            try
            {
                var pros = list.Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.CategoryId,
                    p.UnitPrice,
                    p.UnitsInStock,
                    p.Weight
                }).ToList();

                BindingSource = new BindingSource();
                BindingSource.DataSource = pros;

                txtProID.DataBindings.Clear();
                txtCateID.DataBindings.Clear();
                txtProName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProID.DataBindings.Add("Text", BindingSource, "ProductId");
                txtCateID.DataBindings.Add("Text", BindingSource, "CategoryId");
                txtProName.DataBindings.Add("Text", BindingSource, "ProductName");
                txtWeight.DataBindings.Add("Text", BindingSource, "Weight");
                txtUnitPrice.DataBindings.Add("Text", BindingSource, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", BindingSource, "UnitsInStock");

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = BindingSource;

                if (pros.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List");
            }
        }

        private void LoadProductList()
        {
            var list = productRepository.GetProducts();
            Binding(list);
        }

        private void SearchProductByProductId()
        {
            var list = productRepository.GetProducts();
            var searchList = new List<Product>();

            foreach (var product in list)
            {
                if (product.ProductId == int.Parse(txtSrch.Text))
                {
                    searchList.Add(product);
                }
            }
            Binding(searchList);
        }

        private void SearchProductByProductName()
        {
            var list = productRepository.GetProducts();
            var searchList = new List<Product>();

            foreach (var product in list)
            {
                if (product.ProductName.Contains(txtSrch.Text, StringComparison.OrdinalIgnoreCase))
                {
                    searchList.Add(product);
                }
            }
            Binding(searchList);
        }

        private void SearchProductByProductUnitPrice()
        {
            var list = productRepository.GetProducts();
            var searchList = new List<Product>();

            foreach (var product in list)
            {
                if (product.UnitPrice == int.Parse(txtSrch.Text))
                {
                    searchList.Add(product);
                }
            }
            Binding(searchList);
        }

        private void SearchProductByUnitsInStock()
        {
            var list = productRepository.GetProducts();
            var searchList = new List<Product>();

            foreach (var product in list)
            {
                if (product.UnitsInStock == int.Parse(txtSrch.Text))
                {
                    searchList.Add(product);
                }
            }
            Binding(searchList);
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnSrchProID_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSrch.Text))
            {
                SearchProductByProductId();
            }
            else
            {
                LoadProductList();
            }
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult d;
            //d = MessageBox.Show("Do you really want to exit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (d == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnSrchProName_Click(object sender, EventArgs e)
        {
            SearchProductByProductName();
        }

        private void btnSrchUnitPrice_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSrch.Text))
            {
                SearchProductByProductUnitPrice();
            }
            else
            {
                LoadProductList();
            }
        }

        private void btnSrchUnitsInStock_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrEmpty(txtSrch.Text))
            {
                SearchProductByUnitsInStock();
            }
            else
            {
                LoadProductList();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Add a product",
                InsertOrUpdate = false,
                ProductRepository = productRepository,
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                BindingSource.Position = BindingSource.Count - 1;
            }
            LoadProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Update a product",
                Product = productRepository.GetProductByID(int.Parse(txtProID.Text)),
                InsertOrUpdate = true,
                ProductRepository = productRepository,
            };
            frmProductDetails.ShowDialog();
            LoadProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = productRepository.GetProductByID(int.Parse(txtProID.Text));
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this product?", "Delete Product",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    productRepository.RemoveProduct(pro);
                }
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete product");
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
    }
}
