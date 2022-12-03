using System;
using System.Collections.Generic;
using System.Text;

namespace UC3_TemperaturConversion
{
    class TemperatureConversion
    {
        public double CelsiusToFahrenheit(string celsiusTemp)
        {
            double celsius = double.Parse(celsiusTemp);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public double FahrenheitToCelsius(string fahrenheitTemp)
        {
            double fahrenheit = double.Parse(fahrenheitTemp);
            double celsius = (fahrenheit - 32) * 5/9;
            return celsius;
        }
    }
}
