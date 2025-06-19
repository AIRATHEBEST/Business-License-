using System.Diagnostics;
using BusinessLicenceHackathon.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLicenceHackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]

        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitPayment(string CardName, string CardNumber, string Expiry, string CVV, decimal Amount)
        {
            // Simulate payment success
            ViewBag.PaymentSuccess = true;
            return View("Payment");
        }

        public IActionResult SubmitContact(string Name, string Email, string Message)
        {
            // You could log it, save to DB, or send email here
            ViewBag.Success = true;
            return View("Contact");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
