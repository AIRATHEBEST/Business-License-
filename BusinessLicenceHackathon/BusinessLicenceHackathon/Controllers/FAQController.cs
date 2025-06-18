using Microsoft.AspNetCore.Mvc;

namespace BusinessLicenceHackathon.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
