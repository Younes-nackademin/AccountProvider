using AccountProvider.Business.Interfaces;
using AccountProvider.Data.Interfaces;
using AccountProvider.Domain.Models;
using System.Collections.Generic;

namespace AccountProvider.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        // skapare för att lägga ett order-repository (lagrar)
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder(int userId, string product)
        {
            var newOrder = new Order { UserId = userId, ProductName = product, Status = "Pending" };
            _orderRepository.AddOrder(newOrder);
        }

        public bool CancelOrder(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order != null)
            {
                _orderRepository.DeleteOrder(orderId);
                return true;
            }
            return false;
        }

        public IEnumerable<Order> GetOrdersForUser(int userId)
        {
            return _orderRepository.GetAllOrders();
        }
    }
}
