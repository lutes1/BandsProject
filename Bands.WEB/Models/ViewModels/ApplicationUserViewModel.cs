using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class ApplicationUserViewModel
    {
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        public PictureViewModel Picture { get; set; }
        public MusicianViewModel Musician { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
