using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class PracticeLocationConfig : IEntityTypeConfiguration<PracticeLocation>
    {
        public void Configure(EntityTypeBuilder<PracticeLocation> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            builder.Property(x => x.OwnerFullName).HasMaxLength(40);

            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
        }
    }
}
