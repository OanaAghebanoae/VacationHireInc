using VacationHireInc.Core.Domain;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Core.Api
{
    public interface IOrderService
    {
        Task<bool> Create(CreateEditOrderRequest order);
        Task<IEnumerable<Order>> Get();
        Task Update(CreateEditOrderRequest order);
    }
}