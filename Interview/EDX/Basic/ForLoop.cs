using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class ForLoop
    {
        /*
            The for loop executes a block of code repeatedly until the specified expression evaluates to false. You can define a for loop as follows.
            
            for ([initializers]; [condition]; [iterator];)
            {
                // Code to repeat goes here.
            }
            
            The [initializers] portion is used to initialize a value as a counter for the loop. On each iteration, the loop checks that the value of the counter is
            within the range to execute the for loop, specified in the [condition] portion, and if so, execute the body of the loop. At then end of each loop iteration,
            the [iterator] section is responsible for incrementing the loop counter. The following code example shows how to use a for loop to execute a code block
            10 times.
            
            for (int i = 0; i < 10; i++)
            {
                // Code to execute.
            }
            
            In this example, i = 0; is the initializer, i < 10; is the condition and i++ is the iterator.
            
            FOREACH LOOP
            While a for loop is easy to use, it can present some challenges depending on the situation. As an example, consider iterating over a collection or an array
            of values. You would need to know how many elements are in the collection or array. In many cases you will know this, but sometimes you may have collections
            or arrays that are dynamic and are not sized at compile-time. If the size of the collection or array changes during runtime, it might be better option to
            use a foreach loop. The following code example shows how to use a foreach loop to iterate a string array.
            
            string[] names = new string[10];
            // Process each name in the array.
            foreach (string name in names)
            {
                // Code to execute.
            }
            
            C# handles determining how many items are in the array and will stop executing the loop when the end is reached. The use of foreach loops can help prevent
            index out of bounds errors on arrays.
        */
    }
}
