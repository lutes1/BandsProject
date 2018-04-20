using System.Collections.Generic;

namespace Bands.Domains.Models
{
    public class EquipmentType
    {
        public long EquipmentTypeId { get; set; }
        public string Name { set; get; }
        public List<Equipment> Equipments { get; set; }
    }
}
