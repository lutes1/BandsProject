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
                .ToList();
        }

        public Musician GetMuscianById(string id)
        {
            return DbContext.Musicians
                .Include(x=>x.ApplicationUser)
                .Include(x => x.ApplicationUser)
                .FirstOrDefault(x=>x.ApplicationUserId.Equals(id));
        }

        public MusicianCommonDto GetMusicianCommonData()
        {
            var musicianCommonDto =

                new MusicianCommonDto
                {
                    Cities = DbContext.MapLocations.Select(x => x.City).ToList(),
                    Countries = DbContext.MapLocations.Select(x => x.Country).ToList(),
                    Interests = DbContext.Interests.Select(x => x.Name).ToList(),
                    MusicianTypes = DbContext.MusicianTypes.Select(x => x.TypeName).ToList()
                };


            return musicianCommonDto;
        }
    }
}
