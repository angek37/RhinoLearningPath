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
    }
}