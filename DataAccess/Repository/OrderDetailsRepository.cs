using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public List<OrderDetail> GetOrderDetails() => OrderDetailsDAO.Instance.GetOrderDetails();
        public OrderDetail GetOrderDetailByOrderIdAndProductId(int ordId, int proId) => OrderDetailsDAO.Instance.GetOrderDetailByOrderIdAndProductId(ordId, proId);
        public List<OrderDetail> GetOrderDetailsByOrder(Order order) => OrderDetailsDAO.Instance.GetOrderDetailsByOrder(order);
        public void AddOrderDetail(OrderDetail order) => OrderDetailsDAO.Instance.AddOrderDetail(order);
        public void UpdateOrderDetail(OrderDetail order) => OrderDetailsDAO.Instance.UpdateOrderDetail(order);
        public void DeleteOrderDetail(OrderDetail order) => OrderDetailsDAO.Instance?.DeleteOrderDetail(order);
    }
}
