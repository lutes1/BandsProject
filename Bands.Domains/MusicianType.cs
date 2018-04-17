using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class MusicianType
    {
        public long MusicianTypeId { get; set; }
        public string TypeName { get; set; }
        public List<Musician> Musician { get; set; }
    }
}