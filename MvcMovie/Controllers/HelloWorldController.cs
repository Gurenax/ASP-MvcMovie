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

        public string Index()
        {
            return "<div>This is my <strong>default</strong> action...</div>";
        }

        //
        // GET: /HelloWorld/Welcome/

        // example 1
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // example 2
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        // example 3
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
        //public ActionResult Index()
        //{
        //    return View ();
        //}
    }
}
