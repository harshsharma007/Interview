using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Demo
{
    public sealed class ThreadSafetyInSingleton
    {
        private static int counter = 0;
        private static ThreadSafetyInSingleton instance = null;
        private static readonly object obj = new object();

        private ThreadSafetyInSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value {0}", counter);
        }

        public static ThreadSafetyInSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new ThreadSafetyInSingleton();
                    }
                }
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainThread
    {
        public MainThread()
        {
            Parallel.Invoke
            (
                () => PrintStudentDetails(),
                () => PrintEmployeeDetails()
            );
        }

        private static void PrintEmployeeDetails()
        {
            ThreadSafetyInSingleton fromEmployee = ThreadSafetyInSingleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void PrintStudentDetails()
        {
            ThreadSafetyInSingleton fromStudent = ThreadSafetyInSingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
