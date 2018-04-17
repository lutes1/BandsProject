using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bands.Domains
{
    public class Musician
    {
        public long Likes { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public MusicianType MusicianType { get; set; }
        public List<MusicianInterest> Interests { get; set; }
        public List<MusicianBand> MusicianBands { get; set; }
        public List<Equipment> Equipments { get; set; }
        public string ApplicationUserId { set; get; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
