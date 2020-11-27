using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Interview.EDX.GenericCollections
{
    class CreatingEnumerableCollections
    {
        /*
            Creating Enumerable Collections
            To enumerate over a collection, you typically use a foreach loop. The foreach loop exposes each item in the collection in turn, in an order that is
            appropriate to the collection. The foreach statement masks some of the complexities of enumeration. For the foreach statement to work, a generic collection
            class must implement the IEnumerable<T> interface. This interface exposes a method, GetEnumerator, which must return an IEnumerator<T> type.
            
            The IEnumerator<T> Interface
            The IEnumerator<T> interface defines the functionality that all enumerators must implement.
            
            The IEnumerator<T> interface defines the following methods:
            +----------------------+-----------------------------------------------------------------------------------------------------+
            |         Name         |                        Description                                                                  |
            +----------------------+-----------------------------------------------------------------------------------------------------+
            |       MoveNext       |    Advanced the enumerator to the next item in the collection.                                      |
            +----------------------+-----------------------------------------------------------------------------------------------------+
            |       Reset          |    Sets the enumerator to its starting position, which is before the first item in the collection.  |
            +----------------------+-----------------------------------------------------------------------------------------------------+
            
            The IEnumerator<T> interface defines the following properties:
            +----------------------+-----------------------------------------------------------------------------------------------------+
            |         Name         |                        Description                                                                  |
            +----------------------+-----------------------------------------------------------------------------------------------------+
            |       Current        |        Gets the item that the enumerator is pointing to.                                            |
            +----------------------+-----------------------------------------------------------------------------------------------------+
            
            An enumerator is essentially a pointer to the items in the collection. The starting point for the pointer is before the first item. When you call the
            MoveNext method, the pointer advances to the next element in the collection. The MoveNext method returns true if the enumerator was able to advance one
            position, or false if it has reached the end of the collection. At any point during the enumeration, the Current property returns the item to which the
            enumerator is currently pointing.
            
            When you create an enumerator, you must define:
            1. Which item the enumerator should treat as the first item in the collection.
            2. In what order the enumerator should move through the items in the collection.
            
            An enumerator is essentially a pointer to the items in the collection. The starting point for the pointer is before the first item. When you call the
            MoveNext method, the pointer advances to the next element in the collection. The MoveNext method returns true if the enumerator was able to advance one
            position, or false if it has reached the end of the collection. At any point during the enumeration, the Current property returns the item to which the
            enumerator is currently pointing.
            
            When you create an enumerator, you must define:
            1. Which item the enumerator should treat as the first item in the collection.
            2. In what order the enumerator should move through the items in the collection.
            
            The IEnumerable<T> Interface
            The IEnumerable<T> interface defines a single method named GetEnumerator. This returns an IEnumerator<T> instance. The GetEnumerator method returns the
            default enumerator for your collection class. This is the enumerator that a foreach loop will use, unless you specify an alternative. However, you can
            create additional methods to expose alternative enumerators.
            
            The following example shows a custom collection class that implements a default enumerator, together with an alternative enumerator that enumerates the
            collection in reverse order:
        */
    }

    // Default and Alternative Enumerators
    class CustomCollection<T> : IEnumerable<T>
    {
        public IEnumerator<T> Backwards()
        {
            // This method returns an alternative enumerator. The implementation details are not shown.
            return null;
        }

        #region IEnumerable<T> members
        public IEnumerator<T> GetEnumerator()
        {
            // This method returns an alternative enumerator. The implementation details are not shown.
            return null;
        }
        #endregion

        #region IEnumerable Members
        IEnumerator IEnumerable.GetEnumerator()
        {
            // This method returns an alternative enumerator. The implementation details are not shown.
            throw new NotImplementedException();
        }
        #endregion
    }

    // The following example shows how you can use a default enumerator or an alternative enumerator to iterate through a collection:
    class CustomClass
    {
        public void Method()
        {
            // Enumerating a collection
            CustomCollection<Int32> numbers = new CustomCollection<Int32>();

            // Add some items to the collection. Use the default enumerator to iterate through the collection.
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Use the alternative enumerator to iterate through the collection
            foreach (int number in (IEnumerable<Int32>)numbers.Backwards())
            {
                Console.WriteLine(number);
            }
        }
    }

    /*
        Implementing the Enumerator
        You can provide an enumerator by creating a custom class that implements the IEnumerator<T> interface. However, if your custom collection class uses an
        underlying enumerable type to store data, you can use an iterator to implement the IEnumerable<T> interface without actually providing an IEnumerator<T>
        implementation. The best way to understand iterators is to start with a simple example.
        
        The following example shows how you can use an iterator to implement an enumerator:
    */

    class BasicCollection<T> : IEnumerable<T>
    {
        private List<T> data = new List<T>();
        public void FillList(params T[] items)
        {
            foreach (var datum in items)
            {
                data.Add(datum);
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var datum in data)
            {
                yield return datum;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    /*
        The example shows a custom generic collection class that uses a List<T> instance to store data. The List<T> instance is populated by the FillList method.
        When the GetEnumerator method is called, a foreach loop enumerates the underlying collection. Within the foreach loop, a yield return statement is used to return
        each item in the collection. It is this yield return statement that defines the iterator - essentially, the yield return statement pauses execution to return
        the current item to the caller before the next element in the sequence is retrieved. In this way, although the GetEnumerator method does not appear to return
        an IEnumerator type, the compiler is able to build an enumerator from the iteration logic that you provided.
    */
}
