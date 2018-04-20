using Bands.Domains.Configs;
using Bands.Domains.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bands.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<long>, long>
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
            builder.ApplyConfiguration(new PracticePlaceConfig());
            builder.ApplyConfiguration(new BandsGenresConfig());
            builder.ApplyConfiguration(new MusicianTypeConfig());
            builder.ApplyConfiguration(new EquipmentTypeConfig());
            builder.ApplyConfiguration(new EquipmentConfig());
            builder.ApplyConfiguration(new GenreConfig());
            builder.ApplyConfiguration(new InterestConfig());
            builder.ApplyConfiguration(new MapLocationConfig());
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<MusicianType> MusicianTypes { get; set; }
        public DbSet<PracticePlace> PracticePlaces { get; set; }
        public DbSet<Genre> Genres { set; get; }
        public DbSet<MapLocation> MapLocations { get; set; }
    }
}
