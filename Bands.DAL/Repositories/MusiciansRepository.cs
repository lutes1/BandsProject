using System.Collections.Generic;
using System.Linq;
using Bands.DAL.Abstractions;
using Bands.Domains;
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
    }
}
