using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public ActionResult ProduceOutput()
        {
            //if (Server.MachineName == "DELL-MIGUEL")
            //{
            //    //Response.Redirect("/Basic/Index");
            //    // Remplaza por una implementación propia de un ActionResult
            //    return new CustomRedirectResult
            //    {
            //        Url = "/Basic/Index"
            //    };
            //}
            //else
            //{
            //    Response.Write("Machine name: " + Server.MachineName + ", Controller: Derived, Action: ProduceOutput");
            //    return null;
            //}
            
            //return new RedirectResult("/Basic/Index"); // Se sustituye por la implementación propia de Microsoft
            // También puede sustituirse por el método Convenience
            return Redirect("/Basic/Index");
        }
    }
}