using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class Movie
    {
        private String title;
        private Price price;

        private Movie(String title)
        {
            this.title = title;
        }

        public double charge(int daysRented)
        {
            return price.Charge(daysRented);
        }

        public int frequentRenterPoints(int daysRented)
        {
            return price.frequentRenterPoints(daysRented);
        }

        public String getTitle()
        {
            return title;
        }

        public static Movie newRelease(String name)
        {
            Movie result = new Movie(name);
            result.beNewRelease();
            return result;
        }

        public static Movie newRegular(String name)
        {
            Movie result = new Movie(name);
            result.beRegular();
            return result;
        }

        public static Movie newChildrens(String name)
        {
            Movie result = new Movie(name);
            result.beChildrens();
            return result;
        }

        public void beRegular()
        {
            price = Price.Regular();
        }

        public void beNewRelease()
        {
            price = Price.NewRelease();
        }

        public void beChildrens()
        {
            price = Price.Childrens();
        }

    }
}
