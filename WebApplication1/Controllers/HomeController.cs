using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize(Policy = "RequireAdministratorRole")]
        //[Authorize(Roles = "Administrator")]
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Regulations()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Authorship()
        {
            return View(); 
        }

        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Offer()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult ComingSoon()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult ThankYou()
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