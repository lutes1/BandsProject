namespace Bands.Domains.Models
{
    public class Equipment
    {
        public long EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Model { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public Musician Musician { get; set; }
    }
}