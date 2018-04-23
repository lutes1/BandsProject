using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;

namespace Bands.DAL.Abstractions
{
    public interface IMusicianInterestsRepository : IGenericRepository<MusicianInterest>
    {
        void CreateInterest(List<MusicianInterest> musicianInterests);
    }
}
