using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Interview.EDX.Basic
{
    class ExceptionHandlingExercise
    {
        public void ExceptionHandling()
        {
            double a = 98, b = 2;
            double result = 0;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
        }

        public double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
    }
}
