using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class BandViewModel
    {
        public long BandId { get; set; }
        public string BandName { set; get; }
        public long? PictureId { get; set; }
        public PictureViewModel Picture { get; set; }
        public List<MusicianViewModel> Musicians { get; set; }
        public List<GenreViewModel> BandsGenres { get; set; }
    }
}
