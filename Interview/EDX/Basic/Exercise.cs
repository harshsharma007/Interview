using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class Exercise
    {
        public void NewExercise()
        {
            string firstName = "Harsh";
            string lastName = "Sharma";
            DateTime birthDate = new DateTime(1988, 12, 23);
            string addressLine1 = "#20-A";
            string addressLine2 = "Gobindgarh";
            string city = "Jalandhar";
            string state = "Punjab";
            int zip = 144001;
            string country = "India";

            Console.WriteLine("{0} {1} {2}", "My name is", firstName, lastName);
            Console.WriteLine("{0} {1}", "My DOB is", birthDate);
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "My address is", addressLine1, addressLine2, city, state, zip.ToString(), country);
        }

        public void DecisionAndRepetition()
        {
            int condition1;
            int condition2;
            int switchCondition;

            condition1 = 1;
            if (condition1 == 1)
            {
                Console.WriteLine("Comparison evaluated to true.");
            }

            Console.WriteLine("This executes after the if, regardless of what has taken place.");

            condition1 = 3;
            if (condition1 == 1)
            {
                Console.WriteLine("Comparison evaluated to true.");
            }
            else
            {
                Console.WriteLine("Comparison evaluated to false.");
            }

            condition1 = 1;
            condition2 = 2;
            if (condition1 == 1)
            {
                Console.WriteLine("Condition1 is true");
            }
            else if (condition2 == 2)
            {
                Console.WriteLine("Condition2 is true");
            }
            else
            {
                Console.WriteLine("Neither condition is true");
            }

            switchCondition = 3;
            switch (switchCondition)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                case 3:
                    Console.WriteLine("Value is 3");
                    break;
                default:
                    Console.WriteLine("Value is " + switchCondition);
                    break;
            }

            int whileCounter = 0, doCounter = 0;

            Console.WriteLine("For Loop");
            Console.WriteLine("");

            for (int forCounter = 0; forCounter < 10; forCounter++)
            {
                Console.WriteLine("forCounter is at {0}", forCounter);
            }

            Console.WriteLine("While Loop");
            Console.WriteLine("");

            while (whileCounter < 5)
            {
                Console.WriteLine("Whilecounter is at " + whileCounter);
                whileCounter++;
            }

            Console.WriteLine("Do-While Loop");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("doCounter is at " + doCounter);
                doCounter++;
            } while (doCounter < 5);

            /*
                The difference between while and do while loop is that the do loop will execute the content of the loop at least once because the condition check
                doesn't happen until the end of the loop itself.
            */

            long value = Factorial(10);
            Console.WriteLine(value);
        }

        // Recursion sample
        static long Factorial(int n)
        {
            Console.WriteLine("Recursion");
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
