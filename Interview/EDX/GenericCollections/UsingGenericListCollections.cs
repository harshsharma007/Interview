using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
{
    class UsingGenericListCollections
    {
        /*
            Using Generic List Collections
            One of the most common and important uses of generics is in collection classes. Generic collections fall into two broad categories:
                generic list collections
                generic dictionary collections.
            A generic list stores a collection of objects of type T.
            
            The List<T> Class
            The List<T> class provides a strongly-typed alternative to the ArrayList class. Like the ArrayList class, the List<T> class includes methods to:
            
            1. Add an item.
            2. Remove an item.
            3. Insert an item at a specified index.
            4. Sort the items in the collection by using the default comparer or a specified comparer.
            5. Reorder all or part of the collection.
            
            The following example shows how to use the List<T> class.
            
            // Using the List<T> Class
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";
            
            // Add the items to a strongly-typed collection
            var coffeeBeverages = new List<String>();
            coffeeBeverages.Add(s1);
            coffeeBeverages.Add(s2);
            coffeeBeverages.Add(s3);
            coffeeBeverages.Add(s4);
            coffeeBeverages.Add(s5);
            
            // Sort the items using the default comparer.
            // For objects of type String, the default comparer sorts the items alphabetically.
            coffeeBeverages.Sort();
            
            // Write the collection to a console window
            foreach(String coffeeBeverage in coffeeBeverages)
            {
                Console.WriteLine(coffeeBeverage);
            }
            
            Other Generic List Classes
            The System.Collections.Generic namespace also includes various generic collections that provide more specialized functionality:
            
            1. The LinkedList<T> class provides a generic collection in which each item is linked to the previous item in the collection and the next item in the collection. Each
               item in the collection is represented by a LinkedListNode<T> object, which contains a value of type T, a reference to the parent LinkedList<T> instance, a reference to
               the previous item in the collection, and a reference to the next item in the collection.
            2. The Queue<T> class represents a strongly typed first in, first out collection of objects.
            3. The Stack<T> class represents a strongly typed last in, first out collection of objects.
            
            Using Generic Dictionary Collections
            Dictionary classes store collections of key value pairs. The value is the object you want to store, and the key is the object you use to index and retrieve the value.
            For example, you might use a dictionary class to store coffee recipes, where the key is the name of the coffee and the value is the recipe for that coffee. In the case
            of generic dictionaries, both the key and the value are strongly typed.
            
            The Dictionary<TKey, TValue> Class
            The Dictionary<TKey, TValue> class provides a general purpose, strongly typed dictionary class. You can add duplicate values to the collection, but the keys must be unique.
            The class will throw an ArgumentException if you attempt to add a key that already exists in the dictionary.
            
            The following example shows how to use the Dictionary<TKey, TValue> class:
            
            // Using the Dictionary<TKey, TValue> Class
            // Create a new dictionary of strings with string keys
            var coffeeCodes = new Dictionary<String, String>();
            
            // Add some entries to the dictionary
            coffeeCodes.Add("CAL", "Cafe Au Lait");
            coffeeCodes.Add("CSM", "Cinammon Spice Mocha");
            coffeeCodes.Add("ER", "Espresso Romano");
            coffeeCodes.Add("RM", "Raspberry Mocha");
            coffeeCodes.Add("IC", "Iced Coffee");
            
            // This statement would result in an ArgumentException because the key already exists
            coffeeCodes.Add("IC", "Instant Coffee);
            
            // To retrieve the value associated with a key, you can use the indexer.
            // This will throw a KeyNotFoundException if the key does not exist.
            Console.WriteLine("The value associated with the key \"CAL\" is {0}", coffeeCodes["CAL"]);
            
            // Alternatively, you can use the TryGetValue method
            // This returns true if the key exists and false if the key does not exist.
            string csmValue = "";
            
            if(coffeeCodes.TryGetValue("CSM", out csmValue))
            {
                Console.WriteLine("The value associated with the key \"CSM\" is {0}", csmValue);
            }
            else
            {
                Console.WriteLine("The key \"CSM\" was not found");
            }
            
            // You can also use the indexer to change the value associated with a key.
            coffeeCodes["IC"] = "Instant Coffee";
            
            Other Generic Dictionary Classes
            The SortedList<TKey, TValue> and SortedDicitonary<TKey, TValue> classes both provide generic dictionaries in which the entires are sorted by key. The difference between
            these classes is in the underlying implementation.
            
            1. The SortedList generic class uses less memory than the SortedDictionary generic class.
            2. The SortedDictionary class is faster and more efficient at inserting and removing unsorted data.
        */
    }
}
