using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Kudvenkat
{
    class H03_WhySingletonIsSealed
    {
        /*
            Why we need Sealed class for Singleton Design Pattern?
            If we remove Sealed keyword even then also we won't be able to inherit this class due to the protection level of private constructor. Then why we need Sealed
            class. The answer to this question is if we add a nested class inside the Singleton class and the nested class inherits the Singleton class. After this,
            we go to main method and then try to create the object of the nested class and invoke the PrintDetails() method. We would see the counter variable value is
            incremented to 2. This violates the principle of Singleton Design Pattern.
            
            DerivedSingleton is responsbile for invoking the private constructor of the Singleton class, which internally has incremented the counter value. Further,
            this has violated the principle of Singleton Pattern and created multiple objects. If you just put back the sealed keyword in front of the Singleton
            class, the program will throw a compile time error.
            
            See the working demo in class file SingletonWithoutSealed.cs.
        */
    }
}
