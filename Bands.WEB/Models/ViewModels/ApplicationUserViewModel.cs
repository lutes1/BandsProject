using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class ApplicationUserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PictureViewModel Picture { get; set; }
        public MusicianViewModel Musician { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
