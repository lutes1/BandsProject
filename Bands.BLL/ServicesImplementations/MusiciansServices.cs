using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using AutoMapper;
using Bands.BLL.Abstractions;
using Bands.DAL;
using Bands.DAL.Abstractions;
using Bands.Domains;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;
using Bands.DTO;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Bands.BLL.ServicesImplementations
{
    public class MusiciansServices : IMusiciansServices
    {
        #region DependenciesInjection
        private readonly IMapper _mapper;
        private readonly IMusicianTypeRepository _musicianTypeRepository;
        private readonly IMusiciansRepository _musiciansRepository;
        private readonly IInterestsRepository _interestsRepository;

        public MusiciansServices(IMapper mapper,
                                 IMusiciansRepository musiciansRepository,
                                 IInterestsRepository interestsRepository,
                                 IMusicianTypeRepository musicianTypeRepository)
        {
            _mapper = mapper;
            _musicianTypeRepository = musicianTypeRepository;
            _musiciansRepository = musiciansRepository;
            _interestsRepository = interestsRepository;
        }
        #endregion
        public List<MusicianReadDto> GetAllMusicians()
        {
            return _mapper.Map<List<MusicianReadDto>>(_musiciansRepository.GetAll().ToList());
        }

        public MusicianReadDto GetMusicianById(long id)
        {
            var databaseMusician = _musiciansRepository.GetMuscianById(id);
            var musicianReadDto = _mapper.Map<MusicianReadDto>(databaseMusician);
            return musicianReadDto;
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

        public Musician GetMusicianForUpdate(long id)
        {
            return _musiciansRepository.GetMuscianById(id);
        }

        public void UpdateMusician(Musician musician)
        {
            _musiciansRepository.Update(musician);
        }

        public List<MusicianReadDto> GetMusiciansByName(string name)
        {

            return _mapper.Map<List<MusicianReadDto>>(_musiciansRepository.GetAll()
                .Where(x=>x.ApplicationUser.FirstName.ToLower().Contains(name.ToLower()) ||
                          x.ApplicationUser.LastName.ToLower().Contains(name.ToLower())));
        }

        public List<MusicianReadDto> GetMusiciansPaginated(int pageNumber, string name = null)
        {
            int pageSize = 5;
            var paginatedList = !string.IsNullOrEmpty(name) 
                ? GetMusiciansByName(name) 
                : GetAllMusicians();

            return paginatedList.Skip(pageSize * pageNumber).Take(pageSize).ToList();
        }

        public void UpdateMusicianPersonalData(long id, MusicianReadDto model)
        {
            var musician = GetMusicianForUpdate(id);

            if (model != null)
            {
                if (musician.ApplicationUser != null)
                {
                    musician.ApplicationUser.FirstName = model.ApplicationUser.FirstName ?? musician.ApplicationUser.FirstName;
                    musician.ApplicationUser.LastName = model.ApplicationUser.LastName ?? musician.ApplicationUser.LastName;
                    musician.ApplicationUser.PhoneNumber = model.ApplicationUser.PhoneNumber ?? musician.ApplicationUser.PhoneNumber;
                }

                musician.Description = model.Description ?? musician.Description;
                if (model.MapLocation != null)
                {
                    musician.MapLocation.City = model.MapLocation.City ?? musician.MapLocation.City;
                    musician.MapLocation.Country = model.MapLocation.Country ?? musician.MapLocation.Country;
                }
            }

            UpdateMusician(musician);
        }

        public void UpdateMusicianInterests(long id, string[] interestsModel)
        {
            var musician = GetMusicianForUpdate(id);

            //Remove the deleted interests from the musicians collection
            var musicianInterests = musician.Interests.Select(x => x.Interest.Name.Trim()).ToArray();
            foreach (var interest in musicianInterests)
            {
                if (!interestsModel.Any(x => x.Equals(interest.Trim())))
                {
                    musician.Interests.Remove(musician.Interests.FirstOrDefault(x => x.Interest.Name.Trim().Equals(interest)));
                }
            }

            //add the new interests to the collection
            foreach (var modelInterest in interestsModel)
            {
                if (!musician.Interests.Select(x => x.Interest.Name.Trim()).Any(x => x.Equals(modelInterest.Trim())))
                {
                    musician.Interests.Add(new MusicianInterest
                    {
                        Interest = new Interest { Name = modelInterest }
                    });
                }
            }
            //save
            UpdateMusician(musician);
        }

        public void RemoveMusicianEquipment(long musicianId, long equipmentId)
        {
            var musician = GetMusicianForUpdate(musicianId);

            musician.Equipments.Remove(musician.Equipments.FirstOrDefault(x => x.EquipmentId == equipmentId));

            UpdateMusician(musician);
        }

        public void AddMusicianEquipment(long musicianId,EquipmentDto equipmentModel)
        {
            var musician = GetMusicianForUpdate(musicianId);

            musician.Equipments.Add(new Equipment
            {
                EquipmentName = equipmentModel.EquipmentName,
                EquipmentType = new EquipmentType()
                {
                    Name = equipmentModel.EquipmentType
                },
                EquipmentModel = equipmentModel.EquipmentModel
            });

            UpdateMusician(musician);
        }

        public void AddDemo(long id, DemoDto demoDto)
        {
            var musician = GetMusicianForUpdate(id);

            musician.Demos.Add(new Demo
            {
                Name = demoDto.Name,
                Link = demoDto.Link
            });

            UpdateMusician(musician);
        }
    }
}
