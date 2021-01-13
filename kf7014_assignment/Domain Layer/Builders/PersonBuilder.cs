// Iqra Haq [w16011654] & Simran Gibson [w15035649]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Domain_Layer.Person;

namespace Assignment.Domain_Layer.Builders
{
    public class PersonBuilder
    {
        private Person _person = new Person();

        public PersonBuilder setMember(Member member)
        {
            _person.PersonMember = member;
            return this;
        }


        public PersonBuilder WithNoMiddleName(Prefix Title, String FirstName, String LastName)
        {
            _person.Title = Title;
            _person.FirstName = FirstName;
            _person.LastName = LastName;
            return this;
        }

        public PersonBuilder WithMiddleName(Prefix Title, String FirstName, String MiddleName, String LastName)
        {
            _person.Title = Title;
            _person.FirstName = FirstName;
            _person.MiddleName = MiddleName;
            _person.LastName = LastName;
            return this;
        }

        public PersonBuilder WithPrimaryContactOnly(String Primary)
        {
            _person.PrimaryPhone = Primary;
            return this;
        }

        public PersonBuilder WithAllContacts(String Primary, String Secondary)
        {
            _person.PrimaryPhone = Primary;
            _person.SecondaryPhone = Secondary;
            return this;
        }

        public PersonBuilder setDOB(DateTime dob)
        {
            _person.PersonDOB = dob;
            return this;
        }

        public PersonBuilder setGender(Gender gender)
        {
            _person.PersonGender = gender;
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }
}