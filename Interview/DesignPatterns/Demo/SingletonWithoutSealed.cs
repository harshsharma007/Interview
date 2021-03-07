using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Demo
{
    class SingletonWithoutSealed
    {
        public static int counter = 0;
        public static SingletonWithoutSealed instance = null;

        private SingletonWithoutSealed()
        {
            counter++;
            Console.WriteLine("Counter value {0}", counter);
        }

        public static SingletonWithoutSealed GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonWithoutSealed();
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public class DerivedSingleton : SingletonWithoutSealed
        {

        }
    }

    public class MainSingleton
    {
        public MainSingleton()
        {
            SingletonWithoutSealed singletonWithoutSealed = SingletonWithoutSealed.GetInstance;
            singletonWithoutSealed.PrintDetails("Singleton Without Sealed");

            SingletonWithoutSealed singletonWithoutSealedNew = SingletonWithoutSealed.GetInstance;
            singletonWithoutSealedNew.PrintDetails("Singleton Without Sealed New");

            SingletonWithoutSealed.DerivedSingleton derivedSingleton = new SingletonWithoutSealed.DerivedSingleton();
            derivedSingleton.PrintDetails("Counter will be incremented to 2");
        }
    }
}
