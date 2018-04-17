using System;
using System.ComponentModel.DataAnnotations;

namespace Bands.Domains
{
    public class Picture    
    {
        public long PictureId { get; set; }
        public string PictureName { get; set; }
        public string Path { get; set; }
        public Guid PictureGuid { get; set; }

        public long BandId { get; set; }
        public Band Band { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}