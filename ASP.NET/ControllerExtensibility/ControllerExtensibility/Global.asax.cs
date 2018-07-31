using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ControllerExtensibility.Infrastructure;

namespace ControllerExtensibility
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Custom Controller Factory
            //ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            // Built-in Controller Factory
            // Prioritizing Namespaces
            ControllerBuilder.Current.DefaultNamespaces.Add("MyControllerNamespace");
            ControllerBuilder.Current.DefaultNamespaces.Add("MyController.*");

            // Use Custom Activator
            ControllerBuilder.Current.SetControllerFactory(
                new DefaultControllerFactory(new CustomControllerActivator()));
        }
    }
}
