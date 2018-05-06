using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class PictureViewModel
    {
        public long PictureId { get; set; }
        [StringLength(20)]
        public string PictureName { get; set; }
        [StringLength(200)]
        public string Path { get; set; }
        public Guid PictureGuid { get; set; }
    }
}
