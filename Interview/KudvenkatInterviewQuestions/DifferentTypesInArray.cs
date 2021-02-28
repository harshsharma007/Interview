using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.KudvenkatInterviewQuestions
{
    class DifferentTypesInArray
    {
        /*
            Can you store different types in an array in C#?
            Yes, if you create an object array. Since all types inherit (directly or indirectly) from object type, we can add any type to the object array, including
            complex types like Customer, Employee etc. You need to override the ToString() method if you want meaningful output when ToString() method is invoked.
        */

        public void MainMethod()
        {
            /*
                In this array of int, we can only store int values. If we try to store string values, we would get compilation errors right away. This array is a
                strongly-typed array.
                
                If you want to store different data types within an array create an array of type object. Then we can store string, int together in an object array.
                Because object type is the base type for all types in dotnet, every type within dotnet directly or indirectly inherit from object type. So we can add
                any type of object to this array including complex types.
            */

            int[] array = new int[2];
            array[0] = 1;

            Customer customer = new Customer { ID = 1, Name = "Kudvenkat" };

            object[] arrayObject = new object[3];
            arrayObject[0] = 1;
            arrayObject[1] = "string";
            arrayObject[2] = customer;

            foreach (object obj in arrayObject)
            {
                Console.WriteLine(obj);
            }
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        /*
            To be able to print the value of Customer object, then we have to override the ToString method. Otherwise, if we don't do that then it will just prints
            out the name of the type that is the name of the class. The name of the class is Customer and since that class is present in 
            Interview.KudvenkatInterviewQuestions namespace, the complete name of the class including the namespace is printed. This won't make sense to the end user.
        */
    }
}
