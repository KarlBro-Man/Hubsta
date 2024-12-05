using Hubsta.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hubsta.Models
{
    public class FriendRelation
    {
        [Key]
        public int Id { get; set; }

        public FriendStatus Status { get; set; }
        [ForeignKey("AppUser")]
        public string? User1Id { get; set; }
        public AppUser? User1 { get; set; }
        [ForeignKey("AppUser")]
        public string? User2Id { get; set; }
        public AppUser? User2 { get; set; }

    }
}
