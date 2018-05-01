using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.DTO
{
    public class EquipmentDto
    {
        public long EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Model { get; set; }
        public EquipmentTypeDto EquipmentType { get; set; }
    }
}
