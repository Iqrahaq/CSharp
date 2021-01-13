// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Domain_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class PersonTests
    {
        private Person person = new Person();

        [TestMethod]
        public void DateOfBirth_DashFormatNullCheck_ReturnsFalse()
        {
            //Arrange
            person.PersonDOB = new DateTime(2021, 01, 01);
            String dob = person.PersonDOB.ToString();

            //Act
            var result = string.IsNullOrEmpty(dob);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PrimaryContact_Format_0_NullCheck_ReturnsFalse()
        {
            //Arrange
            person.PrimaryPhone = "01912039457";
            String phone = person.PrimaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PrimaryContact_Format_44_NullCheck_ReturnsFalse()
        {
            //Arrange
            person.PrimaryPhone = "+441912039457";
            String phone = person.PrimaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PrimaryContact_FormatNullCheck_ReturnsTrue()
        {
            //Arrange
            person.PrimaryPhone = "12301912039457";
            String phone = person.PrimaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PrimaryContact_LengthNullCheck_ReturnsTrue()
        {
            //Arrange
            person.PrimaryPhone = "1230191203945732445546";
            String phone = person.PrimaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SecondaryContact_Format_0_NullCheck_ReturnsFalse()
        {
            //Arrange
            person.SecondaryPhone = "01912039457";
            String phone = person.SecondaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SecondaryContact_Format_44_NullCheck_ReturnsFalse()
        {
            //Arrange
            person.SecondaryPhone = "+441912039457";
            String phone = person.SecondaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SecondaryContact_FormatNullCheck_ReturnsTrue()
        {
            //Arrange
            person.SecondaryPhone = "12301912039457";
            String phone = person.SecondaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SecondaryContact_LengthNullCheck_ReturnsTrue()
        {
            //Arrange
            person.SecondaryPhone = "123019120394571232342";
            String phone = person.SecondaryPhone;

            //Act
            var result = string.IsNullOrEmpty(phone);

            //Assert
            Assert.IsTrue(result);
        }
    }
}

