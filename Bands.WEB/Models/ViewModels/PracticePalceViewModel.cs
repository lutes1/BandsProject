using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class PracticePalceViewModel
    {
        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<PictureViewModel> Pictures { get; set; }
        public MapLocationViewModel MapLocation { get; set; }
        public string Description { get; set; }
    }
}
