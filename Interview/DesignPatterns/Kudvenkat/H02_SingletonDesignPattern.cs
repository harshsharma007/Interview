using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Kudvenkat
{
    class H02_SingletonDesignPattern
    {
        /*
            Singleton Design Pattern
            Singleton Pattern belongs to Creational Type pattern. This pattern is used when we need to ensure that only one object of a particular class need to be
            created. All further references to the objects are referred to the same underlying instance created.
            
            +---------------------------+       +---------------------------+       +---------------------------+
            |       ClientObj A         |       |       ClientObj B         |       |       ClientObj C         |
            +---------------------------+       +---------------------------+       +---------------------------+
                        |                                   |                                   |
                        |                                   |                                   |
                        +---------------------------+       |        +--------------------------+
                                                    |       |        |
                                               +----------------------------+
                                               |        Singleton Object    |
                                               +----------------------------+
                                                            |
                                                            |
                                               +----------------------------+
                                               |            Task            |
                                               +----------------------------+
            Gang of Four have identified 5 Design Patterns that belong to Creational Design Type Catergory, which are Singleton, Factory, AbstractFactory, Builder and
            Prototype patterns. As the name implies, Creational Design Type deals with the object creation mechanisms. To simplify this, Creational Pattern explains of 
            the creation of objects in a manner suitable to a given situation.
            
            Singleton Design Pattern is used when we need to ensure that only one object of a particular class is instantiated. That single instance created is
            responsible to coordinate actions across the application. If you look at the illustrated diagram you will see different objects trying to invoke an object
            instantiated a singleton. This single instance of the object is responsible to invoke underneath methods or events.
            
            Singleton Advantages and Guidelines
            Advantages of Singleton
            - Singleton controls concurrent access to the resource.
            - It ensures there is only one object available across the application in a controlled state.
            
            Implementation Guidelines
            - Ensure that only one instance of the class exists
            - Provide global access to that instance by
                - Declaring all constructors of the class to be private
                - Providing static method that returns a reference to the instance
                - The instance is stored as a private static variable.
        */
    }
}
