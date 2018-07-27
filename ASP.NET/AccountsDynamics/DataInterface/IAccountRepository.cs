using System;
using System.Collections.Generic;
using BusinessType;

namespace DataInterface
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();

        Guid CreateAccount(Account account);
    }
}
