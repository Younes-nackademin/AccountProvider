using System.Collections.Generic;
using AccountProvider.Domain.Models;

namespace AccountProvider.Business.Interfaces
{
    public interface IOrderService
    {
        void CreateOrder(int userId, string product);
        bool CancelOrder(int orderId);
        IEnumerable<Order> GetOrdersForUser(int userId);
    }
}
