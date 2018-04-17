using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class MusicianConfig : IEntityTypeConfiguration<Musician>
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000);
            builder.Property(x => x.City).HasMaxLength(20);
            builder.HasKey(x => x.ApplicationUserId);
        }
    }
}