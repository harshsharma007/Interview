using System;
using System.Collections;
using System.Text;

namespace Interview.Collections
{
    class SortedListCollection
    {
        /*
            The SortedList class represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index. A SortedList is a
            combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. If you access items using an index,
            it is an ArrayList and if you access items using a key it is a Hashtable. The collection of items is always sorted by the key value.
            
            Methods and Properties of the SortedList class
            
            The following table lists some of the commonly used properties of the SortedList class:
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Capacity            |   Gets or sets the capacity of the SortedList.                                                |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Count               |   Gets the number of elements contained in the SortedList.                                    |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   IsFixedSize         |   Gets a value indicating whether the SortedList has a fixed size.                            |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   IsReadOnly          |   Gets a value indicating whether the SortedList is read-only.                                |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Item                |   Gets or sets the value associated with the specified key.                                   |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Keys                |   Gets the keys in the SortedList.                                                            |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Values              |   Gets the values in the SortedList.                                                          |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            
            The following table lists some of the commonly used methods of the SortedList class
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual void Add(object key, object value);       |   Adds an element with the specified key and value into the SortedList.                      |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual void Clear();                             |   Removes all elements from the SortedList.                                                  |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual bool ContainsKey(object key);             |   Determines whether the SortedList contains a specific key.                                 |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual bool ContainsValue(object value);         |   Determines whether the SortedList contains a specific value.                               |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual object GetByIndex(int index);             |   Gets the value at the specified index of the SortedList.                                   |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual object GetKey(int index);                 |   Gets the key at the specified index of the SortedList.                                     |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual IList GetKeyList();                       |   Gets the key in the SortedList.                                                            |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual IList GetValueList();                     |   Gets the values in the SortedList.                                                         |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual int IndexOfKey(object key);               |   Returns the zero-based index of the specified key in the SortedList.                       |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual int IndexOfValue(object value);           |   Returns the zero-based index of the first occurrence of the specified value in the         |
            |                                                            |   SortedList.                                                                                |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual void Remove(object key);                  |   Removes the element with the specified key from the SortedList.                            |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual void RemoveAt(int index);                 |   Removes the elements at the specified index of SortedList.                                 |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
            |   public virtual void TrimToSize();                        |   Sets the capacity to the actual number of elements in the SortedList.                      |
            +------------------------------------------------------------+----------------------------------------------------------------------------------------------+
        */

        public SortedListCollection()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("1", "One");
            sortedList.Add("2", "Two");
            sortedList.Add("3", "Three");

            Console.WriteLine("Value present at Index 1 is {0}", sortedList.GetByIndex(1));
            Console.WriteLine("The Capacity of SortedList is {0}", sortedList.Capacity);
            Console.WriteLine("");

            Console.WriteLine("Keys present in SortedList are:");
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("");
            Console.WriteLine("Values present in SortedList are:");
            foreach (var value in sortedList.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("");
            Console.WriteLine("Index of Key \"2\" is {0}", sortedList.IndexOfKey("2"));
            Console.WriteLine("Index of Value \"Two\" is {0}", sortedList.IndexOfValue("Two"));

            if (sortedList.ContainsKey("1"))
                Console.WriteLine("Key \"1\" is present in the SortedList");
            else
                Console.WriteLine("Key \"1\" is not present in the SortedList");

            if (sortedList.ContainsValue("One"))
                Console.WriteLine("Value \"One\" is present in the SortedList");
            else
                Console.WriteLine("Value \"One\" is not present in the SortedList");
        }
    }
}
