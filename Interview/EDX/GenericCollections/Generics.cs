using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
{
    class Generics
    {
        /*
            Generics
            In the topic on collections, you saw that the use of the ArrayList collection class allowed you to store different data types in the collection. This was in contrast to
            an array where the data types in the array must be of the same type. There is an inherent problem with the ArrayList however. The topic discussed that everything you
            store in the ArrayList is automatically converted to an Object data type, the root type in .NET. Recall from the OOP topics that polymorphism allows a base class to
            represent sub classes. .NET uses Object as the base class for all other class types created in C#.
            
            The fact that the ArrayList stores all items as Object also means that when retrieving the items, you need to do some casting or conversion of your own to ensure the objects
            returned are cast back to the type they were. This can be problematic and error prone. To help solve this issue, you should be using Generics.
            
            Generics enable you to create and use strongly typed collections that are type safe, do not require you to cast items and do not require you to box and unbox value types.
        */
    }
}
