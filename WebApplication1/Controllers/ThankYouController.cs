using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ThankYouController : Controller
    {
        [AllowAnonymous]
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
