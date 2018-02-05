using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // e.g. https://www.codeproject.com/Articles/641783/Customizing-Routes-in-ASP-NET-MVC
            // HelloWorld
            //routes.MapRoute(
            //    name: "HelloWorld",
            //    url: "HelloWorld/{action}/{id}",
            //    defaults: new { controller = "HelloWorld", action = "All", id = UrlParameter.Optional }
            //);

            // Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
