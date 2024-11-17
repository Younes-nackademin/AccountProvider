using System.Collections.Generic;
using AccountProvider.Domain.Models;

namespace AccountProvider.Data.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetAllOrders();
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
    }
}
