using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailsRepository
    {
        List<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByOrderIdAndProductId(int ordId, int proId);
        List<OrderDetail> GetOrderDetailsByOrder(Order order);
        void AddOrderDetail(OrderDetail order);
        void UpdateOrderDetail(OrderDetail order);
        void DeleteOrderDetail(OrderDetail order);
    }
}
