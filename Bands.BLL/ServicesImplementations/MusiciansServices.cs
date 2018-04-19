using System.Collections.Generic;
using System.Linq;
using Bands.BLL.Abstractions;
using Bands.DAL;
using Bands.DAL.Abstractions;
using Bands.Domains;

namespace Bands.BLL.ServicesImplementations
{
    public class MusiciansServices : IMusiciansServices
    {
        private readonly IMusiciansRepository _musiciansRepository;

        public MusiciansServices( IMusiciansRepository musiciansRepository)
        {
            _musiciansRepository = musiciansRepository;
        }
        public List<Musician> GetAllMusicians()
        {
            return _musiciansRepository.GetAll().ToList();
        }

        public Musician GetMusicianById(string id)
        {
            return _musiciansRepository.GetMuscianById(id);
        }
    }
}
