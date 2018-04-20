using Bands.Domains.Models;

namespace Bands.Domains.JonctionModels
{
    public class MusicianInterest
    {
        public long InterestId { get; set; }
        public long MusicianId { get; set; }
        public Interest Interest { get; set; }
        public Musician Musician { get; set; }
    }
}
