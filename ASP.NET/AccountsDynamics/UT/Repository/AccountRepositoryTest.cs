using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessType;
using DataInterface;
using DataLayer;

namespace UT.Repository
{
    [TestClass]
    public class AccountRepositoryTest
    {
        private IAccountRepository _repository;

        [TestInitialize]
        public void Initialize()
        {
            _repository = new AccountRepository();
        }

        [TestMethod]
        public void TestGetOfAllAccounts()
        {
            // Arrange
            List<Account> list = new List<Account>();
            // Act
            list = _repository.GetAccounts();
            // Assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestInsertAccount()
        {
            // Arrange
            Account account = new Account
            {
                Name = "Amazon Inc",
                City = "Seattle",
                State = "Washington",
                Country = "United States"
            };
            // Act
            Guid guid = _repository.CreateAccount(account);
            // Assert
            Assert.AreNotEqual(default(Guid), guid);
        }
    }
}
