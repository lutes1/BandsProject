using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class PracticePlaceConfig : IEntityTypeConfiguration<PracticePlace>
    {
        public void Configure(EntityTypeBuilder<PracticePlace> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            builder.Property(x => x.OwnerFullName).HasMaxLength(40);

            builder.Property(x => x.PhoneNumber).HasMaxLength(20);

            builder.HasKey(x=>x.MapLocationId);
        }
    }
}
