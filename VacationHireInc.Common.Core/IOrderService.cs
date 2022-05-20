using VacationHireInc.Data.Models;

namespace VacationHireInc.Core
{
    public interface IOrderService
    {
        Task Create(Order order);
        Task<IEnumerable<Order>> Get();
        Task Update(Order order);
    }
}