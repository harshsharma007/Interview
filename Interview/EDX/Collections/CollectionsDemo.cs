using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class CollectionsDemo
    {
        #region Collections
        public void CreateArrayList()
        {
            // Create a new ArrayList collection
            ArrayList beverages = new ArrayList();

            // Create some items to add to the collection
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            // Add the items to the collection
            // Items are implicitly cast to the Object type when you add them
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);

            // Retrieve items from the collection
            // Items must be explicitly cast back to their original type
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];

            Console.WriteLine(firstCoffee);
            Console.WriteLine(secondCoffee);
            OutputCollection(beverages);
        }

        public void OutputCollection(ArrayList beverages)
        {
            // Iterating over a List collection
            foreach (Coffee coffee in beverages)
            {
                Console.WriteLine("Bean type: {0}", coffee.Bean);
                Console.WriteLine("Country Of Origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5): {0}", coffee.Strength);
            }
        }

        // Hashtable is also known as a Dictionary. If anybody comes and say, we need a dictionary, you'll be creating a Hashtable.
        public void CreateHashtable()
        {
            // Create a new Hashtable collection
            Hashtable ingredients = new Hashtable();

            // Add some key/value pairs to the collection
            ingredients.Add("Cafe au Lait", "Coffee, Milk");
            ingredients.Add("Cafe Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");

            OutputHashtable(ingredients);
        }

        public void OutputHashtable(Hashtable hashtable)
        {
            // Check whether a key exists
            if (hashtable.ContainsKey("Cafe Mocha"))
            {
                // Retrieve the value associated with a key
                Console.WriteLine("The ingredients of a Cafe Mocha are: {0}", hashtable["Cafe Mocha"]);
            }

            // Iterating over a Dictionary Collection
            foreach (string key in hashtable.Keys)
            {
                // For each key in turn, retrieve the value associated with the key
                Console.WriteLine("The ingredients of a {0} are {1}", key, hashtable[key]);
            }
        }
        #endregion
    }
}
