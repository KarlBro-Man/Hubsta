using Hubsta.Models;

namespace Hubsta.ViewModels
{
    public class FindFriendsVM
    {
        public List<AppUser>? Users { get; set; }
        public FriendInvitationVM? FriendInvitations { get; set; }
        public UserVM? User { get; set; }
    }
}
