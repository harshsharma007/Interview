using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns
{
    class SingletonDesignPattern
    {
        //What is Singleton Design Pattern?
        //The singleton pattern is one of the best-known patterns in software engineering. Essentially, a singleton is a class which only allows a single instance of
        //itself to be created, and usually gives simple access to that instance. Most commonly, singletons don't allow parameters to be specified when creating the
        //instance - as otherwise a second request for an instance but with a different parameter could be problematic! (If the same instance should be accessed for
        //all requests with the same parameter, the factory pattern is more appropriate.) This article deals only with the situation where no parameters are required.
        //Typically, a requirement of singletons is that they are created lazily i.e. that the instance isn't created until it is first needed.

        //There are various ways to implement Singleton Pattern in C#. I shall present them here in reverse order of elegance, starting with the most commonly seen,
        //which is not thread safe, and working up to a fully lazily-loaded, thread-safe, simple and highly performant version.

        //All these implementations share four common characteristics, however:

        //1. A single constructor that is private and parameterless. This prevents other classes from instantiating it (which would be a violation of the pattern).
        //Note that it also prevents subclassing - if a singleton can be subclassed once, it can be subclassed twice, and if each of those subclasses can create an
        //instance, the pattern is violated. The factory pattern can be used if you need a single instance of a base type, but the exact type isn't known until runtime.
        //2. The class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimize things more.
        //3. A static variable which holds a reference to the single created instance, if any.
        //4. A public static means of getting the reference to the single created instance, creating one if necessary.

        //Note that all of these implementations also use a public static property Instance as the means of accessing the instance. In all cases, the property could
        //easily be converted to a method, with no impact on thread-safety or performance.

        //Advantages of Singleton Pattern are:

        //Disadvantages of Singleton Pattern are:

        //Singleton class vs Static methods

        //How to implement Singleton Pattern in your code. (There are many ways to implement a Singleton Pattern in C#)
        //1. No Thread Safe Singleton.
        //2. Thread-Safety Singleton.
        //3. Thread-Safety Singleton using Double-Check Locking.
        //4. Thread-Safety Singleton without using locks and no lazy instantiation.
        //5. Full Lazy instantiation.
        //6. Using .Net 4's Lazy<T> type.

        //1. No Thread Safe Singleton
        //Explanation of the following code:

        //1. As stated before, the following code is not thread-safe. Two different threads could both have evaluated the test (if instance == null) and found it to be
        //true, the both creates instances, which violates the singleton pattern. Note that in fact the instance may already have been created before the expression is
        //evaluated, but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed.

        //Bad Code
        public sealed class SingletonNotThreadSafe
        {
            //Why we create a private constructor in a singleton class? Or Role of a private constructor in a singleton class.
            //A Singleton class is one which limits the number of objects creation to one. Using Private Constructor we can ensure that no more than one object can
            //be created at a time. By providing a private constructor you can prevent class instances from being created in any place other than this very class.
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

        //1. This implementation is thread-safe. The thread takes out a lock on a shared object, and then checks whether or not the instance has been created before
        //creating the instance. This takes care of the memory barrier issue (as locking makes sure that all reads occur logically after the lock acquire, and unlocking
        //makes sure that all writes occur logically before the lock release) and ensures that only one thread will create an instance (as only one thread can be in
        //that part of the code at a time - by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate
        //to false). Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
        
        //2. Note that instead of locking on typeof(Singleton) as some versions of this implementation do, I lock on the value of a static variable which is private to
        //the class. Locking on objects which other classes can access and lock on (such as the type) risks performance issues and even deadlocks. This is a general
        //style preference of mine - wherever possible, only lock on objects specifically created for the purpose of locking, or which document that they are to be
        //locked on for specific purposes (e.g. for waiting/pulsing a queue). Usually such objects should be private to the class they are used in. This helps to make
        //writing thread-safe applications significantly easier.

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

        //This implementation attempts to be thread-safe without the necessity of taking out a lock every time. Unfortunately, there are four downsides to the pattern:
        //1. It doesn't work in Java. This may seem an odd thing to comment on, but it's worth knowing if you ever need the singleton pattern in Java and C#
        //programmers may well also be Java programmers. The Java memory model doesn't ensure that the constructor completes before the reference to the new object
        //is assigned to instance. The Java memory model underwent a reworking for version 1.5, but double-check lock is still broken after this without a volatile
        //variable (as in C#).
        //2. Without any memory barriers, it's broken in the ECMA CLI specification too. It's possible that under the .Net 2.0 memory model (which is stronger than the
        //ECMA spec) it's safe, but I'd rather not rely on those stronger semantics, especially if there's any doubt as to the safety. Making the instance variable
        //volatile can make it work, as would explicit memory barrier calls, although in the latter case even experts can't agree exactly which barriers are required.
        //I tend to try to avoid situations where experts don't agree what's right and what's wrong!
        //3. It's easy to get wrong. The pattern needs to be pretty much exactly as above - any significant changes are likely to impact either performance or
        //correctness.
        //4. It still doesn't perform as well as the later implementations.

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
        //2. All you need to do is pass a delegate to the constructor that calls the Singleton constructor, which is done most easily with a lambda expression.
        //3. It also allows you to check whether or not the instance has been created with the IsValueCreated property.

        public sealed class SingletonLazyType
        {
            SingletonLazyType()
            {

            }

            private static readonly Lazy<SingletonLazyType> lazy = new Lazy<SingletonLazyType>(() => new SingletonLazyType());

            public static SingletonLazyType Instance
            {
                get
                {
                    return lazy.Value;
                }
            }
        }

        //The final example
        public sealed class Calculate
        {
            Calculate()
            {

            }

            private static Calculate instance = null;
            public static Calculate Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Calculate();
                    }
                    return instance;
                }
            }

            public double ValueOne { get; set; }
            public double ValueTwo { get; set; }

            public double Addition()
            {
                return ValueOne + ValueTwo;
            }

            public double Subtraction()
            {
                return ValueOne - ValueTwo;
            }

            public double Multiplication()
            {
                return ValueOne * ValueTwo;
            }

            public double Division()
            {
                return ValueOne / ValueTwo;
            }
        }

        public class SealedExample
        {
            public void Main()
            {
                Calculate.Instance.ValueOne = 10.5;
                Calculate.Instance.ValueTwo = 5.5;

                Console.WriteLine("Addition: " + Calculate.Instance.Addition());
                Console.WriteLine("Subtraction: " + Calculate.Instance.Subtraction());
                Console.WriteLine("Multiplication: " + Calculate.Instance.Multiplication());
                Console.WriteLine("Division: " + Calculate.Instance.Division());
                Console.ReadLine();
            }
        }
    }
}
