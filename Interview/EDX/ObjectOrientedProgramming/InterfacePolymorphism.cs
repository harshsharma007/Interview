using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class InterfacePolymorphism
    {
        /*
            Interface Polymorphism
            As it relates to interfaces, polymorphism states that you can represent an instance of a class as an instance of any interface that the class implements.
            Interface polymorphism can help to increase the flexibility and modularity of your code. Suppose you have several classes that implement an IBeverage
            interface, such as Coffee, Tea, Juice and so on. You can write code that works with any of these classes as instances of IBeverage, without knowing any
            details of the implementing class. For example, you can build a collection of IBeverage instances without needing to know the details of every class that
            implements IBeverage.
            
            For example, if the Coffee class implements the IBeverage interface, you can represent a new Coffee object as an instance of Coffee or an instance of
            IBeverage:
            
            // Representing an Object as an Interface Type
            Coffee coffee1 = new Coffee();
            IBeverage coffee2 = new Coffee();
            
            You can use an implicit cast to convert to an interface type, because you know that the class must include all the interface members.
            
            // Casting to an Interface Type
            IBeverage beverage = coffee1;
            
            You must use an explicit cast to convert from an interface type to a derived class type, as the class may include members that are not defined in the
            interface.
            
            // Casting an Interface Type to a Derived Class Type
            Coffee coffee3 = beverage as Coffee;
            // OR
            Coffee coffee4 = (Coffee)beverage;
            
            Implementing Multiple Interfaces
            In many cases, you will want to create classes that implement more than one interface. For example, you might want to:
            1. Implement the IDisposable interface to enable the .NET runtime to dispose of your class correctly.
            2. Implement the IComparable interace to enable collection classes to sort instances of your class.
            3. Implement your own custom interface to define the functionality of your class.
            
            To implement multiple interfaces, you add a comma-separated list of the interfaces that you want to implement to your class declaration. Your class must
            implement every member of every interface you add to your class declaration. The following example shows how to create a class that implements multiple
            interfaces:
            
            // Declaring a Class that Implements Multiple Interfaces
            public class Coffee: IBeverage, IInventoryItem
            {
                
            }
        */
    }
}
