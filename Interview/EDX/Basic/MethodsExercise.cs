using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Interview.EDX.Basic
{
    class MethodsExercise
    {
        static void PrintSomething()
        {
            Console.WriteLine("PrintSomething() method was called.");
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        static void MainMethod()
        {
            PrintSomething();

            int first = 10, second = 2;
            string sValue, rValue;
            int result = Sum(first, second);
            Console.WriteLine("The sum of {0} and {1} is: {2}", first, second, result);

            ReturnMultiOut(out first, out sValue);
            Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            rValue = "";
            ReturnMultiRef(ref first, ref rValue);
            Console.WriteLine("{0} {1}", first.ToString(), sValue);

            // Using named parameters
            Area(length: 30, width: 50);

            // Using optional parameters
            OptionalParams(10, 20);
            OptionalParams(10, 20, "Non-default text");
        }

        /*
            The 'out' keyword does not require the variable to be initialized first. The 'ref' keyword does require the variables to be initialized first.
            Both ref and out are treated differently at run time and they are treated the same at compile time, so methods cannot be overloaded if one method takes
            an argument as ref and the other takes an argument as an out.
        */

        static void ReturnMultiOut(out int a, out string b)
        {
            a = 25;
            b = "using out";
        }

        static void ReturnMultiRef(ref int a, ref string b)
        {
            a = 50;
            b = "using ref";
        }

        // Using named parameters
        static void Area(int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }

        // Using optional parameters
        static void OptionalParams(int one, int two, string s = "Default text")
        {
            Console.WriteLine("{0}, {1}, {2}", one, two, s);
        }

        // This is because mandatory parameters are defined first and optional in the end.
        static void AnotherOptionalParams(int one, string s = "New", int two = 2)
        {
            Console.WriteLine("{0} {1} {2}", one, s, two);
        }
    }
}
