using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class MusicianBandConfig : IEntityTypeConfiguration<MusicianBand>
    {
        public void Configure(EntityTypeBuilder<MusicianBand> builder)
        {
            builder.HasKey(x => new {x.BandId,x.MusicianId });
        }
    }
}