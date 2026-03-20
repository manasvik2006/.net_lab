using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Oth_demo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminOnly  ()
            {
                return Content("Admin Access Granted");
        }

        [Authorize(Roles = "User")]
        public IActionResult UserOnly()
        {
            return Content("User Access Granted");
        }
    }
}
