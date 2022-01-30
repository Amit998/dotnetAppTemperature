using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temperature.Services
{
    public class TemperatureCalculatorService
    {
        public double celsius_to_fahrenheit(double c)
        {
            double f = ((c * 9 / 5) + 32);
        
            return f;

        }
        public double fahrenheit_to_celsius(double f)
        {
            double c = ((f-32)*5/9);
            return c;

        }

    }
}
