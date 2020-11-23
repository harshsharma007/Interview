using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class UsingSimpleCollections
    {
        /*
            Using Collections
            The most commonly used list collection is the ArrayList class. The ArrayList stores items as a linear collection of objects. You can add objects of any
            type to an ArrayList collection, but the ArrayList represents each item in the collection as a System.Object instance. When you add an item to an ArrayList
            collection, the ArrayList implicitly casts, or converts, your item to the Object type. When you retrieve items from collection, you must explicitly cast
            the object back to its original type.
            
            The following example shows how to add and retrieve items from an ArrayList collection:
            
            Adding and retrieving items from an ArrayList
            
            // Create a new ArrayList collection
            ArrayList beverages = new ArrayList();
            
            // Create some items to add to the collection.
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Arabica", "Indonesia");
            
            // Add the items to the collection
            // Items are implicitly cast to the Object type when you add them.
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);
            
            // Retrieve items from the collection.
            // Items must be explicitly cast back to their original type.
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];
            
            When you work with collections, one of your most common programming tasks will be to iterate over the collection. Essentially, this means that you retrieve
            each item from the collection in turn, usually to render a list of items, to evaluate each item against some criteria, or to extract specific member
            values from each item. To iterate over a collection, you use a foreach loop. The foreach loop exposes each item from the collection in turn, using the
            variable name you specify in the loop declaration.
            
            The following example shows how to iterate over an ArrayList collection:
            
            // Iterating over a List Collection
            foreach(Coffee coffee in beverages)
            {
                Console.WriteLine("Bean type: {0}", coffee.Bean);
                Console.WriteLine("Country of Origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5): {0}", coffee.Strength);
            }
            
            Using Dictionary Collections
            Dictionary classes store collections of key/value pairs. The most commonly used dictionary class is the Hashtable. When you add an item to a Hashtable
            collection, you must specify a key and a value. Both the key and the value can be instances of any type, but the Hashtable implicitly casts both the key
            and the value to the Object type. When you retrieve values from the collection, you must explicitly cast the object back to its original type.
            
            The following example shows how to add and retrieve items from a Hashtable collection. In this case both the key and the values are strings:
            
            Adding and retrieving items from a Hashtable
            
            // Create a new Hashtable collection
            Hashtable ingredients = new Hashtable();
            
            // Add some key/value pairs to the collection
            ingredients.Add("Cafe au Lait", "Coffee, Milk");
            ingredients.Add("Cafe Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");
            
            // Check whether a key exists
            if(ingredients.ContainKey("Cafe Mocha"))
            {
                // Retrieve the value associated with a key
                Console.WriteLine("The ingredients of a Cafe Mocha are: {0}", ingredients["Cafe Mocha"]);
            }
            
            Dictionary classes, such as the Hashtable, actually contain two enumerable collections - the keys and the values. You can iterate over either of these
            collections. In most scenarios, however, you are likely to iterate through the key collection, for example to retrieve the value associated with each key
            in turn.
            
            The following example shows how to iterate over the keys in a Hashtable collection and retrieve the value associated with each key:
            
            // Iterating over a Dictionary Collection
            foreach(string key in ingredients.Keys)
            {
                // For each key in turn, retrieve the value associated with the key.
                Console.WriteLine("The ingredients of a {0} and {1}", key, ingredients[key]);
            }
        */
    }
}
