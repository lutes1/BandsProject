using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class EquipmentType
    {
        public long EquipmentTypeId { get; set; }
        public string Name { set; get; }
        public List<Equipment> Equipments { get; set; }
    }
}
