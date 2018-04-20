using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class MapLocationConfig : IEntityTypeConfiguration<MapLocation>
    {
        public void Configure(EntityTypeBuilder<MapLocation> builder)
        {
            builder.Property(x => x.City).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Address).HasMaxLength(50);
        }
    }
}
