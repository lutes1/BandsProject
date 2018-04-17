using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class PictureCofig : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.Property(x => x.PictureName).HasMaxLength(20).IsRequired();

            builder.Property(x => x.Path).IsRequired().HasMaxLength(200);

            builder.Property(x => x.PictureGuid).IsRequired();
        }
    }
}