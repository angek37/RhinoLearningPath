using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.MapRoute("ShopSchema2", "Shop/OldAction",
            //    new {controller = "Home", action = "Index"});

            //routes.MapRoute("ShopSchema", "Shop/{action}",
            //    new {controller = "Home"});

            //routes.MapRoute("", "X{controller}/{action}");

            //routes.MapRoute("MyRoute", "{controller}/{action}",
            //    new { controller = "Home", action = "Index" });

            //routes.MapRoute("", "Public/{controller}/{action}",
            //    new { controller = "Home", action = "Index" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            //    new {controller = "Home", action = "Index", id = "DefaultId"});

            // ESPECIFICAR CUAL CONTROLADOR ELEGIR POR NAMESPACE, CUANDO SE REPITEN
            //var myRoute = routes.MapRoute("AddControllerRouter", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] {"URLsAndRoutes.AdditionalControllers"});

            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            // Esta ruta solo funciona cuando el agent es Chrome
            //var myRoute = routes.MapRoute("ChromeRoute", "{*catchall}",
            //    new {controller = "Home", action = "Index"},
            //    new {customConstraint = new UserAgentConstraint("Chrome")},
            //    new[] {"UrlAndRoutes.AdditionalControllers"});

            //myRoute.DataTokens["UseNamespaceFallback"] = false;


            // Value Constraints
            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new {controller = "Home", action = "Index", id = UrlParameter.Optional},
            //    new
            //    {
            //        controller = "^H.*", action = "Index|About",
            //        httpMethod = new HttpMethodConstraint("GET"),
            //        id = new CompoundRouteConstraint(new IRouteConstraint[]
            //        {
            //            new AlphaRouteConstraint(), 
            //            new MinLengthRouteConstraint(6), 
            //        })
            //    },
            //    new[] {"URLsAndRoutes.Controllers"});


            // Ya no se ocupa el array para especificar el namespace
            // porque no hay ambiguedad de nombres de controllers
            //routes.MapRoute("Default", "{controller}/{action}/{id}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    },
            //    new[] { "UrlsAndRoutes.Controllers" });

            // Para que el id lo coloque en un segmento separado, elimino esta ruta
            //routes.MapRoute("NewRoute", "App/Do{action}",
            //    new {controller = "Home"});

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    });

            routes.RouteExistingFiles = true;

            routes.MapMvcAttributeRoutes(); // Enabling Attribute Routing

            routes.IgnoreRoute("Content/{filename}.html");

            routes.Add(new Route("SayHello", new CustomRouteHandler()));

            routes.Add(new LegacyRoute(
                "~/articles/Windows_3.1_Overview.html",
                "~/old/.NET_1.0_Class_Library"));

            routes.MapRoute("MyRoute", "{controller}/{action}", null,
                new[] {"UrlsAndRoutes.Controllers"});
            routes.MapRoute("MyOtherRoute", "App/{action}", new {controller = "Home"},
                new[] {"UrlsAndRoutes.Controllers"});
        }
    }
}
