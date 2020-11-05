using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Customer
    {
        private String name;
        private ArrayList rentals = new ArrayList();

        public Customer(String name)
        {
            this.name = name;
        }

        public void addRental (Rental arg)
        {
            rentals.Add(arg);
        }

        public String getName()
        {
            return name;
        }

        public String statement()
        {
            String result = "Rental Record for " + getName() + "\n";
            foreach(Rental each in rentals)
            {
                // show figures for this rental
                result += "\t" + each.getMovie().getTitle() + "\t" + each.charge().ToString() + "\n";
            }

            //add footer lines
            result += "Amount owed is " + charge().ToString() + "\n";
            result += "You earned " + frequentRenterPoints().ToString() + " frequent renter points";
            return result;
        }

        public String htmlStatement()
        {
            String result = "<H1>Rentals for <EM>" + getName() + "</EM></H1><P>\n";
            foreach (Rental each in rentals)
            {
                result += each.getMovie().getTitle() + ": " + each.charge().ToString() + "<BR>\n";
            }
            //add footer lines
            result += "<P>You owe <EM>" + charge().ToString() + "</EM><P>\n";
            result += "On this rental you earned <EM>" + frequentRenterPoints().ToString() + "</EM> frequent renter points<P>";
            return result;
        }

        private int frequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach(Rental each in rentals)
            {
                frequentRenterPoints += each.frequentRenterPoints();
            }
            return frequentRenterPoints;
        }

        private double charge()
        {
            double totalAmount = 0;
            foreach (Rental each in rentals)
            {
                totalAmount += each.charge();
            }
            return totalAmount;
        }
    }
}
