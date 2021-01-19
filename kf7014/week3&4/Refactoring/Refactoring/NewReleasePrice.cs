using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class NewReleasePrice : Price
    {
        private static readonly int NEWRELEASE = 1;
        public override int PriceCode()
        {
            return NEWRELEASE;
        }
        public override double Charge(int daysRented)
        {
            return daysRented * 3;
        }
        public override int frequentRenterPoints(int daysRented)
        {
            if (daysRented > 1)
                return 2;
            return 1;
        }
    }
}
