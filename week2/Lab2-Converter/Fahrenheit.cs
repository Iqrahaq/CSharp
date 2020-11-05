using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Converter
{
    class Fahrenheit
    {
        private double Temperature;

        public Fahrenheit()
    	{	
		    Temperature = 32.0; 
	    }
        public double getTemperature()
        {
            return Temperature;
        }

        public double convertToCentigrade()
        {
            double centigrade;

            centigrade = 5.0 * (Temperature - 32.0) / 9.0;
            return centigrade;
        }

        public void setTemperature(double Temperature)
        {
            this.Temperature = Temperature;
        }

    }
}
