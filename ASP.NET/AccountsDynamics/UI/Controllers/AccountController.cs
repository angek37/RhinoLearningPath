using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessType;
using DataInterface;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        private IAccountRepository _repository;

        public AccountController(IAccountRepository accountRepository)
        {
            _repository = accountRepository;
        }

        public ViewResult List()
        {
            List<Account> accounts = _repository.GetAccounts();
            return View(accounts);
        }

        public ViewResult Edit(Guid id)
        {
            Account account = _repository
                    .GetAccounts()
                    .FirstOrDefault(a => a.AccountId == id);
            ViewBag.Message = "Edit";
            return View(account);
        }

        public ViewResult Create()
        {
            ViewBag.Message = "Create new Account";
            return View("Edit", new Account());
        }

        [HttpPost]
        public ActionResult Edit(Account account)
        {
            _repository.CreateAccount(account);
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            _repository.DeleteAccount(id);
            return RedirectToAction("List");
        }
    }
}