using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        // example 1
        //public string Index()
        //{
        //    return "<div>This is my <strong>default</strong> action...</div>";
        //}

        // example 2 - Using a view
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/

        // example 1
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // example 2 - using parameters part 1
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        // example 3 - using parameters part 2
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}

        // example 4 - using view
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        //public ActionResult Index()
        //{
        //    return View ();
        //}
    }
}
