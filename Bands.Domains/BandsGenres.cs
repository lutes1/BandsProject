namespace Bands.Domains
{
    public class BandsGenres
    {
        public long GenereId { set; get; }
        public long BandId { get; set; }
        public Genre Genre { get; set; }
        public Band Band { get; set; }
    }
}
