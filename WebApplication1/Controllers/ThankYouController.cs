using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ThankYouController : Controller
    {
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
