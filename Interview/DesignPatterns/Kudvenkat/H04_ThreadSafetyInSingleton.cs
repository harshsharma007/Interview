using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Kudvenkat
{
    class H04_ThreadSafetyInSingleton
    {
        /*
            The primary responsibility of the GetInstance property is to create singleton instance. However, we are delaying the singleton instance creation till the
            GetInstance property is invoked. This delayed instance creation is called Lazy Initialization. Lazy initialization works fine in single threaded
            environment. You may be wondering why this code works only in single threaded environment.
            
            To answer that imagine a situation where multiple threads are invoking get instance property at the same point of time. When that situation occurs there
            is a chance that we can create multiple instances of the singleton object.
            
            In our previous example, we are invoking the GetInstance property in a sequential manner or in a single-threaded manner, which means employee invokes our
            GetInstance property once the students gets invoked code is completed. Now let's see how can we invoke the GetInstance property in parallel. For our
            convenience, let's move the code related to employee and student into two separate methods.
            
            After creating two separate methods, let's invoke them using Parallel.Invoke method of .NET Framework 4.0. Parallel.Invoke invokes the method as actions,
            we have to pass the methods in Invoke() method as a lambda expression. After this code, counter value would be incremented to 2. That means the private
            constructor has been invoked twice. It proves that in a multi-threaded environment when both employee and student are invoking the GetInstance property
            in parallel we are ending up creating two instances of singleton object and this violates the singleton design pattern principles.
            
            To avoid the situation, locks are the best way to control thread race condition and they help us to overcome the present situation. After implementing lock,
            only one thread can enter into this code block at a given point of time. That means when both employee and student are racing with each other in
            multi-threaded environment, lock ensures that only one thread which arrives earlier succeeds to enter this code block and the other will wait till the first
            one is completed.
            
            However, locks are very expensive to use and there is no need to use the locks every time when we invoke the GetInstance property. So, how do we avoid the
            unnecessary lock checking? Bascially, we need the runtime to enter into the lock scope only when the instance is null. So, we just need to add another
            null check before the lock check. This double verification of null instance checking is called Double Check Locking.
        */
    }
}
