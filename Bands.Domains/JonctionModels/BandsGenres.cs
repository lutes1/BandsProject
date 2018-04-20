using Bands.Domains.Models;

namespace Bands.Domains.JonctionModels
{
    public class BandsGenres
    {
        public long GenreId { set; get; }
        public long BandId { get; set; }
        public Genre Genre { get; set; }
        public Band Band { get; set; }
    }
}
