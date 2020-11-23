using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    class Structs
    {
        /*
            Introducing structs
            
            In Visual C#, a struct is a programming construct that you can use to define custom types. Structs are essentially lightweight data structures that
            represent related pieces of information as a single item. For example:
            
            1. A struct named Point might consist of fields to represent an x-coordinate and a y-coordinate.
            2. A struct named Circle might consist of fields to represent an x-coordinate, a y-coordinate and a radius.
            3. A struct named Color might consist of fields to represent a red component, a green component and a blue component.
            
            Most of the built-in types in Visual C#, such as int, bool and char are defined by structs. You can use structs to create your own types that behave like
            built-in types.
            
            Creating structs
            
            You use the struct keyword to declare a struct, as shown by the following example:
            
            // Declaring a struct
            public struct Coffee
            {
                public int Strength;
                public string Bean;
                public string CountryOfOrigin;
                // Other methods, fields, properties and events.
            }
            
            The struct keyword is preceded by an access modifier - public in the above example - that specifies where you can use the type. You can use the following
            access modifiers in your struct declarations.
            
            Access modifier details
            1. public - The type is available to code running in any assembly.
            2. internal - The type is available to any code within the same assembly, but not available to code in another assembly. This is the default value if you
               do not specify an access modifier.
            3. private - The type is only available to code within the struct that contains it. You can only use the private access modifier with nested structs.
            
            Structs can contain a variety of members including constructors, fields, constants, properties, indexers, methods, operators, events and even nested types.
            Keep in mind that structs are intended to be lightweight therefore if you find yourself adding multiple methods, constructors and events, you should
            consider using a class method.
        */
    }
}
