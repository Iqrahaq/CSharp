// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Domain_Layer.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Assignment.Domain_Layer.Person;

namespace Testing
{
    [TestClass]
    public class PersonBuilderTests
    {
        private PersonBuilder builder = new PersonBuilder();
        
        [TestMethod]
        public void PersonBuilder_WithMiddleName_ReturnsTrue()
        {
            var person = builder
                .WithMiddleName(Prefix.Mr, "John", "Jacob", "Smith")
                .Build();

            Assert.IsNotNull(person.MiddleName);
        }

        [TestMethod]
        public void PersonBuilder_WithoutMiddleName_ReturnsFalse()
        {
            var person = builder
                .WithNoMiddleName(Prefix.Mr, "John", "Smith")
                .Build();

            Assert.IsNull(person.MiddleName);
        }
    }
}
