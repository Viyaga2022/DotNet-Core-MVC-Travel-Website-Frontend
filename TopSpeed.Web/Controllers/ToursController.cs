using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TopSpeed.Web.Models;

namespace TopSpeed.Web.Controllers
{
    public class ToursController : Controller
    {
        public IActionResult Index()
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
