using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ApplicationPerformance
{
    class ImplementMultitasking
    {
        /*
            Multitasking
            A typical graphical application consists of blocks of code that run when an event occurs; these events fire in response to actions such as the user clicking a button,
            moving the mouse, or opening a window. By default, this code runs by using the UI thread. However, you should avoid executing long-running operations on this thread because
            they can cause the UI to become unresponsive. Also, running all of your code on a single thread does not make good use of available processing power in the computer;
            most modern machines contain multiple processor cores, and running all operations on a single thread will only use a single processor core.
            
            The Microsoft .NET Framework now includes the Task Parallel Library. This is a set of classes that makes it easy to distribute your code execution across multiple threads.
            You can run these threads on different processor cores and take advantage of the parallelism that this model provides. You can assign long-running tasks to a separate thread,
            leaving the UI thread free to respond to user actions.
            
            Prior to Windows Store applications, .NET developers made use of the System.Threading namespace and Thread class to execute multiple threads within an application. The
            Thread class is not available in Windows Store apps so you make use of the Task class instead. Creating a task in a Windows Store application will result in a thread being
            created for that task.
            
            When you use tasks rather than threads, the CLR can optimize the number of threads required for concurrent tasks and this helps your applications scale better than dealing
            with threads directly.
        */
    }
}
