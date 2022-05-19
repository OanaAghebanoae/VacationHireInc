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
            builder.HasOne(x => x.RentableProperty).WithMany().HasForeignKey(x => x.RentablePropertyId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(x => x.RentableProperty);
            builder.HasIndex(x => x.Customer);
        }
    }
}
