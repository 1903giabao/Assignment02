using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();
        public Product GetProductByID(int id) => ProductDAO.Instance.GetProductByID(id);
        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);
        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
        public void RemoveProduct(Product product) => ProductDAO.Instance.RemoveProduct(product);
    }
}
