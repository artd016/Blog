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
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("PageingY",
                "{controller}/{action}/{year}/Page/{page}",
                new { controller = "Administracja", action = "Post" },
                new { year = @"\d{4}" });

            routes.MapRoute("PageingYM",
               "{controller}/{action}/{year}/{month}/Page/{page}",
               new { controller = "Administracja", action = "Post" },
               new { year = @"\d{4}", month = @"\d{2}" });

            routes.MapRoute("PageingYMD",
                "{controller}/{action}/{year}/{month}/{day}/Page/{page}",
                new { controller = "Administracja", action = "Post" },
                new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });

            routes.MapRoute(
                "Pageing", // Route name
                "{controller}/{action}/Page/{page}", // URL with parameters
                new { controller = "Administracja", action = "WyswietlPosty" } // Parameter defaults
            );

            routes.MapRoute("Post",
                "{controller}/{action}/{year}/{month}/{day}/{id}",
                new { controller = "Administracja", action = "Post" },
                new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });

            
            routes.MapRoute("blog2",
                "{controller}/{action}/{year}",
                new { controller = "Administracja", action = "Post" },
                new { year = @"\d{4}" });           

            routes.MapRoute("blog1",
               "{controller}/{action}/{year}/{month}",
               new { controller = "Administracja", action = "Post" },
               new { year = @"\d{4}", month = @"\d{2}" });

            routes.MapRoute("blog",
                "{controller}/{action}/{year}/{month}/{day}",
                new { controller = "Administracja", action = "Post" },
                new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" });

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}