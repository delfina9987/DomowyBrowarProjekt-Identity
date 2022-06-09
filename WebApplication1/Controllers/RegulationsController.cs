using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class RegulationsController : Controller
    {
        [AllowAnonymous]
        public IActionResult Regulations()
        {
            return View();
        }
    }
}
