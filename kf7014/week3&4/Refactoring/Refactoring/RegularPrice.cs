using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class RegularPrice : Price
    {
        private static readonly int REGULAR = 1;
        public override int PriceCode()
        {
            return REGULAR;
        }
        public override double Charge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
            {
                result += (daysRented - 2) * 1.5;
            }
            return result;
        }
    }
}
