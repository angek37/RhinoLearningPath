using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plugin2.BusinessType;
using Plugin2UT.DataLayerUT;

namespace Plugin2UT
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void CalculaEdadContacto()
        {
            // Arrange
            Contact contact = new Contact()
            {
                FullName = "Miguel Ángel Rodríguez González",
                BirthDate = new DateTime(1995, 8, 7)
            };
            int edad;
            // Act
            edad = (((DateTime.Now.Year - contact.BirthDate.Year) * 12) + DateTime.Now.Month - contact.BirthDate.Month) / 12;
            // Assert
            Assert.AreEqual(23, edad);
        }

    }
}
