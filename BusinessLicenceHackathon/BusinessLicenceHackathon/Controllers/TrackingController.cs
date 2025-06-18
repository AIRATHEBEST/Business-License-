using Microsoft.AspNetCore.Mvc;

namespace BusinessLicenceHackathon.Controllers
{
    public class TrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
