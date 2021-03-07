using System;

namespace Interview.DesignPatterns.Demo
{
    // Sealed restricts the inheritance.
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        // Public property is used to return only one instance of the class leveraging on the private property.
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        // Private constructor ensures that object is not instantiated other than with in the class itself.
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value {0}", counter);
        }

        // Public method which can be invoked through the singleton instance.
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainMethod
    {
        /*
            When you run the application you will see the counter value is only 1. Which was not the case with simple class initialization. In simple class initialization,
            the counter varaible was incremented to 2.
            
            This code works fine, in a situation when a single thread is trying to create an instance of this class. This version is not efficient enough to handle
            multiple threads as it will run into a race condition situation.
        */

        public MainMethod()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
