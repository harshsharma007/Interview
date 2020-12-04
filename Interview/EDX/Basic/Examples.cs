using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class Examples
    {
        public void Example()
        {
            #region Variables, Operators and Expressions

            // A statement declaring a variable using a data type int and assigning a value.
            int myVar = 2;

            // A statement declaring another int variable. Assignment takes place on another line.
            int secondVar;
            secondVar = 10;

            int sum = myVar + secondVar;
            int product = myVar * secondVar;
            int remainder = myVar % secondVar;
            double value = (double)myVar / (double)secondVar;

            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(value);

            string firstName = "Tom";
            string lastName = "Sawyer";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
            
            /*
                Below is the more recommended coding convention of C#. Here we are using placeholders within the text output and then we assign the variable names that go into those 
                placeholders.

                Notice that these here are just sequentially assigned numbers, within the curly braces, enclosed in double quotations, separated by a comma and then the variable names 
                that will go into it.
            */
            Console.WriteLine("{0} {1}", firstName, lastName);
            #endregion
        }
    }
}
