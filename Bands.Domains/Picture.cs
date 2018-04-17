using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bands.Domains
{
    public class Picture    
    {
        public long PictureId { get; set; }

        [Required]
        [MaxLength(20)]
        public string PictureName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Path { get; set; }

        [Required]
        public Guid PictureGuid { get; set; }

        public Band Band { get; set; }

        //todo userr
    }
}