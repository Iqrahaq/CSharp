// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Domain_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class GPTests
    {
        private GP gp = new GP();

        [TestMethod]
        public void PracticeName_LettersOnlyNullCheck_ReturnsFalse()
        {
            //Arrange
            gp.GPPractice = "Tester";
            String name = gp.GPPractice;

            //Act
            var result = string.IsNullOrEmpty(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PracticeName_WithHyphenNullCheck_ReturnsFalse()
        {
            //Arrange
            gp.GPPractice = "Tester-Name";
            String name = gp.GPPractice;

            //Act
            var result = string.IsNullOrEmpty(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PracticeName_WithApostropheNullCheck_ReturnsFalse()
        {
            //Arrange
            gp.GPPractice = "Tester'Name";
            String name = gp.GPPractice;

            //Act
            var result = string.IsNullOrEmpty(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PracticeName_WithNumbersNullCheck_ReturnsFalse()
        {
            //Arrange
            gp.GPPractice = "Tester-Name6";
            String name = gp.GPPractice;

            //Act
            var result = string.IsNullOrEmpty(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PracticeName_WithPunctNullCheck_ReturnsFalse()
        {
            //Arrange
            gp.GPPractice = "Tester!Name";
            String name = gp.GPPractice;

            //Act
            var result = string.IsNullOrEmpty(name);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PracticeName_LengthNullCheck_ReturnsTrue()
        {
            //Arrange
            gp.GPPractice = "This is a Practice Tester to test the limit of the name length.";
            String name = gp.GPPractice; ;

            //Act
            var result = string.IsNullOrEmpty(name);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
