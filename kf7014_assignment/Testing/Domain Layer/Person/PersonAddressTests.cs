// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Domain_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class PersonAddressTests
    {
        private PersonAddress address = new PersonAddress();

        [TestMethod]
        public void FirstLine_LettersOnlyCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester Lane";
            address.FirstLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void FirstLine_LettersandNumbersCheck_ReturnsTrue()
        {
            //Arrange
            String line = "22 Tester Drive";
            address.FirstLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void FirstLine_LettersNumbersandPunctCheck_ReturnsTrue()
        {
            //Arrange
            String line = "22 Main-Tester Road";
            address.FirstLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void FirstLine_PunctCheck_ReturnsFalse()
        {
            //Arrange
            String line = "22 Main!Tester Road";
            address.FirstLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreNotEqual(line, result);
        }

        [TestMethod]
        public void SecondLine_LettersOnlyCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester Lane";
            address.SecondLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void SecondLine_LettersandNumbersCheck_ReturnsTrue()
        {
            //Arrange
            String line = "22 Tester Drive";
            address.SecondLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void SecondLine_LettersNumbersandPunctCheck_ReturnsTrue()
        {
            //Arrange
            String line = "22 Main-Tester Road";
            address.SecondLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void SecondLine_PunctCheck_ReturnsFalse()
        {
            //Arrange
            String line = "22 Main!Tester Road";
            address.SecondLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreNotEqual(line, result);
        }

        [TestMethod]
        public void ThirdLine_LettersOnlyCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester Lane";
            address.ThirdLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void ThirdLine_LettersandNumbersCheck_ReturnsTrue()
        {
            //Arrange
            String line = "22 Tester Drive";
            address.ThirdLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void ThirdLine_LettersNumbersandPunctCheck_ReturnsTrue()
        {
            //Arrange
            String line = "22 Main-Tester Road";
            address.ThirdLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void ThirdLine_PunctCheck_ReturnsFalse()
        {
            //Arrange
            String line = "22 Main!Tester Road";
            address.ThirdLine = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreNotEqual(line, result);
        }

        [TestMethod]
        public void City_LettersOnlyCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester City";
            address.City = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void City_PunctCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester-City";
            address.City = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void County_LettersOnlyCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester County";
            address.County = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void County_PunctCheck_ReturnsTrue()
        {
            //Arrange
            String line = "Tester,County";
            address.County = line;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(line, result);
        }

        [TestMethod]
        public void Postcode_XX0X_0XXFormatCheck_ReturnsTrue()
        {
            //Arrange
            String postcode = "XX0X 0XX";
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(postcode, result);
        }

        [TestMethod]
        public void Postcode_X0X_0XXFormatCheck_ReturnsTrue()
        {
            //Arrange
            String postcode = "X0X 0XX";
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(postcode, result);
        }

        [TestMethod]
        public void Postcode_X0_0XXFormatCheck_ReturnsTrue()
        {
            //Arrange
            String postcode = "X0 0XX";
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(postcode, result);
        }

        [TestMethod]
        public void Postcode_X00_0XXFormatCheck_ReturnsTrue()
        {
            //Arrange
            String postcode = "X00 0XX";
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(postcode, result);
        }

        [TestMethod]
        public void Postcode_XX0_0XXFormatCheck_ReturnsTrue()
        {
            //Arrange
            String postcode = "XX0 0XX";
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(postcode, result);
        }

        [TestMethod]
        public void Postcode_XX00_0XXFormatCheck_ReturnsTrue()
        {
            //Arrange
            String postcode = "XX00 0XX";
            address.Postcode = postcode; 

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreEqual(postcode, result);
        }

        [TestMethod]
        public void Postcode_XX00_00XXFormatCheck_ReturnsFalse()
        {
            //Arrange
            String postcode = "XX00 00XX";
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress().Trim('\n');

            //Assert
            Assert.AreNotEqual(postcode, result);
        }

        [TestMethod]
        public void FullAddress_FormatCheck_ReturnsTrue()
        {
            //Arrange
            String first = "1st Test Line";
            String second = "Second Test-Drive";
            String third = "Third Test Road";
            String city = "Tester City";
            String county = "Tester County";
            String postcode = "XX0 0XX";
            address.FirstLine = first;
            address.SecondLine = second;
            address.ThirdLine = third;
            address.City = city;
            address.County = county;
            address.Postcode = postcode;

            //Act
            String result = address.getFullAddress();

            //Assert
            Assert.AreEqual(first + '\n' + second + '\n' + third + '\n' + city + '\n' + county + '\n' + postcode, result);
        }
    }
}
