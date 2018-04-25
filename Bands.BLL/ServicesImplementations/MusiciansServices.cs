using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Bands.BLL.Abstractions;
using Bands.DAL;
using Bands.DAL.Abstractions;
using Bands.Domains;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.BLL.ServicesImplementations
{
    public class MusiciansServices : IMusiciansServices
    {
        private readonly IMusicianTypeRepository _musicianTypeRepository;
        private readonly IMusiciansRepository _musiciansRepository;

        private readonly IInterestsRepository _interestsRepository;

        public MusiciansServices(IMusiciansRepository musiciansRepository, IInterestsRepository interestsRepository, IMusicianTypeRepository musicianTypeRepository)
        {
            _musicianTypeRepository = musicianTypeRepository;
            _musiciansRepository = musiciansRepository;
            _interestsRepository = interestsRepository;
        }
        public List<Musician> GetAllMusicians()
        {
            return _musiciansRepository.GetAll().ToList();
        }

        public Musician GetMusicianById(long id)
        {
            return _musiciansRepository.GetMuscianById(id);
        }

        public MusicianReadCommonDto GetMusicianCommonData()
        {
            return _musiciansRepository.GetMusicianCommonData();
        }



        public Musician CreateMusician(MusicianCreateDto musicianDto)
        {
           var interetsBindedList = new List<MusicianInterest>();

            if (!string.IsNullOrEmpty(musicianDto.Interests))
            {
                foreach (var interest in musicianDto.Interests.Split(','))
                {
                    interetsBindedList.Add(new MusicianInterest
                    {
                        Interest = _interestsRepository.CheckForStoredInterest(interest)
                    });
                }
            }

            var musician = new Musician
            {
                MapLocation = new MapLocation
                {
                    City = musicianDto.City,
                    Country = musicianDto.Country
                },
                Description = musicianDto.Description,
                MusicianType = CheckForStoredMusicianType(musicianDto.MusicianType),
                Interests = interetsBindedList,
                DisplayContactData = false
            };
            return musician;
        }

        public MusicianType CheckForStoredMusicianType(string musicianTypeName)
        {
            return _musicianTypeRepository.GetMusicianTypeByName(musicianTypeName)
                   ?? new MusicianType() { TypeName = musicianTypeName };
        }
    }
}
