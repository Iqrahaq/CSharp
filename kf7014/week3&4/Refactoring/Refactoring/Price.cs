using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public abstract class Price
    {
        private static Price childrens = new ChildrensPrice();
        private static Price newRelease = new NewReleasePrice();
        private static Price regular = new RegularPrice();

        public abstract int PriceCode();
        public abstract double Charge(int daysRented);

        public virtual int frequentRenterPoints(int daysRented)
        {
            return 1;
        }

        public static Price Childrens()
        {
            return childrens;
        }
        public static Price NewRelease()
        {
            return newRelease;
        }
        public static Price Regular()
        {
            return regular;
        }

    }
}
