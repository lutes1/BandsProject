using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class Equipment
    {
        public long EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public Musician Musician { get; set; }
    }
}
