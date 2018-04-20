using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class MusicianConfig : IEntityTypeConfiguration<Musician>
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.HasKey(x => x.ApplicationUserId);

            builder.HasOne(x => x.MusicianType).WithMany(x => x.Musician).IsRequired();
            builder.HasOne(x => x.MapLocation).WithMany(x => x.Musician).IsRequired();
        }
    }
}