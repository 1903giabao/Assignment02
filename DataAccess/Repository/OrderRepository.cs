using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrders() => OrderDAO.Instance.GetOrders();
        public Order GetOrderById(int id) => OrderDAO.Instance.GetOrderById(id);
        public List<Member> GetMembers() => OrderDAO.Instance.GetMembers();
        public List<Order> GetOrdersByMember(Member member) => OrderDAO.Instance.GetOrdersByMember(member);
        public void SaveOrder(Order order) => OrderDAO.Instance.SaveOrder(order);
        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
        public void DeleteOrder(Order order) => OrderDAO.Instance?.DeleteOrder(order);
    }
}
