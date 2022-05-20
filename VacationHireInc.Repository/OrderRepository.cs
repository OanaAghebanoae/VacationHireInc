﻿using Microsoft.EntityFrameworkCore;
using VacationHireInc.Core.Api;
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

        public async Task Create(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> Get()
        {
            return await _context.Orders
                .Include(c => c.Customer)
                .Include(p => p.RentableProperty)
                .ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _context.Orders
                .Include(c => c.Customer)
                .Include(p => p.RentableProperty)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(Order order)
        {
            await _context.SaveChangesAsync();
        }
    }
}