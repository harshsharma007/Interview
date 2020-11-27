using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class GenericsDemo
    {
        public void GenericsMethod()
        {
            #region GenericCollections
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
            #endregion
        }
    }
}
