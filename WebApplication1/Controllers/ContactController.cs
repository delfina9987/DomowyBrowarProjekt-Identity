using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
