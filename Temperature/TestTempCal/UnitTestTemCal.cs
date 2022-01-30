using System;
using Xunit;

namespace TestTempCal
{
    public class UnitTest1
    {
        Temperature.Services.TemperatureCalculatorService test = new Temperature.Services.TemperatureCalculatorService();
        [Fact]
        public void TestFahrenheitToCelsius()
        { 

            Assert.Equal(37.77777777777778, test.fahrenheit_to_celsius(100));
            Assert.Equal(93.33333333333333, test.fahrenheit_to_celsius(200));
            Assert.Equal(148.88888888888889, test.fahrenheit_to_celsius(300));
            Assert.Equal(100, test.fahrenheit_to_celsius(212));

        }

        [Fact]
        public void TestCelsiusToFahrenheit()
        {

            Assert.Equal(212, test.celsius_to_fahrenheit(100));
            Assert.Equal(392, test.celsius_to_fahrenheit(200));
            Assert.Equal(572, test.celsius_to_fahrenheit(300));
            Assert.Equal(152.6, test.celsius_to_fahrenheit(67));

        }


    }
}
