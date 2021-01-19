using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_Converter
{
    class Centigrade
    {
        private double Temperature;

        public Centigrade()
    	{	
		    Temperature = 0; 
	    }
        public double getTemperature()
        {
            return Temperature;
        }

        public double convertToFahrenheit()
        {
            double Fahrenheit;
            Fahrenheit = 9.0 * Temperature / 5.0 + 32.0;
            return Fahrenheit;
        }

        public void setTemperature(double Temperature)
        {
            this.Temperature = Temperature;
        }
    }
}
