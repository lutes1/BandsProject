using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;

namespace Bands.DTO
{
    public class MapLocationDto
    {
        public long MapLocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
