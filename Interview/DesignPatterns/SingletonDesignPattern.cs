using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns
{
    class SingletonDesignPattern
    {
        //What is Singleton Design Pattern?
        //1. It ensures a class has only one instance and provides a global point of access to it.
        //2. A singleton is a class that only allows a single instance of itself to be created and usually gives simple access to that instance.
        //3. Most commonly, singletons don't allow any parameters to be specified when creating the instance, since a second request of an instance with a different
        //parameter could be problematic. (If the same instance should be accessed for all requests with the same parameter then the factory pattern is more
        //appropriate.)

        //There are various ways to implement Singleton Pattern in C#. The following are the common characteristics of a Singleton Pattern.
        //1. A single constructor that is private and parameterless.
        //2. Class is sealed.
        //3. The static variable that holds a reference to the single created instance, if any.
        //4. A public static means of getting the reference to the single created instance, creating one if necessary.

        //Advantages of Singleton Pattern are:
        //1. Singleton pattern can implement interfaces.
        //2. It can also be inherited from other classes.
        //3. It can be lazy loaded.
        //4. It has Static Initialization.
        //5. It can be extended into a factory pattern.
        //6. It helps to hide dependencies.
        //7. It provides a single point of access to a particular instance, so it is easy to maintain.

        //Disadvantages of Singleton Pattern are:
        //1. Unit testing is more difficult (because it introduces a global state into an application).
        //2. This pattern reduces the potential for parallelism within a program, because to access the singleton in a multi-threaded system, an object must be serialized.

        //Singleton class vs Static methods
        //1. A Static class cannot be extended whereas a singleton class can be extended.
        //2. A Static class can still have instances (unwanted instances) whereas a singleton class prevents it.
    }
}
