using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class OfferController : Controller
    {
        [AllowAnonymous]
        public IActionResult Offer()
        {
            return View();
        }
    }
}
