using Microsoft.AspNetCore.Mvc;

namespace BusinessLicenceHackathon.Controllers
{
    public class TrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Status()
        {
            return View();
        }
    }
}
