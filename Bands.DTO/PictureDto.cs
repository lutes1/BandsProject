using System;
using System.Collections.Generic;
using System.Text;
namespace Bands.DTO
{
    public class PictureDto
    {
        public long PictureId { get; set; }
        public string PictureName { get; set; }
        public string Path { get; set; }
        public Guid PictureGuid { get; set; }
    }
}
