using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BusinessInterface;
using BusinessLayer;
using BusinessType;
using DataInterface;

namespace UT.Processor
{
    [TestClass]
    public class AccountProcessorTest
    {
        private IAccountProcessor _processor;

        [TestMethod]
        public void ConfirmationCreationAccount()
        {
            // Arrange
            Account account = new Account
            {
                Name = "LoL"
            };
            Mock<IAccountRepository> mock = new Mock<IAccountRepository>();
            mock.Setup(m => m.CreateAccount(account)).Returns(new Guid("07f461c1-86a1-40c2-a3a3-199894b33069"));
            _processor = new AccountProcessor(mock.Object);
            // Act
            var response = _processor.ConfirmationCreationAccount(account);
            // Assert
            Assert.AreEqual("Se creo con éxito", response);
        }
    }
}
