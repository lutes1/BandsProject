using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.DTO
{
    public class BandDto
    {
        public string BandName { set; get; }
        public List<string> Genres { get; set; }
    }
}
