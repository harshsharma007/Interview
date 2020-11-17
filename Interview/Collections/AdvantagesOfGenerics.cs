using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Collections
{
    class AdvantagesOfGenerics
    {
        /*
            Advantages of Generics
            The use of generic classes, particularly for collections, offers three main advantages over non-generic approaches: type safety, no casting and no boxing
            and unboxing.
            
            Type Safety
            Consider an example where you use an ArrayList to store a collection of Coffee objects. You can add objects of any type to an ArrayList. Suppose a developer
            adds an object of type Tea to the collection. The code will build without complaint. However, a runtime exception will occur if the Sort method is called,
            because the collection is unable to compare objects of different types. Furthermore, when you retrieve an object from the collection, you must cast the
            object to the correct type. If you attempt to cast the object to the wrong type, an invalid cast runtime exception will occur.
            
            The following example shows the type safety limitations of the ArrayList approach:
            
            // Type Safety Limitations for Non-Generic Collections
        */
    }
}
