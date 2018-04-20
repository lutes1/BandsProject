using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class InterestConfig : IEntityTypeConfiguration<Interest>
    {
        public void Configure(EntityTypeBuilder<Interest> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
