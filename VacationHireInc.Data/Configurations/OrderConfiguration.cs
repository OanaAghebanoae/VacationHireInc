using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.RentableProperty).WithMany().HasForeignKey(x => x.RentablePropertyId);
            builder.HasOne(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerId);

            builder.HasIndex(x => x.RentablePropertyId);
            builder.HasIndex(x => x.CustomerId);
        }
    }
}
