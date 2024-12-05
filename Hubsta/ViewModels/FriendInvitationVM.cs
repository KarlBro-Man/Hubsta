using Hubsta.Data.Enum;

namespace Hubsta.ViewModels
{
    public class FriendInvitationVM
    {
        public FriendStatus Status { get; set; }
        public string? RequestingUserId { get; set; }
        public string? RecipientUserId { get; set; }
    }
}
