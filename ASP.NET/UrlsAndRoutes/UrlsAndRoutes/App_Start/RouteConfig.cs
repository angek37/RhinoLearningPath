using System.Web.Mvc;
using System.Web.Routing;

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

            routes.MapMvcAttributeRoutes(); // Enabling Attribute Routing

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

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                });
        }
    }
}
