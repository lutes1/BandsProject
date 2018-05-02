using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class DemoConfig : IEntityTypeConfiguration<Demo>
    {
        public void Configure(EntityTypeBuilder<Demo> builder)
        {
            builder.Property(x => x.Link).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Name).HasMaxLength(30);
        }
    }
}
