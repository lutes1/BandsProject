using Bands.Domains.JonctionModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class BandsGenresConfig : IEntityTypeConfiguration<BandsGenres>
    {
        public void Configure(EntityTypeBuilder<BandsGenres> builder)
        {
            builder.HasKey(x => new
            {
                x.BandId,
                x.GenreId
            });
        }
    }
}
