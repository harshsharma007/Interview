using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
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
            The ICollection<T> interface defines the basic functionality that is common to all generic collections. The interface inherits from IEnumerable<T>, which
            means that if you want to implement ICollection<T>, you must also implement the members defined by IEnumerable<T> and IEnumerable.
            
            The ICollection<T> interface defines the following methods:            
            +-------------------+-----------------------------------------------------------------------------------+
            |       Name        |       Description                                                                 |
            +-------------------+-----------------------------------------------------------------------------------+
            |       Add         |       Adds an item of type T to the collection.                                   |
            +-------------------+-----------------------------------------------------------------------------------+
            |       Clear       |       Removes all items from the collection.                                      |
            +-------------------+-----------------------------------------------------------------------------------+
            |       Contains    |       Indicates whether the collection contains a specific value.                 |
            +-------------------+-----------------------------------------------------------------------------------+
            |       CopyTo      |       Copies the items in the collection to an array.                             |
            +-------------------+-----------------------------------------------------------------------------------+
            |       Remove      |       Removes a specific object from the collection.                              |
            +-------------------+-----------------------------------------------------------------------------------+
            
            The ICollection<T> interface defines the following properties.            
            +-------------------+-----------------------------------------------------------------------------------+
            |       Name        |       Description                                                                 |
            +-------------------+-----------------------------------------------------------------------------------+
            |       Count       |       Gets the number of items in the collection.                                 |
            +-------------------+-----------------------------------------------------------------------------------+
            |    IsReadOnly     |       Indicates whether the collection is read-only.                              |
            +-------------------+-----------------------------------------------------------------------------------+
            
            The IList<T> Interface
            The IList<T> interface defines the core functionality for generic list classes. You should implement the interface if you are defining a linear collection
            of single values. In addition to the members it inherits from ICollection<T>, the IList<T> interface defines methods and properties that enable you to use
            indexers to work with the items in the collection. For example, if you create a list named myList, you can use myList[0] to access the first item in the
            collection.
            
            The IList<T> interface defines the following methods:            
            +-------------------+-----------------------------------------------------------------------------------+
            |       Name        |       Description                                                                 |
            +-------------------+-----------------------------------------------------------------------------------+
            |       Insert      |       Inserts an item into collection at the specified index.                     |
            +-------------------+-----------------------------------------------------------------------------------+
            |      RemoveAt     |       Removes the item at the specified index from the collection.                |
            +-------------------+-----------------------------------------------------------------------------------+
            
            The IList<T> interface defines the following properties:
            +-------------------+-----------------------------------------------------------------------------------+
            |       Name        |       Description                                                                 |
            +-------------------+-----------------------------------------------------------------------------------+
            |       IndexOf     |       Determines the position of a specified item in the collection.              |
            +-------------------+-----------------------------------------------------------------------------------+
            
            The IDictionary<TKey, TValue> Interface
            The IDictionary<TKey, TValue> interface defines the core functionality for generic dictionary classes. You should implement this interface if you are defining a collection
            of key-value pairs. In addition to the members it inherits from ICollection<T>, the IDictionary<T> interface defines methods and properties that are specific to working
            with key-value pairs. The IDictionary<TKey, TValue> interface defines the following methods:
            
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |       Name        |       Description                                                                                                             |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |       Add         |       Adds an item with the specified key and value to the collection.                                                        |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |    ContainsKey    |       Indicates whether the collection includes a key-value pair with the specified key.                                      |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |   GetEnumerator   |       Returns an enumerator of KeyValuePair<TKey, TValue> objects.                                                            |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |      Remove       |       Removes the item with the specified key from the collection.                                                            |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |    TryGetValue    |       Attempts to set the value of an output parameter to the value associated with a specified key. If the key exists, the   |
            |                   |       method returns true. If the key does not exist, the method returns false and the output parameter is unchanged.         |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            
            The IDictionary<TKey, TValue> interface defines the following properties:
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |       Name        |       Description                                                                                                             |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |       Item        |       Gets or sets the value of an item in the collection, based on a specified key. This property enables you to use indexer |
            |                   |       notation, for example myDictionary[myKey] = myValue                                                                     |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |       Keys        |       Returns the keys in the collection as an ICollection<T> instance.                                                       |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
            |       Values      |       Returns the value in the collection as an ICollection<T> instance.                                                      |
            +-------------------+-------------------------------------------------------------------------------------------------------------------------------+
        */
    }
}
