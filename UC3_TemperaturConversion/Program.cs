using System;

namespace UC3_TemperaturConversion
{
    public class TemperaturConversion
    {
        static void Main(string[] args)
        {
            TemperatureConversion temp = new TemperatureConversion();
            Console.WriteLine("Please Enter celsius temp : ");
            string val1 = Console.ReadLine();
            double fahrenheit=temp.CelsiusToFahrenheit(val1);
            Console.WriteLine($"The value of (val1) celsius is : {fahrenheit} fahrenheit");

            Console.WriteLine("Please Enter fahrenheit temp : ");
            string val2 = Console.ReadLine();
            double celsius = temp.FahrenheitToCelsius(val2);
            Console.WriteLine($"The value of (val1) fahrenheit is : {celsius} celsius");
        }
        
    }
}
