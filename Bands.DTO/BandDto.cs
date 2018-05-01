using System;
using System.Collections.Generic;
using System.Text;

namespace Bands.DTO
{
    public class BandDto
    {
        public long BandId { get; set; }
        public string BandName { set; get; }
        public long? PictureId { get; set; }
        public PictureDto Picture { get; set; }
        public List<MusicianReadDto> Musicians { get; set; }
        public List<GenreDto> BandsGenres { get; set; }
    }
}
