using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Demo
{
    class StaticClass
    {
        /*
            We are going to create a Celsius to Fahrenheit and Fahrenheit to Celsius converter. As we know, that the formula for the conversion will remain the same,
            so we can use a static class.
        */

        public StaticClass()
        {
            double celsius = 37;
            double fahrenheit = 98.6;
            Console.WriteLine("Value of {0} celsius to fahrenheit is {1}", celsius, Converter.ToFahrenheit(celsius));
            Console.WriteLine("Value of {0} fahrenheit to celsius is {1}", celsius, Converter.ToFahrenheit(fahrenheit));
        }
    }

    public static class Converter
    {
        public static double ToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
