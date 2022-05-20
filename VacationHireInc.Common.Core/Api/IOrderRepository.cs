using VacationHireInc.Data.Models;

namespace VacationHireInc.Core.Api
{
    public interface IOrderRepository
    {
        Task Create(Order order);
        Task<IEnumerable<Order>> Get();
        Task<Order> GetById(int id);
        Task Update(Order order);
    }
}
