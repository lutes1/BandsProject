using System;
using System.Collections.Generic;
using Bands.Domains;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.BLL.Abstractions
{
    public interface IMusiciansServices
    {
        List<MusicianReadDto> GetAllMusicians();
        MusicianReadDto GetMusicianById(long id);
        MusicianReadCommonDto GetMusicianCommonData();
        Musician CreateMusician(MusicianCreateDto musician);
        MusicianType CheckForStoredMusicianType(string musicianTypeName);
    }
}