﻿using Microsoft.AspNetCore.Identity;

namespace Hubsta.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Post {  get; set; }
        public string? Bio { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
