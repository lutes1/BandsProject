using System.Collections.Generic;

namespace Bands.Domains
{
    public class Genre
    {
        public long GenreId { set; get; }
        public string Name { get; set; }
        public List<BandsGenres> BandsGenres { set; get; }
    }
}
