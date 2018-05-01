using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.DTO
{
    public class PracticePlaceDto
    {
        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<PictureDto> Pictures { get; set; }
        public MapLocationDto MapLocation { get; set; }
        public string Description { get; set; }
    }
}
