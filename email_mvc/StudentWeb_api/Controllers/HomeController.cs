using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StudentWeb_api.Model;

namespace StudentWeb_api.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppSettings _settings;

        public HomeController(IOptions<AppSettings> options)
        {
            _settings = options.Value;   
        }

        public IActionResult Index()
        {
            return  Content(
                $"Name of the Application: {_settings.ApplicationName}\n"+
                $"Support: {_settings.SupportEmail}");
        }
    }
}
