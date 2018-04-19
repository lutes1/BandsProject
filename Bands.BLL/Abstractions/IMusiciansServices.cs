using System.Collections.Generic;
using Bands.Domains;

namespace Bands.BLL.Abstractions
{
    public interface IMusiciansServices
    {
        List<Musician> GetAllMusicians();
        Musician GetMusicianById(string id);
    }
}
