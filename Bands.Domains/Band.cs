using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bands.Domains
{
    public class Band
    {
        public long BandId { get; set; }
        public string BandName { set; get; }
        public Picture Picture { get; set; }
        public List<Musician> Musicians { get; set; }
    }
}
