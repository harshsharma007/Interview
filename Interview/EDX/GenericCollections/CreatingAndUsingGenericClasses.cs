using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
{
    class CreatingAndUsingGenericClasses
    {
        /*
            Creating and Using Generic Classes
            Generic classes work by including a type parameter, T, in the class or interface declaration. You do not need to specify the type of T until you instantiate the class.
            To create a generic class, you need to:
            
            1. Add the type parameter T in angle brackets after the class name.
            2. Use the type parameter T in place of type names in your class members.
            
            The following example shows how to create a generic class:
            
            // Creating a Generic Class
            pubilc class CustomList<T>
            {
                public T this[int index]
                {
                    get; set;
                }
                
                public void Add(T item)
                {
                    // Method logic goes here
                }
                
                public void Remove(T item)
                {
                    // Method logic goes here
                }
            }
            
            When you create an instance of your generic class, you specify the type you want to supply as a type parameter. For example, if you want to use your custom
            list to store objects of type Coffee, you would supply Coffee as the type parameter.
            
            The following example shows how to instantiate a generic class:
            
            // Instantiating a Generic Class
            CustomList<Coffee> coffee = new CustomList<Coffee>;
            Coffee coffee1 = new Coffee();
            Coffee coffee2 = new Coffee();
            coffee.Add(coffee1);
            coffee.Add(coffee2);
            Coffee firstCoffee = coffee[0];
            
            When you instantiate a class, every instance of T within the class is effectively replaced with the type parameter you supply. For example, if you instantiate
            the CustomList class with a type parameter of Coffee:
            
            1. The Add method will only accept an argument of type Coffee.
            2. The Remove method will only accept an argument of type Coffee.
            3. The indexer will always provide a return value of type Coffee.
        */
    }
}
