using Bands.Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bands.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserConfig());
            builder.ApplyConfiguration(new MusicianConfig());
            builder.ApplyConfiguration(new BandConfig());
            builder.ApplyConfiguration(new PictureCofig());
            builder.ApplyConfiguration(new MusicianBandConfig());
            builder.ApplyConfiguration(new MusicianInterestConfig());   
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public Interest Interest { get; set; }
        public Picture Picture { get; set; }
        public MusicianType MusicianTypes { get; set; }
    }
}
