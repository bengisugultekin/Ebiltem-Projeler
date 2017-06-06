using System.Web.Mvc;
using System.Web.Routing;

namespace Projeler.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "anasayfa",
               url: "Anasayfa",
               defaults: new { controller = "Home", action = "Search", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Detay",
               url: "Detay/{id}",
               defaults: new { controller = "Home", action = "Detail", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Search", id = UrlParameter.Optional }
            );
        }
    }
}
