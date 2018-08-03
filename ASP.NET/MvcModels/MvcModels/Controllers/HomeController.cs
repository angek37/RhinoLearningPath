using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private Person[] personData =
        {
            new Person
            {
                PersonId = 1,
                FirstName = "Adam",
                LastName = "Freeman",
                Role = Role.Admin
            },
            new Person
            {
                PersonId = 2,
                FirstName = "Jacqui",
                LastName = "Griffyth",
                Role = Role.User
            },
            new Person
            {
                PersonId = 3,
                FirstName = "John",
                LastName = "Smith",
                Role = Role.User
            },
            new Person
            {
                PersonId = 4,
                FirstName = "Anne",
                LastName = "Jones",
                Role = Role.Guest
            }
        };

        public ActionResult Index(int? id = 1)
        {
            Person dataItem = personData.First(p => p.PersonId == id);
            return View(dataItem);
        }

        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("Index", model);
        }

        public ActionResult DisplaySummary([Bind(Prefix = "HomeAddress", Exclude = "Country")]AddressSumary summary)
        {
            return View(summary);
        }

        //public ActionResult Names(string[] names)
        //{
        //    names = names ?? new string[0];
        //    return View(names);
        //}

        public ActionResult Names(IList<string> names)
        {
            names = names ?? new List<string>();
            return View(names);
        }

        //public ActionResult Address(IList<AddressSumary> addresses)
        //{
        //    addresses = addresses ?? new List<AddressSumary>();
        //    return View(addresses);
        //}

        //Manually Invoking the Model Binding Process
        //public ActionResult Address(FormCollection formData)
        //{
        //    IList<AddressSumary> addresses = new List<AddressSumary>();
        //    // Restricting the Binder to the Form Data
        //    //UpdateModel(addresses, new FormValueProvider(ControllerContext));
        //    if (TryUpdateModel(addresses, formData))
        //    {
        //        // Proceed as normal
        //    }
        //    else
        //    {
        //        // Provide feedback to user
        //    }
        //    return View(addresses);
        //}

        // Removing the restriction on the Sources of Model Property Values
        public ActionResult Address()
        {
            IList<AddressSumary> addresses = new List<AddressSumary>();
            UpdateModel(addresses);
            return View(addresses);
        }
    }
}