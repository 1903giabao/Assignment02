using BusinessObjects.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailsDAO
    {
        private static OrderDetailsDAO instance = null;
        private static readonly object lockObject = new object();
        public OrderDetailsDAO() { }
        public static OrderDetailsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailsDAO();
                }
                return instance;
            }
        }
        public List<OrderDetail> GetOrderDetails()
        {
            using var db = new SaleManagementContext();
            return db.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetailByOrderIdAndProductId(int ordId, int proId)
        {
            var orderDetail = GetOrderDetails().SingleOrDefault(o =>  o.OrderId == ordId && o.ProductId == proId);
            return orderDetail;
        }
        public List<OrderDetail> GetOrderDetailsByOrder(Order order) 
        {
            var list = GetOrderDetails().Where(o => o.OrderId == order.OrderId).ToList();
            return list;
        }
        public void AddOrderDetail(OrderDetail orderDetail)
        {
            using var db = new SaleManagementContext();
            db.OrderDetails.Add(orderDetail);
            db.SaveChanges();
        }
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            using var db = new SaleManagementContext();
            db.OrderDetails.Update(orderDetail);
            db.SaveChanges();
        }
        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            using var db = new SaleManagementContext();
            var orderDetailDel = db.OrderDetails.SingleOrDefault(o => o.OrderId == orderDetail.OrderId);
            db.OrderDetails.Remove(orderDetailDel);
            db.SaveChanges();
        }
    }
}
