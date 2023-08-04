using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius1 = 25.0;
            double fahrenheit1;

            CelsiusToFahrenheit(celsius1, out fahrenheit1);

            Console.WriteLine(celsius1 + "°C is equal to " + fahrenheit1 + "°F");

            double fahrenheit2 = 77.0;
            double celsius2;

            FahrenheitToCelsius(fahrenheit2, out celsius2);

            Console.WriteLine(fahrenheit2 + "°F is equal to " + celsius2 + "°C");
        }


        static void CelsiusToFahrenheit(in double celsius, out double fahrenheit)
        {
            //celsius = celsius + 2;
            //in- cannot be modified within method
            fahrenheit = (celsius * 9 / 5) + 32;
        }


        static void FahrenheitToCelsius(in double fahrenheit, out double celsius)
        {
            //double temp = celsius + 1;
            //above will not work, has to be initialised before making any changes
            celsius = (fahrenheit - 32) * 5 / 9;

            //double temp = celsius + 1;
        }
    }
    
}
