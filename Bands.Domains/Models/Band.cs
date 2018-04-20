using System.Collections.Generic;
using Bands.Domains.JonctionModels;

namespace Bands.Domains.Models
{
    public class Band
    {
        public long BandId { get; set; }
        public string BandName { set; get; }
        public long? PictureId { get; set; }
        public Picture Picture { get; set; }
        public List<MusicianBand> MusicianBands { get; set; }
        public List<BandsGenres> BandsGenres { get; set; }
    }
}
