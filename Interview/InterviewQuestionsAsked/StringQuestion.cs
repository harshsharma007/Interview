using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.InterviewQuestionsAsked
{
    class StringQuestion
    {
        /*
            Why String is a Value type although it is a class not a struct?
            Take the following example:
        */

        public StringQuestion()
        {
            string name = "Ibraheem";
            string copy = name;
            name = "Empty";

            Console.WriteLine("{0} {1}", name, copy);
        }

        /*
            The output is:
            Empty
            Ibraheem
            
            Since it is a class type (i.e. not a struct), String copy should also contain Emtpy because the = operator in C# assigns reference of objects rather than the object itself
            (as in C++)?
        */
    }

    class StringAnswer
    {
        /*
            System.String is not a value type. It exhibits some behaviors that are similar to value types, but the behavior you have come across is not one of them. Consider the
            following code
        */
        public string SomeProperty
        {
            get;
            private set;
        }

        public StringAnswer(string bar)
        {
            SomeProperty = bar;
        }
    }

    class StringExtend
    {
        public void Extend()
        {
            StringAnswer stringAnswer = new StringAnswer("B");
            StringAnswer answer = stringAnswer;
            stringAnswer = new StringAnswer("C");

            Console.WriteLine("{0} {1}", answer.SomeProperty, stringAnswer.SomeProperty);
        }
        /*
            If you checked the output of answer.SomeProperty, do you expect it to be the same as stringAnswer.SomeProperty? If so, you have a flawed understanding of the language.
            
            In your example, you have assigned a string a value. That's it. It has nothing to do with value types, reference types, classes or structs. It's simple assignment, and
            it's true whether you're talking about strings, longs, or StringAnswers. Your variables temporarily contained the same value (a reference to the string "Ibraheem"), but
            then you reassigned one of them. Those variables were not inextricably linked for all time, they just held something temporarily in common.
        */
    }

    class AnotherStringAnswer
    {
        /*
            Variables in C# are simply pieces of memory that are set aside to hold a single value. It's important to note that there's no such thing as a "Value Variable" and a
            "Reference Variable", because variables only hold values.
            
            The distinction between "Value" and "Reference" comes with the type. A Value Type (VT) means that the entire piece of data is stored within the variable.
            
            If I have an integer variable named "abc" that holds the value "100", then that means that I have a four-byte block of memory within my application that stores the literal
            value 100 inside it. This is because int is a value type, and thus all of the data is stored within the variable.
            
            On the other hand, if I have a string variable named "foo" that holds the value "Adam", then there are two actual memory locations involved. The first is the piece of
            memory that stores the actual characters "Adam", as well as other information about my string (its length, etc). A reference to this location is then stored within my
            variable. References are very similar to pointers in C/C++; while they are not the same, the analogy is sufficient for this explanation.
            
            So, to sum it up, the value for a reference type is a reference to another location in memory, where the value for a value type is the data itself.
            
            When you assign something to a variable, all you're changing is that variable's value. If I have this:
        */

        public AnotherStringAnswer()
        {
            string str1 = "foo";
            string str2 = str1;

            // Then I have two string variables that hold the same value (in this case, they each hold a reference to the same string, "foo"). If I then do this:
            str1 = "bar";

            // Then I have changed the value of str1 to a reference to the string "bar". This doesn't change str2 at all, since its value is still a reference to the string "foo".
            Console.WriteLine(str2);
        }
    }
}
