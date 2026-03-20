using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Oth_demo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var role = "Admin" == "Admin" ? "Admin" : "User";
            if ((username == "Admin") && (password == "123") ||
                    (username == "User") && (password == "123"))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,username),
                    new Claim(ClaimTypes.Role,username)
                };

                var identity = new ClaimsIdentity(claims, "MyAuthCookie");
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyAuthCookie", principal);

                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Invalid Credentials";
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyAuthCookie");
            return RedirectToAction("Login");
        }
    }
}
