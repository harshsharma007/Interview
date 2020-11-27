using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
{
    class GenericsDemo
    {
        public void GenericsMethod()
        {
            // Create string objects
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";

            // Add the items to a strongly-typed collection List<T>
            var coffeeBeverages = new List<string>();
            coffeeBeverages.Add(s1);
            coffeeBeverages.Add(s2);
            coffeeBeverages.Add(s3);
            coffeeBeverages.Add(s4);
            coffeeBeverages.Add(s5);

            // Write the collection to a console window
            foreach (string coffeeBeverage in coffeeBeverages)
            {
                Console.WriteLine(coffeeBeverage);
            }

            // Create a generic collection of Coffee objects
            // Create some items to add to the collection
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            // Add the items to a strongly-typed collection
            var hotBeverages = new List<Coffee>();
            hotBeverages.Add(coffee1);
            hotBeverages.Add(coffee2);
            hotBeverages.Add(coffee3);

            // Write the collection to a console window
            foreach (Coffee beverage in hotBeverages)
            {
                Console.WriteLine(beverage.Bean);
            }
        }

        public void CreateGenericDictionary()
        {
            // Using the Dictionary<TKey, TValue> Class.
            // Create a new Dictionary of strings with string keys.
            var coffeeCodes = new Dictionary<string, string>();

            // Add some entries to the Dictionary
            coffeeCodes.Add("CAL", "Cafe Au Lait");
            coffeeCodes.Add("CSM", "Cinammon Spice Mocha");
            coffeeCodes.Add("ER", "Espresso Romano");
            coffeeCodes.Add("RM", "Raspberry Mocha");
            coffeeCodes.Add("IC", "Iced Coffee");

            /*
                This statement would result in an ArgumentException because the key already exists.
                coffeeCodes.Add("IC", "Instant Coffee");
            */

            // To retrieve the value associated with a key, you can use the indexer
            // This will throw a KeyNotFoundException if they key does not exist.
            Console.WriteLine("The value associated with the key \"CAL\" is {0}", coffeeCodes["CAL"]);

            // Alternatively, you can use the TryGetValue method.
            // This returns true if the key exists and false if the key does not exist.

            string csmValue = "";
            if (coffeeCodes.TryGetValue("CSM", out csmValue))
            {
                Console.WriteLine("The value associated with the key \"CSM\" is {0}", csmValue);
            }
            else
            {
                Console.WriteLine("The key \"CSM\" was not found");
            }
        }
    }
}
