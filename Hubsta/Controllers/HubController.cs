using Hubsta.Data;
using Hubsta.Models;
using Hubsta.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hubsta.Controllers
{
    public class HubController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public HubController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<Post> posts = _context.Posts.ToList();
            return View(posts);
        }
        public async Task<IActionResult> FindFriends()
        {
            FindFriendsVM vm = new FindFriendsVM();
            var user = await _userManager.GetUserAsync(User); 
            if (user == null)
            {
                return View("error");
            }
            var newUser = new UserVM()
            {
                UserId = user.Id
            };
            vm.User = newUser;
            List<AppUser> users = _context.Users.ToList();
            vm.Users = users;
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> SendRequest(FindFriendsVM model)
        {
            if(ModelState.IsValid)
            {
                var sendingId = model.FriendInvitations!.RequestingUserId;
                var recipientId = model.FriendInvitations!.RecipientUserId;

                var invitation = new FriendRelation()
                {
                    Status = Data.Enum.FriendStatus.Pending,
                    User1Id = sendingId,
                    User2Id = recipientId
                };

                _context.Add(invitation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Hub");
            }
            return RedirectToAction("Index", "Hub");
        }

        public async Task<IActionResult> FriendRequests()
        {
            //var query = "SELECT * FROM friendrelations WHERE Status = 0";
            //List<FriendRelation> requests = _context.FriendRelations.FromSqlRaw(query).ToList();
            var user = await _userManager.GetUserAsync(User);
            List<FriendRelation> requests = _context.FriendRelations
                .Where(r => r.Status == Data.Enum.FriendStatus.Pending && r.User2Id == user.Id)
                .Include(r => r.User1)
                .Include(r => r.User2)
                .ToList();
            return View(requests);
        }


    }
}
