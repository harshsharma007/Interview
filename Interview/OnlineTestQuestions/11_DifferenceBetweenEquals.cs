using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.OnlineTestQuestions
{
    class DifferenceBetweenEquals
    {
        /*
            Q. What is the difference between a.Equals(b) and a == b?
            A. The .Equals method compares contents while == compares reference identity.
            
            Both the == operator and the Equals() method are used to compare two value type data items or reference type data items. The Equality Operator (==) is the
            comparison operator and the Equals() method compares the contents of a string. The == Operator compares the reference identity while the Equals() method
            compares only contents.
            
            In the first example we assigned a string variable to another variable. A string is a reference type and in the following example, a string variable is
            assigned to another string variable so they are referring to the same identity in the heap and both have the same content so you get True output for both
            the == Operator and the Equals() method.
        */

        public void Method1()
        {
            string name = "sandeep";
            string myName = name;

            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", name.Equals(myName));
            Console.ReadKey();
        }

        /*
            Output:
            == operator result is True
            Equals method result is True
        */

        /*
            Let's see another example where the contents will be the same in both object variables but both have different references. So the == Operator returns
            False because it compares the reference identity while the Equals() method returns True because it compares the contents of the objects.
        */

        public void Method2()
        {
            string name = "sandeep";
            char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            string myName = new string(values);

            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name));
            Console.ReadLine();
        }

        /*
            Output:
            == operator result is False
            Equals method result is True
        */

        /*
            Now let's see one more example that shows that the Equals() method is an extension method of the string class when you assign a null value to the string
            variable and using that variable the Equals() method then gets an exception of a null reference so you must be sure that your variable doesn't have null
            values when calling the Equals() method. When your one variable contains a null value then you should use that variable as an argument for the Equals()
            method.
        */

        public void Method3()
        {
            string name = "sandeep";
            string myName = null;

            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name)); // Runtime exception. Object reference not set to an instance of an object.
            Console.ReadLine();
        }

        /*
            The rule of thumb is that for nearly all reference types, use Equals when you want to test the equality rather than reference identity. The exception is for
            strings; comparing strings with == does make things much simpler and more readable but you need to remember that both sides of the operator must be
            expressions of type string for the comparison to work properly.
        */
    }
}
