using Epam_Customer_Class_Challenge_MaralovKemal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Epam_Customer_Class_Challenge_MaralovKemal_Test
{
    [TestClass]
    public class Customer_Test
    {
        [TestMethod]
        public void TestMethod1_CheckToString_G_()
        {
            // Arrange
            var customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            var expectedResult = "- Customer Record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100";

            // Act
            var actualResult = customer.ToString("G");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod1_CheckToString_D_()
        {
            // Arrange
            var customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            var expectedResult = "- Customer Record: +1 (425) 555-0100";

            // Act
            var actualResult = customer.ToString("D");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod1_CheckToString_C_()
        {
            // Arrange
            var customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            var expectedResult = "- Customer Record: Jeffrey Richter, 1,000,000.00";

            // Act
            var actualResult = customer.ToString("C");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
