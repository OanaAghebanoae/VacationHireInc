using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacationHireInc.Data.Models;

namespace VacationHireInc.Data.Configurations
{
    public class LookupTypeConfiguration : IEntityTypeConfiguration<LookupType>
    {
        public void Configure(EntityTypeBuilder<LookupType> builder)
        {
            builder.ToTable(nameof(LookupType));
            builder.HasKey(x => x.Id);
        }
    }
}
