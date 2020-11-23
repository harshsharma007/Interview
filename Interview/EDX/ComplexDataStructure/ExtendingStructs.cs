using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class ExtendingStructs
    {
        /*
            Extending Structs
            In order to go beyond a simple struct, you can extend it by adding properties and indexers. This section discusses using properties and indexers in your
            struct. Again, if you find yourself going to this extent, evaluate your use of structs against class files.
            
            Creating Properties
            In Visual C#, a property is a programming construct that enables client code to get or set the value of private fields within a struct or a class. To
            consumers of your struct or class, the property behaves like a public field. Within your struct or class, the property is implemented by using accessors,
            which are a special type of method. A property can include one or both of the following:
            
            1. A get accessor to provide read access to a field.
            2. A set accessor to provide write access to a field.
            
            The following example shows how to implement a property in a struct:
            
            // Implementing a Property
            public struct Coffee
            {
                private int strength;
                public int Strength
                {
                    get
                    {
                        return strength;
                    }
                    set
                    {
                        strength = value;
                    }
                }
            }

            Within the property, the get and set accessors use the following syntax:
            1. The get accessor uses the return keyword to return the value of the private field to the caller.
            2. The set accessor uses a special local variable named value to set the value of the private field. The value variable contains the value provided by the
               client code when it accessed the property.

            The following example shows how to use a property:

            // Using a Property
            Coffee coffee = new Coffee();

            // The following code invokes the set accessor.
            coffee.strength = 3;

            // The following code invokes the get accessor.
            int coffeeStrength = coffee.Strength;

            The client code uses the property as if as it was a public field. However, using public properties to expose private fields offers the following advantages
            over using public fields directly:
            
            1. You can use properties to control external access to your fields. A property that includes only a get accessor is read-only, while a property that includes
            only a set accessor is write-only.

            // This is a read-only property.
            public int Strength
            {
                get
                {
                    return strength;
                }
            }

            // This is a write-only property.
            public string Bean
            {
                set
                {
                    bean = value;
                }
            }

            2. You can change the implementation of properties without affecting client code. For example, you can add validation logic, or call a method instead of
            reading a field value.

            public int Strength
            {
                get
                {
                    return strength;
                }
                set
                {
                    if (value < 1)
                    {
                        strength = 1;
                    }
                    else if (value > 5)
                    {
                        strength = 5;
                    }
                    else
                    {
                        strength = value;
                    }
                }
            }

            3. Properties are required for data binding in WPF. For example, you can bind controls to property values, but you cannot bind controls to field values.
            
            When you want to create a property that simply gets and sets the value of a private field without performing any additional logic, you can use an
            abbreviated syntax.

            To create a property that reads and writes to a private field, you can use the following syntax:
            public int Strength { get; set; }

            4. To create a property that reads from a private field, you can use the following syntax:
            public int Strength { get; }

            5. To create a property that writes to a private field, you can use the following syntax:
            public int Strength { set; }

            In each case, the compiler will implicitly create a private field and map it to your property. These are known as auto-implemented properties. You can
            change the implementation of your property at any time.

            // Creating Indexers
            In some scenarios, you might want to use a struct or a class as a container for an array of values. For example, you might create a struct to represent
            the beverages available at a coffee shop. The struct might use an array of strings to store the list of beverages.

            The following example shows a struct that includes an array:

            // Creating a Struct that includes an array.
            public struct Menu
            {
                public string[] beverages;
                public Menu(string bev1, string bev2)
                {
                    beverages = new string[] { "Americano", "Cafe au Lait", "Cafe Macchiato", "Cappuccino", "Espresso" };
                }
            }

            When you expose the array as public field, you would use the following syntax to retrieve beverages from the list:

            // Accessing Array Items Directly
            Menu myMenu = new Menu();
            string firstDrink = myMenu.beverages[0];

            A more intuitive approach would be if you could access the first item from the menu by using the syntax myMenu[0]. You can do this by creating an indexer.
            An indexer is similar to a property, in that it uses get and set accessors to control access to a field. More importantly, an indexer enables you to access
            collection members directly from the name of the containing struct or class by providing an integer index value. To declare an indexer, you use the
            this keyword, which indicates that the property will be accessed by using the name of the struct instance.

            The following example shows how to define an indexer for a struct:

            // Creating an Indexer
            public struct Menu
            {
                private string[] beverages;
                
                // This is the indexer.
                public string this[int index]
                {
                    get
                    {
                        return this.beverages[index];
                    }
                    set
                    {
                        this.beverages[index] = value;
                    }
                }

                // Enable client code to determine the size of the collection.
                public int Length
                {
                    get
                    {
                        return beverages.Length;
                    }
                }
            }
            
            When you use an indexer to expose the array, you use the following syntax to retrieve the beverages from the list:

            // Accessing Array Items by using an Indexer
            Menu myMenu = new Menu();
            string firstDrink = myMenu[0];
            int numberOfChoices = myMenu.Length;

            Just like a property, you can customize the get and set accessors in an indexer without affecting client code. You can create a read-only indexer by
            including only a get accessor, and you can create a write-only indexer by including only a set accessor.
        */
    }
}
