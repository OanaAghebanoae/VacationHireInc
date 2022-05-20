using VacationHireInc.Core.Domain;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Core.Api
{
    public interface IOrderService
    {
        Task<bool> Create(CreateOrderRequest order);
        Task<IEnumerable<Order>> Get();
        Task<Order> GetById(int id);
        Task<bool> Update(UpdateOrderRequest order);
    }
}