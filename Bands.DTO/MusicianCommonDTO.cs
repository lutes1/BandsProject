using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.DTO
{
    public class MusicianCommonDto
    {
        public List<string> Cities { get; set; }
        public List<string> Countries { get; set; }
        public List<string> MusicianTypes { get; set; }
        public List<string> Interests { get; set; }

        public MusicianCommonDto()
        {
            Cities = new List<string>();
            Countries = new List<string>();
            MusicianTypes = new List<string>();
            Interests = new List<string>();
        }
    }
}
