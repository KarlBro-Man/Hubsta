using Hubsta.Data;
using Hubsta.Models;
using Hubsta.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            var user = await _userManager.GetUserAsync(User); 
            if (user == null)
            {
                return View("error");
            }
            List<AppUser> users = _context.Users.ToList();
            FindFriendsVM vm = new FindFriendsVM();
            vm.Users = users;
            var newUser = new UserVM()
            {
                UserId = user.Id
            };
            vm.User = newUser;
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> SendRequest(FindFriendsVM model)
        {
            var sendingId = model.FriendInvitations!.RequestingUserId;
            var recipientId = model.FriendInvitations!.RecipientUserId;
            return RedirectToAction("Index", "Hub");
        }

        //public IActionResult FriendRequests()
        //{
        //    return View();
        //}


    }
}
