using Microsoft.AspNetCore.Identity;

namespace Hubsta.Models
{
    public class AppUser : IdentityUser
    {
        public string? Post {  get; set; }
        public string? Bio { get; set; }

    }
}
