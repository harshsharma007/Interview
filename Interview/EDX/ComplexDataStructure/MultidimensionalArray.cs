using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class MultidimensionalArray
    {
        /*
            Multidimensional Array
            An array can have more than one dimension. The number of dimensions corresponds to the number of indices that are used to identify an individual element
            in the array. You can specify up to 32 dimensions, but you will rarely need more than three. You declare a multidimensional array variable just as you
            declare a single-dimensional array, but you separate the dimensions by using commas. The following code example shows how to create an array of integers
            with two dimensions.
            
            // Create an array that is 10 long (rows) by 10 wide (columns)
            int[ , ] arrayName = new int[10, 10];
            
            In order to access elements in a multidimensional array, you must include all indices as in the example code here.
            
            // Access the element in the first row and first column
            int value = arrayName[0, 0];
            
            // Access the element in the first row and second column
            int value = arrayName[0, 1];
            
            // Access the element in the second row and first column
            int value = arrayName[1, 0];
            
            Jagged Array
            A jagged array is simply an array of arrays, and the size of each array can vary. Jagged arrays are useful for modeling space data structures where you
            might not always want to allocate memory for every item if it is not going to be used. The following code example shows how to declare and initialize a
            jagged array. Note that you must specify the size of the first array, but you must not specify the size of the arrays that are contained within this array.
            You allocate memory to each array within a jagged array separately, by using the new keyword.
            
            int[][] jaggedArray = new int[10][];
            jaggedArray[0] = new Type[5];
            jaggedArray[1] = new Type[7];
            and so on.
        */
    }
}
