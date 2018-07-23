using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id = "DefaultId")
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = id;
            //ViewBag.CustomVariable = RouteData.Values["id"];
            return View();
        }

        //public ViewResult MyActionMethod()
        //{
        //    string myActionUrl = Url.Action("Index", new { id = "MyID" });
        //    string myRouteUrl = Url.RouteUrl(new
        //    {
        //        controller = "Home",
        //        action = "Index"
        //    });
        //    return View();
        //}

        //Redirigir a otra acción en el mismo controller
        //public RedirectToRouteResult MyActionMethod()
        //{
        //    return RedirectToAction("Index");
        //}

        // Enviar un redirect usando un URL Generado
        public RedirectToRouteResult MyActionMethod()
        {
            return RedirectToRoute(new
            {
                controller = "Home",
                Action = "Index",
                id = "MyID"
            });
        }
    }
}