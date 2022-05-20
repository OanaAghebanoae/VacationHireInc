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

        public async Task<bool> Create(CreateOrderRequest order)
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

        public async Task<Order> GetById(int id)
        {
            return await _orderRepository.GetById(id);
        }

        public async Task<bool> Update(UpdateOrderRequest order)
        {
            try
            {
                var entity = await GetById(order.Id);

                entity.CustomerId = order.CustomerId.HasValue ? order.CustomerId.Value : entity.CustomerId;
                entity.RentablePropertyId = order.RentablePropertyId.HasValue ? order.RentablePropertyId.Value : entity.RentablePropertyId;
                entity.RentStartDate = order.RentStartDate.HasValue ? order.RentStartDate.Value : entity.RentStartDate;
                entity.RentEndDate = order.RentEndDate.HasValue ? order.RentEndDate.Value : entity.RentEndDate;
                entity.DamagePresented = order.DamagePresented.HasValue ? order.DamagePresented.Value : entity.DamagePresented;
                entity.DamageDetails = string.IsNullOrEmpty(order.DamageDetails) ? entity.DamageDetails : order.DamageDetails;
                entity.TankFilledUp = order.TankFilledUp.HasValue ? order.TankFilledUp.Value : entity.TankFilledUp;
                entity.PriceUnit = order.PriceUnit.HasValue ? order.PriceUnit.Value : entity.PriceUnit;
                entity.PriceCurrency = string.IsNullOrEmpty(order.PriceCurrency) ? entity.PriceCurrency : order.PriceCurrency;

                await _orderRepository.Update(entity);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}