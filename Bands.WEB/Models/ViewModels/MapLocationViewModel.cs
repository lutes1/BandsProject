using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class MapLocationViewModel
    {
        public long MapLocationId { get; set; }
        [StringLength(30)]
        public string Country { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
    }
}
