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
    }
}