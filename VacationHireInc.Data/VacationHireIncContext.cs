using Microsoft.EntityFrameworkCore;
using VacationHireInc.Data.Configurations;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Data
{
    public class VacationHireIncContext : DbContext
    {
        public VacationHireIncContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentableProperty> RentableProperties { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LookupType> LookupTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new RentablePropertyConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new LookupTypeConfiguration());

            builder.Entity<LookupType>().HasData(
                new LookupType { Name = "Truck" },
                new LookupType { Name = "Minivan" },
                new LookupType { Name = "Sedan" });
        }
    }
}
