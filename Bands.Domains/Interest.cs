using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains
{
    public class Interest
    {
        public long InterestId { get; set; }
        public string Name { get; set; }
        public List<MusicianInterest> MusicianInterests { set; get; }
    }
}
