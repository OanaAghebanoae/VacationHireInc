using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Data.Configurations
{
    public class RentablePropertyConfiguration : IEntityTypeConfiguration<RentableProperty>
    {
        public void Configure(EntityTypeBuilder<RentableProperty> builder)
        {
            builder.ToTable(nameof(RentableProperty));

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Type).WithMany().HasForeignKey(x => x.TypeId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
