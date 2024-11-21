using Hubsta.Data.Enum;

namespace Hubsta.ViewModels
{
    public class FriendInvitationVM
    {
        public FriendStatus Status { get; set; }
        public string? User1Id { get; set; }
        public string? User2Id { get; set; }
    }
}
