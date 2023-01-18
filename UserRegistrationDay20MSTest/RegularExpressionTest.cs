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
        [DataRow(new string[] { "Shivani", "Swati" }, "valid")]
        [DataRow(new string[] { "shivani", "swati" }, "invalid")]
        public void Should_Return_First_Name_Valid_Or_Invalid(string[] inputs, string expected)
        {
            //AAA methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.firstName();
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow(new string[] { "Divekar", "Mane" }, "valid")]
        [DataRow(new string[] { "divekar", "mane" }, "invalid")]
        public void Should_Return_Last_Name_Valid_Or_Invalid(string[] inputs, string expected)
        {
            //AAA methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.lastName();
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Valid Email")]
        [DataRow(new string[] { "abc.xyz@bl.co.in" }, "valid")]
        [DataRow(new string[] { "Abc.xyz@bl.co.in" }, "invalid")]
        public void Should_Return_Valid_Email(string[] inputs, string expected)
        {
            //AAA methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.validEmail();
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Valid Phone Number")]
        [DataRow(new string[] { "91 9421253907", "91 9158084126" }, "valid")]
        [DataRow(new string[] { "91 89839227034", "91 35648792255" }, "invalid")]
        public void Should_Return_Valid_Phone_Number(string[] inputs, string expected)
        {
            //AAA methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.phoneNumber();
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        [DataRow(new string[] { "Kjhfld@68", "Ahdyfh@90" }, "valid")]
        [DataRow(new string[] { "kjhfgdh1", "adfhgsw4" }, "invalid")]
        public void Should_Return_Password_Valid_Or_Invalid(string[] inputs, string expected)
        {
            //AAA methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.password();
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Validate Emails")]
        [DataRow(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" }, "valid")]
        [DataRow(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" }, "invalid")]
        public void Should_Return_Emails_Is_Valid_Or_Not(string[] inputs, string expected)
        {
            //AAA Methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.validateEmails();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        [DataRow(new string[] { "", "" }, "Message should not be empty")]
        public void Given_Message_Should_Return_Custom_Exception(string[] inputs, string expected)
        {
            try
            {
                //Arrange
                foreach (string input in inputs)
                {
                    
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    //string actual = regularExpression.firstName();
                    //string actual = regularExpression.lastName();
                    //string actual = regularExpression.validEmail();
                    //string actual = regularExpression.phoneNumber();
                    //string actual = regularExpression.password();
                    string actual = regularExpression.validateEmails();
                    if (actual != null)
                        Assert.AreEqual(expected, actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
