using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class ChildrensPrice : Price
    {
        private static readonly int CHILDRENS = 2;
        public override int PriceCode()
        {
            return CHILDRENS;
        }
        public override double Charge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;
            }
            return result;
        }
    }
}
