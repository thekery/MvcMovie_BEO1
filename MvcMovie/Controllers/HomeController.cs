using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Diagnostics;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            return View();
        }

        // GET: Home/Privacy
        public IActionResult Privacy()
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
