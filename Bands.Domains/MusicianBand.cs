using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class MusicianBand
    {
        public long MusicianId { get; set; }
        public long BandId { get; set; }
        public Musician Musician { get; set; }
        public Band Band { get; set; }
    }
}
