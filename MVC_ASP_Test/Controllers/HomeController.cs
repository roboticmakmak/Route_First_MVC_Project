using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MVC_ASP_Test.Controllers
{
    public class HomeController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
