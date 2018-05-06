using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class BandViewModel
    {
        public BandViewModel()
        {
            Musicians = new List<MusicianViewModel>();
            Genres = new List<string>();
        }
        public long BandId { get; set; }
        public string BandName { set; get; }
        public PictureViewModel Picture { get; set; }
        public List<MusicianViewModel> Musicians { get; set; }
        public List<string> Genres { get; set; }
    }
}
