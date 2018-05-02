using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bands.Domains.Models;
using Bands.DTO;

namespace Bands.WEB.Models.ViewModels
{
    public class MusicianViewModel
    {
        public long Likes { get; set; }
        public string Description { get; set; }
        public MapLocationViewModel MapLocation { get; set; }
        public MusicianTypeViewModel MusicianType { get; set; }
        public List<InterestViewModel> Interests { get; set; }
        public List<long> Bands { get; set; }
        public List<EquipmentViewModel> Equipments { get; set; }
        public long ApplicationUserId { set; get; }
        public bool DisplayContactData { get; set; }
        public List<DemoViewModel> Demos { get; set; }
        public ApplicationUserViewModel ApplicationUser { get; set; }
    }
}
