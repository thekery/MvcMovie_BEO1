using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //
        // GET: /HellowWorld
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HellowWorld/Welcome
        // Parameter takes data from URL. - model binding

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }

    }
}
