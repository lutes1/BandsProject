using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Models
{
    public class MusicianType
    {
        public long MusicianTypeId { get; set; }
        public string TypeName { get; set; }
        public List<Musician> Musician { get; set; }
    }

    public class MusicianTypeConfig : IEntityTypeConfiguration<MusicianType>
    {
        public void Configure(EntityTypeBuilder<MusicianType> builder)
        {
            builder.Property(x => x.TypeName).IsRequired().HasMaxLength(20);
        }
    }
}