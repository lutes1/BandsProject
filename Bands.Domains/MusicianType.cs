using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class MusicianType
    {
        public long MusicianId { get; set; }
        public string TypeName { get; set; }
        public List<Musician> Musician { get; set; }
    }
}
