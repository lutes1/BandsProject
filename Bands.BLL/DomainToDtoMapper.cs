using System;
using System.Linq;
using AutoMapper;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.BLL
{
    public class DomainToDtoMapper : Profile
    {
        public DomainToDtoMapper()
        {
            CreateMap<Musician, MusicianReadDto>()
                .ForMember(
                    to => to.Interests,
                    from => from.MapFrom(musician => musician.Interests.Select(mi => mi.Interest)))
                .ForMember(
                    to => to.Bands,
                    from => from.MapFrom(musician => musician.MusicianBands.Select(mb => mb.Band.BandId)));
        }
    }
}
