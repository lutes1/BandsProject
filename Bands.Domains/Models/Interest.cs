using System.Collections.Generic;
using Bands.Domains.JonctionModels;

namespace Bands.Domains.Models
{
    public class Interest
    {
        public long InterestId { get; set; }
        public string Name { get; set; }
        public List<MusicianInterest> MusicianInterests { set; get; }
    }
}
