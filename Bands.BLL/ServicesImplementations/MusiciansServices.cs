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
        private IMusicianTypeRepository _musicianTypeRepository { get; }
        private readonly IMusiciansRepository _musiciansRepository;
        private readonly IMusicianInterestsRepository _musicianInterestsRepository;

        private readonly IInterestsRepository _interestsRepository;

        public MusiciansServices(IMusiciansRepository musiciansRepository, IMusicianInterestsRepository musicianInterestsRepository, IInterestsRepository interestsRepository, IMusicianTypeRepository musicianTypeRepository)
        {
            _musicianTypeRepository = musicianTypeRepository;
            _musiciansRepository = musiciansRepository;
            _musicianInterestsRepository = musicianInterestsRepository;
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

        

        public void CreateMusician(MusicianCreateDto musicianDto)
        {
            var musicianType = new MusicianType() {TypeName = musicianDto.MusicianType};

            var storedMusicianType = _musicianTypeRepository.GetMusicianTypeByName(musicianDto.MusicianType);

            if (storedMusicianType != null)
                musicianType = storedMusicianType;

            var musician = new Musician
            {
                MapLocation = new MapLocation() { City = musicianDto.City, Country = musicianDto.Country },
                ApplicationUser = musicianDto.ApplicationUser,
                Description = musicianDto.Description,
                MusicianType = musicianType
            };

            var interetsBindedList = new List<MusicianInterest>();


            foreach (var interest in musicianDto.Interests.Split(','))
            {
                var musicianInterest = new Interest
                {
                    Name = interest
                };

                var storedInterest = _interestsRepository.GetInterestByName(interest);

                if (storedInterest != null)
                    musicianInterest = storedInterest;

                interetsBindedList.Add(new MusicianInterest
                {
                    Musician = musician,
                    Interest = musicianInterest
                });
            }

            _musicianInterestsRepository.CreateInterest(interetsBindedList);
        }
    }
}
