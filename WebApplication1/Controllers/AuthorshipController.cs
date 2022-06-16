using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthorshipController : Controller
    {
        [AllowAnonymous]
        public IActionResult Authorship()
        {
            return View();
        }
    }
}
