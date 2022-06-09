using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class RegulationsController : Controller
    {
        public IActionResult Regulations()
        {
            return View();
        }
    }
}
