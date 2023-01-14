using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationday20;

namespace UserRegistrationDay20MSTest
{
    [TestClass]
    public class RegularExpressionTest
    {
        [TestMethod]
        [TestCategory("First Name")]
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
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow("Divekar","valid")]
        [DataRow("divekar","invalid")]
        public void Should_Return_Last_Name_Valid_Or_Invalid(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression();
            //Act
            string actual = regularExpression.lastName(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Valid Email")]
        [DataRow("abc.xyz@bl.co.in", "valid")]
        [DataRow("Abc.xyz@bl.co.in", "invalid")]
        public void Should_Return_Valid_Email(string input, string expected)
        {
            //AAA methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression();
            //Act
            string actual = regularExpression.validEmail(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
