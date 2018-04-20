using System.Collections.Generic;
using System.Linq;
using Bands.BLL.Abstractions;
using Bands.DAL.Abstractions;
using Bands.Domains;
using Bands.Domains.Models;

namespace Bands.BLL.ServicesImplementations
{
    public class BandsServices : IBandsServices
    {
        private readonly IBandsRepository _bandsRepository;
        public BandsServices(IBandsRepository bandsRepository)
        {
            _bandsRepository = bandsRepository;
        }
        public List<Band> GetAllBands()
        {
            return _bandsRepository.GetAll().ToList();
        }

        public Band GetBandById(long id)
        {
            return _bandsRepository.GetBandById(id);
        }
    }
}
