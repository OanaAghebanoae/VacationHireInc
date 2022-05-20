using VacationHireInc.Data.Models;

namespace VacationHireInc.Core.Api
{
    public interface IOrderRepository
    {
        Task Create(Order order);
        Task<IEnumerable<Order>> Get();
        Task Update(Order order);
    }
}
