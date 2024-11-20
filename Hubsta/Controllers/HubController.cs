using Hubsta.Data;
using Hubsta.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hubsta.Controllers
{
    public class HubController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Post> posts = _context.Posts.ToList();
            return View(posts);
        }
        public IActionResult FindFriends()
        {
            List<AppUser> users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult FriendRequests()
        {
            return View();
        }
    }
}
