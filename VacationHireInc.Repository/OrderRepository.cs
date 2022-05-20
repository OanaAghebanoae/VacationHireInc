using VacationHireInc.Core;
using VacationHireInc.Data;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly VacationHireIncContext _context;

        public OrderRepository(VacationHireIncContext context)
        {
            _context = context;
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