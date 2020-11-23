using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class SingleDimensionArrays
    {
        /*
            Creating and using single dimension arrays
            
            When you declare an array, you specify the type of data that it contains and a name for the array. Declaring an array brings the array into scope, but
            does not actually allocate any memory for it. The CLR physically creates the array when you use the new keyword. At this point, you should specify the size
            of the array.
            
            To declare a single-dimensional array, you specify the type of elements in the array and use brackets, [] to indicate that a variable is an array. Later,
            you specify the size of the array when you allocate memory for the array by using the new keyword. The size of an array can be any integer expression. The
            following code example shows how to create a single-dimensional array of integers with elements zero through nine.
            
            int[] arrayName = new int[10];
            
            You can also choose to create an array and initialize it with values at the same time as in the following example that declares an integer array and assigns
            values to it. The compiler know how large to make the array by the number of values in the curly braces:
            
            int[] arrayName = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            
            Accessing data in an array
            
            You can access data in an array in several ways, such as by specifying the index of a specific element that you require or by iterating through the entire
            array and returning each element in sequence. The following code example uses an index to access the element at index two.
            
            // Accessing data by index
            int[] oldNumbers = {1, 2, 3, 4, 5};
            
            // Number will contain the value 3
            int number = oldNumbers[2];

            Note: Arrays are zero-indexed, so the first element in any dimension in an array is at index zero. The last element in a dimension is at index N-1, where
            N is the size of the dimension. If you attempt to access an element outside this range, the CLR throws an IndexOutOfRangeException exception.

            You can iterate through an array by using a for loop. You can use the Length property of the array to determine when to stop the loop.
            
            The following code example shows how to use a for loop to iterate through an array.
            
            // Iterating over an array
            
            int[] oldNumbers = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < oldNumbers.Length; i++)
            {
                int number = oldNumbers[i];
            }
        */
    }
}
