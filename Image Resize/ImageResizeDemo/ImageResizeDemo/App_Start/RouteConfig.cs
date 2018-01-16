using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ImageResizeDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BrowserCheck", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "image",
                url: "{controller}/{id}",
                defaults: new { controller = "Image", id = UrlParameter.Optional }
            );
        }
    }
}
