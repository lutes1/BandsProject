using System.Collections.Generic;
using System.Linq;
using Bands.DAL.Abstractions;
using Bands.DTO;
using Bands.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace Bands.DAL.Repositories
{
    public class MusiciansRepository : DatabaseRepository<Musician>,IMusiciansRepository
    {
        public MusiciansRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override IEnumerable<Musician> GetAll()
        {
            return DbContext.Musicians
                .Include(x=>x.MusicianType)
                .Include(x => x.ApplicationUser)
                .Include(x=>x.Interests).ThenInclude(x=>x.Interest)
                .Include(x=>x.MapLocation)
                .ToList();
        }

        public Musician GetMuscianById(long id)
        {
            return DbContext.Musicians
                .Include(x=>x.ApplicationUser)
                .Include(x=>x.Interests).ThenInclude(x=>x.Interest)
                .Include(x=>x.MusicianBands).ThenInclude(x=>x.Band)
                .Include(x=>x.Equipments).ThenInclude(x=>x.EquipmentType)
                .Include(x=>x.MapLocation)
                .Include(x=>x.MusicianType)
                .FirstOrDefault(x=>x.ApplicationUserId == id);
        }

        public MusicianReadCommonDto GetMusicianCommonData()
        {
            var musicianCommonDto =

                new MusicianReadCommonDto
                {
                    Cities = DbContext.MapLocations.Select(x => x.City).Distinct().ToList(),
                    Countries = DbContext.MapLocations.Select(x => x.Country).Distinct().ToList(),
                    Interests = DbContext.Interests.Select(x => x.Name).ToList(),
                    MusicianTypes = DbContext.MusicianTypes.Select(x => x.TypeName).Distinct().ToList()
                };


            return musicianCommonDto;
        }

        public void MusicianCreate(Musician musician)
        {
            DbContext.Musicians.Add(new Musician
            {
                Description = musician.Description,
                MusicianType = musician.MusicianType,
                MapLocation = musician.MapLocation,
                ApplicationUser = musician.ApplicationUser,
                Likes = 0,
                Interests = musician.Interests
            });
            DbContext.SaveChanges();
        }
    }
}
