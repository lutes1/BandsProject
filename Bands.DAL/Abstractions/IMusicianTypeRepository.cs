using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;

namespace Bands.DAL.Abstractions
{
    public interface IMusicianTypeRepository : IGenericRepository<MusicianType>
    {
        MusicianType GetMusicianTypeById(long id);
        MusicianType GetMusicianTypeByName(string name);
    }
}
