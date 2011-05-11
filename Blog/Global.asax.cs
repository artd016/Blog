using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
            /*routes.MapRoute(
                "Detale", // Route name
                "{controller}/{action}/{year}/{month}/{day}", // URL with parameters
                new { controller = "Admin", action = "Detale",year=@"\d{4}", month=@"\d{2}", day=@"\d{2}"}
            );*/

            routes.MapRoute(
                "Detale", // Route name
                "{controller}/{action}/{year}", // URL with parameters
                new { controller = "Admin", action = "Detale",year=@"\d{4}"}
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}