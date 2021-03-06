using System;
using System.Collections;
using System.Text;

namespace Interview.Collections
{
    class HashTableCollection
    {
        /*
            The Hashtable class represents a collection of key-and-value pairs that are organized based on the hash code of the key. It uses the key to access the
            elements in the collection.
            
            A hash table is used when you need to access elements by using key, and you can identify a useful key value. Each item in the hash table has a key/value
            pair. The key is used to access the items in the collection.
            
            Methods and Properties of the Hashtable class
            
            The following table lists some of the commonly used properties of the Hashtable class:
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Count               |   Gets the number of key and value pairs contained in the Hashtable.                          |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   IsFixedSize         |   Gets a value indicating whether the Hashtable has a fixed size.                             |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   IsReadOnly          |   Gets a value indicating whether the Hashtable is read-only.                                 |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Item                |   Gets or sets the value associated with the specified key.                                   |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Keys                |   Gets an ICollection containing the keys in the Hashtable.                                   |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            |   Values              |   Gets an ICollection containing the values in the Hashtable.                                 |
            +-----------------------+-----------------------------------------------------------------------------------------------+
            
            The following table lists some of the commonly used methods of the Hashtable class:
            +-------------------------------------------------------+-----------------------------------------------------------------------------------+
            |   public virtual void Add(object key, object value);  |   Adds an element with the specified key and value into the Hashtable.            |
            +-------------------------------------------------------+-----------------------------------------------------------------------------------+
            |   public virtual void Clear();                        |   Removes all elements from the Hashtable.                                        |
            +-------------------------------------------------------+-----------------------------------------------------------------------------------+
            |   public virtual bool ContainsKey(object key);        |   Determines whether the Hashtable contains a specific key.                       |
            +-------------------------------------------------------+-----------------------------------------------------------------------------------+
            |   public virtual bool ContainsValue(object value);    |   Determines whether the Hashtable contains a specific value.                     |
            +-------------------------------------------------------+-----------------------------------------------------------------------------------+
            |   public virtual void Remove(object key);             |   Removes the element with the specified key from the Hashtable.                  |
            +-------------------------------------------------------+-----------------------------------------------------------------------------------+
        */

        public HashTableCollection()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "Zara Ali");
            hashtable.Add(2, "Abida Rehman");
            hashtable.Add("2", "Joe Holzner");

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("The Hashtable Key {0} contains value {1}", key, hashtable[key]);
            }

            if (hashtable.ContainsKey(1))
            {
                Console.WriteLine("Key already exists!!");
            }
            else
            {
                hashtable.Add(1, "Harsh Sharma");
                Console.WriteLine("New entry added to Hashtable!!");
            }

            ICollection collection = hashtable.Keys;
            foreach (var key in collection)
            {
                Console.WriteLine("Key name is {0}", key);
            }
        }
    }
}
