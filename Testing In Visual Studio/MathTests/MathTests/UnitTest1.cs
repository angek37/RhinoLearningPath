using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            int num1 = 2;
            int num2 = 3;

            // Act
            int sum = MyMath.Add(num1, num2);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, sum);
        }

        [Fact]
        public void TestAddWithFramework()
        {
            // Arrange
            int num1 = 2;
            int num2 = 3;

            // Act
            int sum = MyMath.Add(num1, num2);

            // Assert
            Xunit.Assert.Equal(5, sum);
        }
    }
}
