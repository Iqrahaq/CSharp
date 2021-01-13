// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Domain_Layer.Person;

namespace Assignment.Domain_Layer.Builders
{
    public class AddressBuilder
    {
        private PersonAddress _address = new PersonAddress();

        public AddressBuilder OneLineAddress(String FirstLine, String City, String County, String Postcode)
        {
            _address.FirstLine = FirstLine;
            _address.City = City;
            _address.County = County;
            _address.Postcode = Postcode;
            return this;
        }

        public AddressBuilder TwoLineAddress(String FirstLine, String SecondLine, String City, String County, String Postcode)
        {
            _address.FirstLine = FirstLine;
            _address.SecondLine = SecondLine;
            _address.City = City;
            _address.County = County;
            _address.Postcode = Postcode;
            return this;
        }

        public AddressBuilder ThreeLineAddress(String FirstLine, String SecondLine, String ThirdLine, String City, String County, String Postcode)
        {
            _address.FirstLine = FirstLine;
            _address.SecondLine = SecondLine;
            _address.ThirdLine = ThirdLine;
            _address.City = City;
            _address.County = County;
            _address.Postcode = Postcode;
            return this;
        }

        public PersonAddress Build()
        {
            return _address;
        }
    }
}