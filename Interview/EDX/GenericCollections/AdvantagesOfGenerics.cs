using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
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
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var arrayList1 = new ArrayList();
            arrayList1.Add(coffee1);
            arrayList1.Add(coffee2);
            arrayList1.Add(tea1);
            
            // The Sort method throws a runtime exception because the collection is not homogenous.
            arrayList1.Sort();
            
            // The cast throws a runtime exception because you cannot cast a Tea instance to a Coffee instance.
            Coffee coffee3 = (Coffee)arrayList1[2];
            
            As an alternative to the ArrayList, suppose you use a generic List<T> to store a collection of Coffee objects. When you instantiate the list, you provide a type argument
            of Coffee. In this case, your list is guaranteed to be homogenous, because your code will not build if you attempt to add an object of any other type. The Sort method will
            work because your collection is homogenous. Finally, the indexer returns objects of type Coffee, rather than System.Object, so there is no risk of invalid cast exceptions.
            
            The following example shows an alternative to the ArrayList approach using the generic List<T> class:
            
            // Type Safety in Generic Collections
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            
            var genericList1 = new List<Coffee>();
            genericList1.Add(coffee1);
            genericList1.Add(coffee2);
            
            // This line causes a build error, as the argument is not of type Coffee.
            genericList1.Add(tea1);
            
            // The Sort method will work because the collection is guaranteed to be homogenous.
            genericList1.Sort();
            
            // The indexer returns objects of type Coffee, so there is no need to cast the return value
            Coffee coffee3 = genericList[1];
            
            No Casting
            Casting is a computationally expensive process. When you add items to an ArrayList, your items are implicitly cast to the System.Object type. When you retrieve items from
            an ArrayList, you must explicitly cast them back to their original type. Using generics to add and retrieve items without casting improves the performance of your application.
            
            No boxing and unboxing
            If you want to store value types in an ArrayList, the items must be boxed when they are added to the collection and unboxed when they are retrieved. Boxing and unboxing
            incurs a large computational cost and can significantly slow your applications, especially when you iterate over large collections. By contrast, you can add value types to
            generic lists without boxing and unboxing the value.
            
            The following example shows the difference between generic and non-generic collections with regard to boxing and unboxing:
            
            // Boxing and unboxing: Generic vs Non-Generic Collections
            int number1 = 1;
            var arrayList1 = new ArrayList();
            
            // This statement boxes the Int32 value as a System.Object
            arrayList1.Add(number1);
            
            // This statement unboxes the Int32 value
            int number2 = (int)arrayList1[0];
            var genericList1 = new List<Int32>();
            
            // This statement adds an Int32 value without boxing
            genericList1.Add(number1);
            
            // This statement retrieves the Int32 value without unboxing
            int number3 = genericList1[0];
        */
    }
}
