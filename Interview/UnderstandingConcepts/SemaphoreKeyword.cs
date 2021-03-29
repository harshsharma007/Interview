using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interview.UnderstandingConcepts
{
    class SemaphoreKeyword
    {
        public SemaphoreKeyword()
        {
            /*
                C# semaphore allows only a limited number of threads to enter into a critical section. Semaphore is mainly used in scenarios where we have limited number
                of resources and we have to limit the number of threads that can use it.
            
                How Semaphore Works
                Semaphores are Int32 variables stored in an operating system resources. When we initialize the semaphore object we initialize with number. This number 
                limits the threads that can enter into the critical section.
            
                When a thread enters into a critical section, it decreases the Int32 variable with 1 and when a thread exits from a critical section, it increases the
                Int32 variable with 1.
            
                When the Int32 variable is 0, no thread can enters into a critical section. Below is the syntax of C# semaphore initialization.
            */

            Semaphore semaphore = new Semaphore(initialCount: 0, maximumCount: 5);

            /*
                We initialize semaphore object with two parameters:
                1. InitialCount
                2. MaximumCount
                
                Maximum count defines how many maximum threads can enter into a critical section. InitialCount set the value of Int32 variable. For example, if we set
                the maximum count of 3 and initial count of 0. That means 3 threads are already in the critical section. If we set the maximum count of 3 and initial
                count of 3, that means maximum 3 threads can enter into a critical section and there is no threads currently in the critical section.
            */

            /*
                Used semaphore between multiple processes
                Alternatively, semaphore has another constructor which takes additional string as parameter. This string parameter is a unique string which is used for
                using semaphore between multiple process.
                
                Below is the syntax of creating semaphore.
            */

            Semaphore semaphoreObject = new Semaphore(initialCount: 0, maximumCount: 5, name: "MyUniqueNameApp");

            /*
                WaitOne Method
                Threads can enter into the critical section by using WaitOne method. They called the WaitOne method on semaphore object. If the Int32 variable
                maintained by semaphore is greater than 0 then it allows calling thread to enter.
                
                Below is the syntax of calling WaitOne method.
            */

            semaphoreObject.WaitOne();

            /*
                In another overload of semaphore WaitOne method, we can pass the time interval for which a thread can wait to get a signal from semaphore. If thread
                has not received signal within a time internal specified, it returns false value.
            */

            bool isSignalled = semaphoreObject.WaitOne(TimeSpan.FromSeconds(4));

            // In the above example, if calling thread does not receive signal within specified 4 seconds, then it returns false. If it receives signal it returns true.

            /*
                Release Method
                When a thread exits from the critical section, it must call the Release method to increment the counter maintained by semaphore object. It allows
                waiting threads to enter into a critical section.
            */

            semaphoreObject.Release();

            /*
                By default Release method only increment the counter by 1. That means only one thread exits from the critical section. We can also pass a parameter to
                Release method to defines how many threads are actually exits.
            */

            semaphoreObject.Release(3);

            /*
                In the above code, we pass 3 parameter to Release method. This will notify semaphore object that 3 threads are actually exits from the critical section.
                So semaphore object increment the counter by 3.
            */
        }

        public SemaphoreKeyword(int value)
        {
            /*
                Semaphore Example
                In the following example shows how to use semaphore object with Printer object. We have to limit the number of threads that can concurrently use
                Printer object. For that we use semaphore object with maximum count of 3.
            */

            Semaphore semaphoreObject = new Semaphore(initialCount: 3, maximumCount: 3, name: "PrinterApp");
            Printer printerObject = new Printer();

            for (int i = 0; i < 20; i++)
            {
                int j = 1;
                Task.Factory.StartNew(() =>
                {
                    semaphoreObject.WaitOne();
                    printerObject.Print(j);
                    semaphoreObject.Release();
                });
            }
            Console.ReadLine();

            /*
                We initialize semaphore object with 3 initialcount and maximum of 3 and gives unique name "PrinterApp". We start the for loop with runs from 0 to 20.
                We started threads using the TaskFactory.
                
                Each thread calls WaitOne method of semaphore object before using the Printer object. This will limit the number of threads using the Printer object.
                After using printer object each thread calls the Release method for increment the counter of semaphore. This allows further threads to enter into a
                critical section.
            */
        }
    }

    class Printer
    {
        public void Print(int documentToPrint)
        {
            Console.WriteLine("Printing document {0}", documentToPrint);
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
