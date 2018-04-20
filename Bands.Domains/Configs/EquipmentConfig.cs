using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Configs
{
    public class EquipmentConfig : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.Property(x => x.EquipmentName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Model).HasMaxLength(30);
            builder.HasOne(x => x.EquipmentType).WithMany(x => x.Equipments).IsRequired();
            builder.HasOne(x => x.Musician).WithMany(x => x.Equipments).IsRequired();
        }
    }
}