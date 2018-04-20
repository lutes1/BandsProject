using Bands.Domains;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.DAL.Abstractions
{
    public interface IMusiciansRepository : IGenericRepository<Musician>
    {
        Musician GetMuscianById(string id);
        MusicianCommonDto GetMusicianCommonData();
    }
}