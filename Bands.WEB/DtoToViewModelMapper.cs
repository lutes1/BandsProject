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
            CreateMap<MusicianReadDto, MusicianViewModel>();
            CreateMap<EquipmentDto, EquipmentViewModel>()
                .ForMember(
                    to => to.EquipmentType,
                    from => from.MapFrom(x => x.EquipmentType.Name))
                .ForMember(
                    to => to.EquipmentModel,
                    from => from.MapFrom(x => x.Model));

            CreateMap<MusicianReadCommonDto, MusiciansCommonDataViewModel>();
        }
    }
}
