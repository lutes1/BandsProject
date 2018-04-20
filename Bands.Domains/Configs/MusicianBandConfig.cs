using Bands.Domains.JonctionModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class MusicianBandConfig : IEntityTypeConfiguration<MusicianBand>
    {
        public void Configure(EntityTypeBuilder<MusicianBand> builder)
        {
            builder.HasKey(x => new {x.BandId,x.MusicianId });
        }
    }
}