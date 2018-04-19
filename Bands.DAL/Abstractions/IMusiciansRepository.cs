using Bands.Domains;

namespace Bands.DAL.Abstractions
{
    public interface IMusiciansRepository : IGenericRepository<Musician>
    {
        Musician GetMuscianById(string id);
    }
}