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
                    from => from.MapFrom(x => x.MusicianBands.Select(musicianBand => new
                    {
                        BandName = musicianBand.Band.BandName,
                        Genres = musicianBand.Band.BandsGenres.Select(bandGenre => bandGenre.Genre.Name)
                    })))
                .ForMember(
                    to => to.Demos,
                    from => from.MapFrom(musician => musician.Demos.Select(d => new {Link = d.Link, Name = d.Name})));
            CreateMap<Equipment, EquipmentDto>()
                .ForMember(
                    to => to.EquipmentType,
                    from => from.MapFrom(equipment => equipment.EquipmentType.Name));
        }
    }
}
