using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            //DateTime date = DateTime.Now;
            //return View(date);
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        // Usar literales no es la forma más correcta
        // un cambio en el schema de rutas y causa conflicto
        //public RedirectResult Redirect()
        //{
        //    return Redirect("/Example/Index");
        //}

        // También podemos redirigir al action method directamente
        //public RedirectToRouteResult Redirect()
        //{
        //    return RedirectToRoute(new
        //    {
        //        controller = "Example",
        //        action = "Index",
        //        Id = "MyID"
        //    });
        //}

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Index", "Basic");
        }

        public HttpStatusCodeResult StatusCode()
        {
            //return new HttpStatusCodeResult(404, "URL cannot be serviced");
            // Se puede crear el mismo efecto usando 
            //return HttpNotFound();
            // Lanzar error 401 request Unauthorized
            return new HttpUnauthorizedResult();
        }
    }
}