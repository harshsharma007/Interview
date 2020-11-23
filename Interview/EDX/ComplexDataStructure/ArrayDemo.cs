using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class ArrayDemo
    {
        public void DifferentArrays()
        {
            // Create an integer array of size 10.
            int[] intArray = new int[10];

            intArray[0] = 10;
            intArray[1] = 20;

            // Create an integer array of size 5 by initializing
            int[] newArray = { 1, 2, 3, 4, 5 };

            for (int counter = 0; counter < newArray.Length; counter++)
            {
                Console.WriteLine(newArray[counter]);
            }

            // Create a two dimensional array and iterate over it
            int[,] twoDArray = { { 3, 2 }, { 4, 5 }, { 5, 6 } };

            for (int x = 0; x < twoDArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDArray.GetLength(1); y++)
                {
                    int value = twoDArray[x, y];
                    Console.WriteLine(value);
                }
            }

            // Quiz - What would be the output of below code?
            char[,] multiArray = new char[3, 2] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
            Console.WriteLine(multiArray[2, 1]);
        }
    }
}
