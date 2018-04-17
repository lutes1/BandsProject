using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bands.Domains
{
    public class Musician
    {
        public long UserId { get; set; }
        public long Likes { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public MusicianType MusicianType { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Band> Bands { get; set; }
        public List<Equipment> Equipments { get; set; }

        //TODO USERS---------------------------------------
    }

    public class MusicianConfig : EntityTypeConfiguration<Musician>
    {
        public MusicianConfig()
        {
            Property(x => x.Description).HasMaxLength(1000);
            Property(x => x.City).HasMaxLength(20);

            HasMany(x => x.Interests).WithMany(x => x.Musicians).Map(x =>
            {
                x.ToTable("MusiciansInterests");
                x.MapLeftKey("MusicianId_FK");
                x.MapRightKey("InterestId_FK");
            });
        }
    }
}
