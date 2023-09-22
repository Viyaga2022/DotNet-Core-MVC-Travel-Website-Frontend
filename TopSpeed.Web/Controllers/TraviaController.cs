using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TopSpeed.Web.Models;

namespace TopSpeed.Web.Controllers
{
    public class TraviaController : Controller
    {
        private readonly ILogger<TraviaController> _logger;

        public TraviaController(ILogger<TraviaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Destinations()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}