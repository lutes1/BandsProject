using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class PictureViewModel
    {
        public long PictureId { get; set; }
        public string PictureName { get; set; }
        public string Path { get; set; }
        public Guid PictureGuid { get; set; }
    }
}
