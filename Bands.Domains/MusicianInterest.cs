using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class MusicianInterest
    {
        public long InterestId { get; set; }
        public long MusicianId { get; set; }
        public Interest Interest { get; set; }
        public Musician Musician { get; set; }
    }
}
