using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //sinon en utilisant [Route("Movie/List")]  : 
            routes.MapMvcAttributeRoutes();

            //route pour movie sans [Route... ] : 
            /*routes.MapRoute(
             "Movies",
             "movie/list",
             new { controller = "Movie", action = "Index" }
             );
            */

            routes.MapRoute(
            "MoviesByDate",
            "movies/released/{year}/{month}",
            new { Controller = "Movie", Action = "byRelease" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
