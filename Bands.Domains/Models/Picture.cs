using System;

namespace Bands.Domains.Models
{
    public class Picture    
    {
        public long PictureId { get; set; }
        public string PictureName { get; set; }
        public string Path { get; set; }
        public Guid PictureGuid { get; set; }

        public Band Band { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public PracticePlace PracticePlace { get; set; }
    }
}