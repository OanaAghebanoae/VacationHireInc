using VacationHireInc.Core.Api;
using VacationHireInc.Core.Domain;
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

        public async Task<bool> Create(CreateEditOrderRequest order)
        {
            try
            {
                var entity = order.Create();
                await _orderRepository.Create(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Order>> Get()
        {
            return await _orderRepository.Get();
        }

        public Task Update(CreateEditOrderRequest order)
        {
            throw new NotImplementedException();
        }
    }
}