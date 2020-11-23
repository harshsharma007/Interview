using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class EnumDemo
    {
        // When we declare enum, it has to be outside of a method. So, we cannot declare the enumeration inside the method.
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        // We can change the default value of an enum.
        enum DaysNew { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        // To specify enum as a long, below is the syntax for it.
        enum DaysLong : long { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        public void Enumeration()
        {
            int x = (int)Days.Sunday;
            int y = (int)Days.Friday;

            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
        }
    }
}
