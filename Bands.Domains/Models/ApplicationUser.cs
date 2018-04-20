using Microsoft.AspNetCore.Identity;

namespace Bands.Domains.Models
{
    public class ApplicationUser : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? PictureId { get; set; }
        public Picture Picture { get; set; }
        public Musician Musician { get; set; }
    }
}