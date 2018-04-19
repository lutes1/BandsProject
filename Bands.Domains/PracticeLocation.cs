using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bands.Domains
{
    public class PracticeLocation
    {
        public long PracticeLocationId { get; set; }
        [Column(TypeName = "numeric(18,6)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "numeric(18,6)")]
        public decimal Longitude { get; set; }
        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Picture> Pictures { get; set; }
        public string Description { get; set; }
    }
}