using Bands.Domains.Models;

namespace Bands.Domains.JonctionModels
{
    public class MusicianBand
    {
        public long MusicianId { get; set; }
        public long BandId { get; set; }
        public Musician Musician { get; set; }
        public Band Band { get; set; }
    }
}
