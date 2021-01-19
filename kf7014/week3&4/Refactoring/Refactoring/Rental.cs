using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class Rental
    {
        private Movie movie;
        private int daysRented;

        public Rental (Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public int getDaysRented()
        {
            return daysRented;
        }

        public Movie getMovie()
        {
            return movie;
        }

        public double charge()
        {
            return movie.charge(daysRented);
        }

        public int frequentRenterPoints()
        {
            return movie.frequentRenterPoints(daysRented);
        }
    }
}
