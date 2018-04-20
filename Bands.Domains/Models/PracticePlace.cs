using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bands.Domains.Models
{
    public class PracticePlace
    {
        public long MapLocationId { get; set; }

        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Picture> Pictures { get; set; }
        public MapLocation MapLocation { get; set; }
        public string Description { get; set; }
    }
}