using Microsoft.AspNetCore.Mvc;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
