using Intro_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Intro_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Biography()
        {
            return View();
        }

        public IActionResult Tvoru()
        {
            return View();
        }

        public IActionResult Other()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
