using System;
using System.Collections.Generic;
using System.Text;
using Bands.DAL.Abstractions;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;

namespace Bands.DAL.Repositories
{
    public class MusicianInterestsRepository : DatabaseRepository<MusicianInterest>, IMusicianInterestsRepository
    {
        public void CreateInterest(List<MusicianInterest> musicianInterests)
        {
            DbContext.MusicianInterests.AddRange(musicianInterests);
            DbContext.SaveChanges();    
        }

        public MusicianInterestsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
