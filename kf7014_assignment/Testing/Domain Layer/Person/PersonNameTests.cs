// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Domain_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Assignment.Domain_Layer.Person;

namespace Testing
{
    [TestClass]
    public class PersonNameTests
    {
        private Person person = new Person();

        [TestMethod]
        public void FirstName_LettersOnlyNullCheck_ReturnsFalse()
        {
            //Arrange
            person.FirstName = "Tester";
            String first = person.FirstName;

            //Act
            var result = string.IsNullOrEmpty(first);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FirstName_WithHyphenNullCheck_ReturnsFalse()
        {
            //Arrange
            person.FirstName = "Tester-Name";
            String first = person.FirstName;

            //Act
            var result = string.IsNullOrEmpty(first);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FirstName_WithApostropheNullCheck_ReturnsFalse()
        {
            //Arrange
            person.FirstName = "Tester'Name";
            String first = person.FirstName;

            //Act
            var result = string.IsNullOrEmpty(first);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FirstName_WithNumbersNullCheck_ReturnsTrue()
        {
            //Arrange
            person.FirstName = "Tester-Name6";
            String first = person.FirstName;

            //Act
            var result = string.IsNullOrEmpty(first);            

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FirstName_WithPunctNullCheck_ReturnsTrue()
        {
            //Arrange
            person.FirstName = "Tester!Name";
            String first = person.FirstName;

            //Act
            var result = string.IsNullOrEmpty(first);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MiddleName_LettersOnlyNullCheck_ReturnsFalse()
        {
            //Arrange
            person.MiddleName = "Tester";
            String middle = person.MiddleName;

            //Act
            var result = string.IsNullOrEmpty(middle);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MiddleName_WithHyphenNullCheck_ReturnsFalse()
        {
            //Arrange
            person.MiddleName = "Tester-Name";
            String middle = person.MiddleName;

            //Act
            var result = string.IsNullOrEmpty(middle);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MiddleName_WithApostropheNullCheck_ReturnsFalse()
        {
            //Arrange
            person.MiddleName = "Tester'Name";
            String middle = person.MiddleName;

            //Act
            var result = string.IsNullOrEmpty(middle);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MiddleName_WithNumbersNullCheck_ReturnsTrue()
        {
            //Arrange
            person.MiddleName = "Tester-Name6";
            String middle = person.MiddleName;

            //Act
            var result = string.IsNullOrEmpty(middle);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MiddleName_WithPunctNullCheck_ReturnsTrue()
        {
            //Arrange
            person.MiddleName = "Tester!Name";
            String middle = person.MiddleName;

            //Act
            var result = string.IsNullOrEmpty(middle);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LastName_LettersOnlyNullCheck_ReturnsFalse()
        {
            //Arrange
            person.LastName = "Tester";
            String last = person.LastName;

            //Act
            var result = string.IsNullOrEmpty(last);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LastName_WithHyphenNullCheck_ReturnsFalse()
        {
            //Arrange
            person.LastName = "Tester-Name";
            String last = person.LastName;

            //Act
            var result = string.IsNullOrEmpty(last);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LastName_WithApostropheNullCheck_ReturnsFalse()
        {
            //Arrange
            person.LastName = "Tester'Name";
            String last = person.LastName;

            //Act
            var result = string.IsNullOrEmpty(last);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LastName_WithNumbersNullCheck_ReturnsTrue()
        {
            //Arrange
            person.LastName = "Tester-Name6";
            String last = person.LastName;

            //Act
            var result = string.IsNullOrEmpty(last);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LastName_WithPunctNullCheck_ReturnsTrue()
        {
            //Arrange
            person.LastName = "Tester!Name";
            String last = person.LastName;

            //Act
            var result = string.IsNullOrEmpty(last);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FullName_WithoutMiddleNameCheck_ReturnsTrue()
        {
            //Arrange
            Prefix title = Prefix.Mr;
            person.Title = title;
            String first = "First'Name";
            person.FirstName = first;
            String last = "Last-Name";
            person.LastName = last;

            //Act
            String full = person.getFullName();

            //Assert
            Assert.AreEqual(title + " " + first + " "+ last, full);
        }

        [TestMethod]
        public void FullName_WithMiddleNameCheck_ReturnsTrue()
        {
            //Arrange
            Prefix title = Prefix.Mr;
            person.Title = title;
            String first = "First'Name";
            person.FirstName = first;
            String middle = "MiddleName";
            person.MiddleName = middle;
            String last = "Last-Name";
            person.LastName = last;

            //Act
            String full = person.getFullName();

            //Assert
            Assert.AreEqual(title + " " + first + " " + middle + " " + last, full);
        }
    }
}
