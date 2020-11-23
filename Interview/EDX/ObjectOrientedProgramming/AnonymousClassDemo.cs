using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class AnonymousClassDemo
    {
        public void Anonymous()
        {
            /*
                This is the example of anonymous class. It has two properties Name and Age.
                
                Note: Name and Age do not have data type specifiers ahead of the variable names but what C# does is it can infer based on the type of data that we've
                input, what those should be.
            */
            var anony = new
            {
                Name = "Harsh",
                Age = 31
            };
            Console.WriteLine(anony.Name);
        }
    }
}
