using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plugin3.BusinessType;
using Plugin3UT.DataLayerUT;

namespace Plugin3UT
{
    [TestClass]
    public class UnitTest1
    {
        private CrmRepositoryUT _crmRepository = default(CrmRepositoryUT);

        [TestInitialize]
        public void TestInitialize()
        {
            ServerConnectionUT cnx = new ServerConnectionUT();
            _crmRepository = new CrmRepositoryUT(cnx);
        }

        [TestMethod]
        public void ActualizaEdadContacto()
        {
            // Arrange
            Contact contacto = new Contact()
            {
                ContactId = new Guid("ECC114C7-F5D2-E811-A96D-000D3A3AB886"),
                Edad = 23
            };
            // Act
            _crmRepository.ActualizaContacto(contacto);
            // Assert
            Assert.AreNotEqual(contacto.ContactId, default(Guid));
        }
    }
}