using System.Collections.Generic;
using Bands.Domains.JonctionModels;

namespace Bands.Domains.Models
{
    public class Musician
    {
        public long Likes { get; set; }
        public string Description { get; set; }
        public MapLocation MapLocation { get; set; }
        public MusicianType MusicianType { get; set; }
        public List<MusicianInterest> Interests { get; set; }
        public List<MusicianBand> MusicianBands { get; set; }
        public List<Equipment> Equipments { get; set; }
        public long ApplicationUserId { set; get; }
        public bool DisplayContactData { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Demo> Demos { get; set; }
    }
}
