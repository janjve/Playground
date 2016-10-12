using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Flashcard
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Could handle

            routes.MapRoute(
                name: "Default",
                url: "{*url}",
                namespaces: new string[] { "Flashcard.Controllers" },
                defaults: new { controller = "Web", action = "Default" }
            );
        }
    }
}
