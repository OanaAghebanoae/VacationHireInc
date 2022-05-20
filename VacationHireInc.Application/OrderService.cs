using VacationHireInc.Core;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Application
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task Create(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}