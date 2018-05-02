using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.Domains.Models
{
    public class Demo
    {
        public long DemoId { get; set; }
        public Musician Musician { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
