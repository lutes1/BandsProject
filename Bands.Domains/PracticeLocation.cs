using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains
{
    public class PracticeLocation
    {
        public long PracticeLocationId { get; set; }
        [Column(TypeName = "numeric(18,6)")]
        public decimal Latitude{ get; set; }

        [Column(TypeName = "numeric(18,6)")]
        public decimal Longitude{ get; set; }
        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Picture> Pictures { get; set; }
        public string Description { get; set; }
    }

    public class PracticeLocationConfig : IEntityTypeConfiguration<PracticeLocation>
    {
        public void Configure(EntityTypeBuilder<PracticeLocation> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            builder.Property(x => x.OwnerFullName).HasMaxLength(40);

            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
        }
    }
}
