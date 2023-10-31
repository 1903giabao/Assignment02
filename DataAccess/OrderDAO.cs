using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object lockObject = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        public List<Order> GetOrders()
        {
            using var db = new SaleManagementContext();
            return db.Orders.Include(o => o.Member).ToList();
        }
        public Order GetOrderById(int id)
        {
            var tmp = GetOrders().SingleOrDefault(o => o.OrderId == id);
            return tmp;
        }
        public List<Member> GetMembers() 
        {
            using var db = new SaleManagementContext();
            return db.Members.ToList();
        }
        public List<Order> GetOrdersByMember(Member mem)
        {
            var tmp = GetOrders().Where(o => o.MemberId == mem.MemberId).ToList();
            return tmp;
        }
        public void SaveOrder(Order order)
        {
            using var db = new SaleManagementContext();
            db.Orders.Add(order);
            db.SaveChanges();
        }
        public void UpdateOrder(Order order)
        {
            using var db = new SaleManagementContext();
            db.Orders.Update(order);
            db.SaveChanges();
        }
        public void DeleteOrder(Order order)
        {
            using var db = new SaleManagementContext();
            var orderDel = db.Orders.SingleOrDefault(o => o.OrderId == order.OrderId);
            db.Orders.Remove(order);
            db.SaveChanges();
        }
    }
}
