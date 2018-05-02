using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class EquipmentViewModel
    {
        public long EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Model { get; set; }
        public EquipmentTypevViewModel EquipmentType { get; set; }
    }
}
