using Microsoft.AspNetCore.Mvc;

namespace data_std.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
