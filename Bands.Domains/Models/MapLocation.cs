using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bands.Domains.Models
{
    public class MapLocation
    {
        public long MapLocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<Musician> Musician { get; set; }
        public PracticePlace PracticePlace { get; set; }
    }
    
}

