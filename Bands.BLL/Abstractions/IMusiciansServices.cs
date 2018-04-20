using System.Collections.Generic;
using Bands.Domains;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.BLL.Abstractions
{
    public interface IMusiciansServices
    {
        List<Musician> GetAllMusicians();
        Musician GetMusicianById(string id);
        MusicianCommonDto GetMusicianCommonData();
    }
}
