using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.ObjectOrientedProgramming
{
    class Constructors
    {
        /*
            Using Constructors
            If you take a look at the topic on Creating Classes, you'll notice that instantiate a class we used this line of code:
            
            DrinksMachine dm = new DrinksMachine();
            
            Notice how this looks similar to the syntax for calling a method. This is because when you instantiate a class, you are actually calling a special method
            called a constructor. A constructor is a method in the class that has the same name as the class. Constructors do not use a return value however, not even
            void, and they must have the same name as the class file.
            
            Constructors are often used to specify initial or default values for data members within the new object, as shown by the following example:
            
            // Adding a Constructor
            public class DrinksMachine
            {
                public int Age { get; set; }
                public DrinksMachine()
                {
                    Age = 0;
                }
            }
            
            A constructor that takes no parameters is known as the default constructor. This constructor is called whenever someone instantiates your class without
            providing any arguments. If you do not include a constructor in your class, the Visual C# compiler will automatically add an empty public default constructor
            to your compiled class (in order to enable class instantiation).
            
            In many cases, it is useful for consumers of your class to be able to specify initial values for data members when the class is instantiated. For example,
            when someone creates a new instance of DrinksMachine, it might be useful if they can specify the make and model of the machine at the same time. Your class
            can include multiple constructors with different signatures that enable consumers to provide different combinations of information when they instantiate
            your class. Recall method overloading.
            
            The following example shows how to add multiple constructors to a class:
            
            
        */
    }
}
