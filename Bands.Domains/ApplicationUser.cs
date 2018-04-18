using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Bands.Domains
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? PictureId { get; set; }
        public Picture Picture { get; set; }
        public Musician Musician { get; set; }
    }
}