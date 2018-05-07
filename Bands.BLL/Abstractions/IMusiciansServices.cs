using System;
using System.Collections.Generic;
using Bands.Domains;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.BLL.Abstractions
{
    public interface IMusiciansServices
    {
        MusicianReadDto GetMusicianById(long id);
        MusicianReadCommonDto GetMusicianCommonData();
        Musician CreateMusician(MusicianCreateDto musician);
        MusicianType CheckForStoredMusicianType(string musicianTypeName);
        Musician GetMusicianForUpdate(long id);
        void UpdateMusician(Musician musician);
        List<MusicianReadDto> GetMusiciansPaginated(int pageNumber,  string name);
        void UpdateMusicianPersonalData(long id, MusicianReadDto model);
        void UpdateMusicianInterests(long id, string[] newInterests);
        void RemoveMusicianEquipment(long musicianId,long equipmentId);
        void AddMusicianEquipment(long muisicianId, EquipmentDto equipmentModel);
        void AddDemo(long id, DemoDto demoDto);
    }
}