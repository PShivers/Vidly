using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CustomerDetails",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customers", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customers",
                url: "{controller}/{action}",
                defaults: new { controller = "Customers", action = "Index", }
            );

            routes.MapRoute(
                name: "Movies",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Detail", id = UrlParameter.Optional }
            );
        }
    }
}
