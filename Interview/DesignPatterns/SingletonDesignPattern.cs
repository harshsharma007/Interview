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
        //2. A Static class can still have instances (unwanted instances), whereas a singleton class prevents it.
        //3. A Static class cannot be initialized with a STATE (parameter), whereas a singleton class can be.
        //4. A Static class is loaded automatically by the CLR when the program or namespace containing the class is loaded.

        //How to implement Singleton Pattern in your code. (There are many ways to implement a Singleton Pattern in C#)
        //1. No Thread Safe Singleton.
        //2. Thread-Safety Singleton.
        //3. Thread-Safety Singleton using Double-Check Locking.
        //4. Thread-Safety Singleton without using locks and no lazy instantiation.
        //5. Full Lazy instantiation.
        //6. Using .Net 4's Lazy<T> type.

        //1. No Thread Safe Singleton
        //Explanation of the following code:

        //1. The following code is not thread-safe.
        //2. Two different threads could both have evaluated the test (if instance == null) and found it to be true, the both creates instances, which violates the
        //singleton pattern.
        //3. Note that in fact the instance may already have been created before the expression is evaluated, but the memory model doesn't guarantee that the new value
        //of instance will be seen by other threads unless suitable memory barriers have been passed.

        //Bad Code
        public sealed class SingletonNotThreadSafe
        {
            private SingletonNotThreadSafe()
            {

            }

            private static SingletonNotThreadSafe instance = null;
            public static SingletonNotThreadSafe Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new SingletonNotThreadSafe();
                    }
                    return instance;
                }
            }
        }

        //2. Thread Safety Singleton
        //Explanation of the following code:

        //1. This implementation is thread-safe.
        //2. In the following code, the thread is locked on a shared project and checks whether an instance has been created or not.
        //3. This takes care of the memory barrier issue and ensures that only one thread will create an instance.
        //4. For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first thread will have
        //created the instance, so the expression will evaluate to be false.
        //5. The biggest problem with this is performance; performance sufferes since a lock is required every time an instance is requested.

        public sealed class SingletonThreadSafe
        {
            SingletonThreadSafe()
            {

            }

            private static readonly object padlock = new object();
            private static SingletonThreadSafe instance = null;
            public static SingletonThreadSafe Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadSafe();
                        }
                        return instance;
                    }
                }
            }
        }

        //3. Thread Safety Singleton using Double Check Locking
        //Explanation of the code:

        //1. In the following code, the thread is locked on a shared object and checks whether an instance has been created or not with double checking.

        public sealed class SingletonDoubleLock
        {
            SingletonDoubleLock()
            {

            }

            private static readonly object padlock = new object();
            private static SingletonDoubleLock instance = null;
            public static SingletonDoubleLock Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (padlock)
                        {
                            if (instance == null)
                            {
                                instance = new SingletonDoubleLock();
                            }
                        }
                    }
                    return instance;
                }
            }
        }

        //4. Thread Safe Singleton without using locks and no lazy instantiation
        //Explanation of the code:

        //1. The preceding implementation looks like very simple code.
        //2. This type of implementation has a static constructor, so it executes only once per Application Domain.
        //3. It is not as lazy as the other implementation.

        public sealed class SingletonNoLazy
        {
            private static readonly SingletonNoLazy instance = new SingletonNoLazy();

            //Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
            static SingletonNoLazy()
            {

            }
            private SingletonNoLazy()
            {

            }
            public static SingletonNoLazy Instance
            {
                get
                {
                    return instance;
                }
            }
        }

        //5. Full lazy instantiation
        //Explanation of the code:

        //1. Here, instantiation is triggered by the first reference to the static member of the nested class, that only occurs in instance.
        //2. This means the implementation is fully lazy, but has all the performance benefits of the previous ones.
        //3. Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be
        //internal here.
        //4. That doesn't raise any other problems, though, as the class itself is private.
        //5. The code is more complicated in order to make the instantiation lazy.

        public sealed class SingletonLazy
        {
            private SingletonLazy()
            {

            }

            public static SingletonLazy Instance
            {
                get
                {
                    return Nested.instance;
                }
            }

            private class Nested
            {
                //Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
                static Nested()
                {

                }
                internal static readonly SingletonLazy instance = new SingletonLazy();
            }
        }

        //6. Using .Net 4's Lazy<T> type
        //Explanation of the code:

        //1. If you're using .Net 4 (or higher) then you can use the System.Lazy<T> type to make the laziness really simple.
    }
}
