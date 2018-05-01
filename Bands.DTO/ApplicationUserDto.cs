using System;
using System.Collections.Generic;
using System.Text;
using Bands.Domains.Models;

namespace Bands.DTO
{
    public class ApplicationUserDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PictureDto Picture { get; set; }
        public MusicianReadDto Musician { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}