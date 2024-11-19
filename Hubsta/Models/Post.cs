using System.ComponentModel.DataAnnotations.Schema;

namespace Hubsta.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? PostTitle { get; set; }
        public string? PostBody { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
