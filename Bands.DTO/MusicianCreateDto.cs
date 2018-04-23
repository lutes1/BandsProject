using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.JonctionModels;
using Bands.Domains.Models;

namespace Bands.DTO
{
    public class MusicianCreateDto
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string MusicianType { get; set; }
        public string Interests { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
