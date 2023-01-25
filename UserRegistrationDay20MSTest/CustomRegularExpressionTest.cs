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
        [DataRow(new string[] { "Shivani", "Swati" })]
        [DataRow(new string[] { "shivani", "swati" })]
        public void Should_Return_First_Name_Valid_Or_Invalid(string[] inputs)
        {
            try
            {
                //AAA methodology
                //Arrange
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.firstName(input);
                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch(ExceptionHandling ex)
            {
                Assert.AreEqual("Invalid First Name", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow(new string[] { "Divekar", "Mane" })]
        [DataRow(new string[] { "divekar", "mane" })]
        public void Should_Return_Last_Name_Valid_Or_Invalid(string[] inputs)
        {
            try
            {
                //AAA methodology
                //Arrange
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.lastName(input);
                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch(ExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Last Name", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Valid Email")]
        [DataRow(new string[] { "abc.xyz@bl.co.in" })]
        [DataRow(new string[] { "Abc.xyz@bl.co.in" })]
        public void Should_Return_Valid_Email(string[] inputs)
        {
            try
            {
                //AAA methodology
                //Arrange
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.validEmail(input);
                    //Assert
                    Assert.IsTrue(actual);
                }
            }
             catch(ExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Valid Phone Number")]
        [DataRow(new string[] { "91 9421253907", "91 9158084126" })]
        [DataRow(new string[] { "91 89839227034", "91 35648792255" })]
        public void Should_Return_Valid_Phone_Number(string[] inputs)
        {
            try
            {
                //AAA methodology
                //Arrange
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.phoneNumber(input);
                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch(ExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Phone Number", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        [DataRow(new string[] { "Kjhfld@68", "Ahdyfh@90" })]
        [DataRow(new string[] { "kjhfgdh1", "adfhgsw4" })]
        public void Should_Return_Password_Valid_Or_Invalid(string[] inputs)
        {
            try
            {
                //AAA methodology
                //Arrange
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.password(input);
                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch(ExceptionHandling ex)
            {
                Assert.AreEqual("Invalid Passwpord", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Validate Emails")]
        [DataRow(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" })]
        [DataRow(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" })]
        public void Should_Return_Emails_Is_Valid_Or_Not(string[] inputs)
        {
            try
            {
                //AAA Methodology
                //Arrange
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.validateEmails(input);

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch(ExceptionHandling ex)
            {
                Assert.AreEqual("Invalid All Emails", ex.Message);
            }
        }
    }
}
