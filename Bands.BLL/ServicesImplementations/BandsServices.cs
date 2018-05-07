using System.Collections.Generic;
using System.Linq;
using Bands.BLL.Abstractions;
using Bands.DAL.Abstractions;
using Bands.Domains;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;
using Bands.DTO;

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

        public void CreateBand(long musicianId, BandDto bandModel)
        {
            var bandsGenres = new List<BandsGenres>();

            foreach (var genre in bandModel.Genres)
            {
                bandsGenres.Add(new BandsGenres
                {
                    Genre = new Genre
                    {
                        Name = genre
                    }
                });
            }

            var bandToAdd = new Band
            {
                BandName = bandModel.BandName,
                BandsGenres = bandsGenres,
                MusicianBands = new List<MusicianBand>
                {
                    new MusicianBand()
                    {
                        MusicianId = musicianId
                    }
                }
            };

            _bandsRepository.Add(bandToAdd);
        }
    }
}
