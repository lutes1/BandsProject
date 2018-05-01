using System.Collections.Generic;
using Bands.Domains.JonctionModels;

namespace Bands.Domains.Models
{
    public class Genre
    {
        public long GenreId { set; get; }
        public string Name { get; set; }
        public List<BandsGenres> BandsGenres { set; get; }
    }
}