using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //
        // GET: /HellowWorld
        public string Index()
        {
            return "This is my default action!";
        }

        //
        // GET: /HellowWorld/Welcome
        // Parameter takes data from URL. - model binding
        // Otherwise uses default values. (no value, 1)

        /*
         public string Welcome(string name, int numTimes = 1)
         {
             return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
         }
        */
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
