// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using Assignment.Domain_Layer.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class AddressBuilderTests
    {
        private AddressBuilder builder = new AddressBuilder();

        [TestMethod]
        public void AddressBuilder_FirstLineOnly_ReturnsTrue()
        {
            var address = builder
                .OneLineAddress("Line", "City", "County", "Postcode")
                .Build();

            Assert.IsNotNull(address.FirstLine);
            Assert.IsNull(address.SecondLine);
            Assert.IsNull(address.ThirdLine);
        }

        [TestMethod]
        public void AddressBuilder_TwoLineAddress_ReturnsTrue()
        {
            var address = builder
                .TwoLineAddress("Line", "Line", "City", "County", "Postcode")
                .Build();

            Assert.IsNotNull(address.FirstLine);
            Assert.IsNotNull(address.SecondLine);
            Assert.IsNull(address.ThirdLine);
        }

        [TestMethod]
        public void AddressBuilder_ThreeLineAddress_ReturnsTrue()
        {
            var address = builder
                .ThreeLineAddress("Line", "Line", "Line", "City", "County", "Postcode")
                .Build();

            Assert.IsNotNull(address.FirstLine);
            Assert.IsNotNull(address.SecondLine);
            Assert.IsNotNull(address.ThirdLine);
        }
    }
}
