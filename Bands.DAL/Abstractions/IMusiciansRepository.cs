using Bands.Domains;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.DAL.Abstractions
{
    public interface IMusiciansRepository : IGenericRepository<Musician>
    {
        Musician GetMuscianById(long id);
        MusicianReadCommonDto GetMusicianCommonData();
        void MusicianCreate(Musician musician);
    }
}