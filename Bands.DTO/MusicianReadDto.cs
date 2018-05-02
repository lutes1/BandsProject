using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;

namespace Bands.DTO
{
    public class MusicianReadDto
    {
        public long Likes { get; set; }
        public string Description { get; set; }
        public MapLocationDto MapLocation { get; set; }
        public MusicianTypeDto MusicianType { get; set; }
        public List<InterestDto> Interests { get; set; }
        public List<long> Bands { get; set; }
        public List<DemoDto> DemosDto { get; set; }
        public List<EquipmentDto> Equipments { get; set; }
        public long ApplicationUserId { set; get; }
        public bool DisplayContactData { get; set; }
        public ApplicationUserDto ApplicationUser { get; set; }
    }
}
