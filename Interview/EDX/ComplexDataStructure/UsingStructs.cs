using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class UsingStructs
    {
        /*
            To create an instance of a struct, you use the new keyword, as shown by the following example:
            
            Instantiating a Struct
            Coffee coffee = new Coffee();
            coffee.Strength = 3;
            coffee.Bean = "Arabica";
            coffee.CountryOfOrigin = "Kenya";
            
            Initializing Structs
            You might have noticed that the syntax for instantiating a struct, for example, new Coffee(), is similar to the syntax for calling a method. This is because
            when you instantiate a struct, you are actually calling a special type of method called a constructor. A constructor is a method in the struct that has
            the same name as the struct.
            
            When you instantiate a struct with no arguments, such as new Coffee(), you are calling the default constructor which is created by the Visual C# compiler.
            If you want to be able to specify default field values when you instantiate a struct, you can add constructors that accept paramaters to your struct.
            
            The following example shows how to create a constructor in struct:
            
            Adding a constructor
            
            public struct Coffee
            {
                // This is the custom constructor.
                public Coffee(int strength, string bean, string CountryOfOrigin)
                {
                    this.Strength = strength;
                    this.Bean = bean;
                    this.CountryOfOrigin = countryOfOrigin;
                }
                
                // These statements declare the struct fields and set the default values.
                public int Strength;
                public string Bean;
                public string CountryOfOrigin;
                // Other methods, fields, properties and events.
            }
            
            The following example shows how to use the constructor to instantiate a Coffee item:
            
            Calling a Constructor
            
            // Call the custom constructor by providing arguments for the three required parameters.
            Coffee coffee = new Coffee(4, "Arabica", "Colombia");
            
            You can add multiple constructors to your struct, with each constructor accepting a different combination of parameters. However, you cannot add a default
            constructor to a struct because it is created by the compiler.
        */
    }
}
