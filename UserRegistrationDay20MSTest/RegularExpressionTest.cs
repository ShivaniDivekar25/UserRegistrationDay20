using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationday20;

namespace UserRegistrationDay20MSTest
{
    [TestClass]
    public class RegularExpressionTest
    {
        [TestMethod]
        [DataRow("Shivani","valid")]
        [DataRow("shivani","invalid")]
        public void Should_Return_First_Name_Valid_Or_Invalid(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression();
            //Act
            string actual = regularExpression.fisrtName(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
