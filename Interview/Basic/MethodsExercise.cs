using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Interview.Basic
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
    }
}
