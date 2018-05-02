using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class MapLocationViewModel
    {
        public long MapLocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
