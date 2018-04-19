using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class BandsGenresConfig : IEntityTypeConfiguration<BandsGenres>
    {
        public void Configure(EntityTypeBuilder<BandsGenres> builder)
        {
            builder.HasKey(x => new
            {
                x.BandId,
                x.GenereId
            });
        }
    }
}
