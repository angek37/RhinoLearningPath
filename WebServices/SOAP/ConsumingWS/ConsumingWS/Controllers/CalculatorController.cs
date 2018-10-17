using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumingWS.Models;
using ConsumingWS.ServiceReference1;

namespace ConsumingWS.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Result(Operands nums)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            return View(client.add(nums.num1, nums.num2));
        }
    }
}