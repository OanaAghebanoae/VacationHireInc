using Microsoft.EntityFrameworkCore;
using VacationHireInc.Data.Configurations;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Data
{
    public class VacationHireIncContext : DbContext
    {
        public VacationHireIncContext(DbContextOptions<VacationHireIncContext> options) : base(options) { }

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
                new LookupType { Id = 1, Name = "Truck" },
                new LookupType { Id = 2, Name = "Minivan" },
                new LookupType { Id = 3, Name = "Sedan" });

            builder.Entity<RentableProperty>().HasData(
                new RentableProperty { Id = 1, Name = "Iveco Daily", TypeId = 1 },
                new RentableProperty { Id = 2, Name = "Ford Transit", TypeId = 1 },
                new RentableProperty { Id = 3, Name = "Isuzu", TypeId = 1 },
                new RentableProperty { Id = 4, Name = "Mercedes Vito", TypeId = 2 },
                new RentableProperty { Id = 5, Name = "Ford S-Max", TypeId = 2 },
                new RentableProperty { Id = 6, Name = "Fiat Doblo", TypeId = 2 },
                new RentableProperty { Id = 7, Name = "Toyota Corolla", TypeId = 3 },
                new RentableProperty { Id = 8, Name = "Mazda 3", TypeId = 3 },
                new RentableProperty { Id = 9, Name = "Volkswagen Passat", TypeId = 3 },
                new RentableProperty { Id = 10, Name = "Renault Megane", TypeId = 3 },
                new RentableProperty { Id = 11, Name = "Audi A3", TypeId = 3 });

            builder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Elon Musk", Address = "United States, Street 1", PhoneNumber = "1234567890" },
                new Customer { Id = 2, Name = "Jeff Bezos", Address = "United States, Street 2", PhoneNumber = "2234567890" },
                new Customer { Id = 3, Name = "Bernard Arnault", Address = "France, Street 3", PhoneNumber = "3234567890" },
                new Customer { Id = 4, Name = "Bill Gates", Address = "United States, Street 4", PhoneNumber = "4234567890" },
                new Customer { Id = 5, Name = "Warren Buffett", Address = "United States, Street 5", PhoneNumber = "5234567890" });

            builder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    RentablePropertyId = 11,
                    RentStartDate = new DateTime(2022, 1, 15, 11, 30, 0),
                    RentEndDate = new DateTime(2022, 1, 22, 10, 0, 0),
                    DamagePresented = false,
                    TankFilledUp = true,
                    PriceUnit = 210,
                    PriceCurrency = "USD"
                },
               new Order
               {
                   Id = 2,
                   CustomerId = 4,
                   RentablePropertyId = 4,
                   RentStartDate = new DateTime(2022, 4, 11, 11, 30, 0),
                   RentEndDate = new DateTime(2022, 5, 1, 10, 0, 0),
                   DamagePresented = false,
                   TankFilledUp = false,
                   PriceUnit = 900,
                   PriceCurrency = "USD"
               },
               new Order
               {
                   Id = 3,
                   CustomerId = 5,
                   RentablePropertyId = 9,
                   RentStartDate = new DateTime(2022, 5, 1, 11, 30, 0),
                   RentEndDate = new DateTime(2022, 5, 5, 10, 40, 0),
                   DamagePresented = false,
                   TankFilledUp = true,
                   PriceUnit = 420,
                   PriceCurrency = "USD"
               }
                );
        }
    }
}