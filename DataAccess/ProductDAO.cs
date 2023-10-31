using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object lockObject = new object();
        public ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
        public List<Product> GetProducts()
        {
            using var db = new SaleManagementContext();
            return db.Products.ToList();
        }
        public Product GetProductByID(int id)
        {
            var tmp = GetProducts()
                .SingleOrDefault(p => p.ProductId == id);
            return tmp;

        }
        public void AddProduct(Product product)
        {
            using var db = new SaleManagementContext();
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void UpdateProduct(Product product) 
        {
            using var db = new SaleManagementContext();
            db.Products.Update(product);
            db.SaveChanges();
        }
        public void RemoveProduct(Product product)
        {
            using var db = new SaleManagementContext();
            var pro = db.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
            db.Products.Remove(pro);
            db.SaveChanges();
        }
    }
}
