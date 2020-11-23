using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class UsingCollectionInterfaces
    {
        /*
            Using Collection Interfaces
            The System.Collections.Generic namespace provides a range of generic collections to suit various scenarios. However, there will be circumstances when you will want to
            create your own generic collection classes in order to provide more specialized functionality. For example, you might want to store data in a tree structure or create a
            circular linked list.
            
            Where should you start when you want to create a custom collection class? All collections have certain things in common. For example, you will typically want to be able to
            enumerate the items in the collection by using a foreach loop, and you will need methods to add items, remove items and clear the list.
            
            The IEnumerable and IEnumerable<T> Interfaces
            If you want to be able to use a foreach loop to enumerate over the items in your custom generic collection, you must implement the IEnumerable<T> interface. The IEnumerable<T>
            interface defines a single method named GetEnumerator(). This method must return an object of type IEnumerator<T>. The foreach statement relies on this enumerator object
            to iterate through the collection.
            
            The IEnumerable<T> interface inherits from the IEnumerable interface, which also defines a single method named GetEnumerator(). When an interface inherits from another
            interface, it exposes all the members of the parent interface. In other words, if you implement IEnumerable<T>, you also need to implement IEnumerable.
            
            The ICollection<T> Interface
            
        */
    }
}
