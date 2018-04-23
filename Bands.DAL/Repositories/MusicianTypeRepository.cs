using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bands.DAL.Abstractions;
using Bands.Domains.Models;

namespace Bands.DAL.Repositories
{
    public class MusicianTypeRepository : DatabaseRepository<MusicianType> , IMusicianTypeRepository
    {
        public MusicianTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public MusicianType GetMusicianTypeById(long id)
        {
            return DbContext.MusicianTypes.FirstOrDefault(x=>x.MusicianTypeId == id);
        }

        public MusicianType GetMusicianTypeByName(string name)
        {
            return DbContext.MusicianTypes.FirstOrDefault(x => x.TypeName.Equals(name));
        }
    }
}
