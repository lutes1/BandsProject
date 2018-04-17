using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class MusicianInterestConfig : IEntityTypeConfiguration<MusicianInterest>
    {
        public void Configure(EntityTypeBuilder<MusicianInterest> builder)
        {
            builder.HasKey(x => new
            {
                x.InterestId,x.MusicianId
            });
        }
    }
}