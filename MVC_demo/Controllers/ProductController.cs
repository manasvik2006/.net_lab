using Microsoft.AspNetCore.Mvc;
using MVC_demo.Models;

namespace MVC_demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //var products = new List<Product>

            List<Product> products = new List<Product>()         //first commit
            {
                new Product {Id=1, Name="Milk",Price=30},
                new Product {Id=2, Name= "Egg", Price= 9 },
                new Product {Id=3,Name= "Bread", Price=45}
            };
            return View(products);
        }
    }
}
