using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37; double fahrenheit = 98.6;
            Console.WriteLine($"Value of {celcius} C to F is {Converter.ToFahrenheit(celcius)}");
            Console.WriteLine($"Value of {fahrenheit} F to C is {Converter.ToCelcius(fahrenheit)}");
        }
    }
}
