using System.Data.Entity.ModelConfiguration;

namespace Bands.Domains
{
    public class BandConfig : EntityTypeConfiguration<Band>
    {
        public BandConfig()
        {
            Property(x => x.BandName).IsRequired().HasMaxLength(20);

            HasRequired(x => x.Picture).WithRequiredDependent(x => x.Band);
            HasMany(x => x.Musicians).WithMany(x => x.Bands).Map(x =>
            {
                x.ToTable("MusiciansBands");
                x.MapLeftKey("BandId_FK");
                x.MapRightKey("MusicianId_FK");
            });
        }
    }
}