using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class MusicianTypeConfig : IEntityTypeConfiguration<MusicianType>
    {
        public void Configure(EntityTypeBuilder<MusicianType> builder)
        {
            builder.Property(x => x.TypeName).IsRequired().HasMaxLength(20);
            builder.HasKey(x => new {x.MusicianTypeId, x.TypeName});
        }
    }
}
