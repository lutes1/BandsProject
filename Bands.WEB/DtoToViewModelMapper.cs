using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bands.DTO;
using Bands.WEB.Models.ViewModels;

namespace Bands.WEB
{
    public class DtoToViewModelMapper : Profile
    {
        public DtoToViewModelMapper()
        {
            CreateMap<MusicianViewModel, MusicianReadDto>();
            CreateMap<MusiciansCommonDataViewModel, MusicianReadCommonDto>();
        }
    }
}
