using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ApplicationPerformance
{
    class ControllingTaskExecution
    {
        /*
            Controlling Task Execution
            The Task Parallel Library offers several different approaches that you can use to start tasks. There are also various different ways in which you can pause the execution
            of your code until one or more tasks have completed.
            
            Starting Tasks
            When your code starts a task, the Task Parallel Library assigns a thread to your task and starts running that task. The task runs on a separate thread, so your code does not
            need to wait for the task to complete. Instead, the task and the code that invoked the task continue to run in parallel.
            
            If you want to queue the task immediately, you use the Start method.
            
            // Using the Task.Start Method to Queue a Task
            var task1 = new Task( () => Console.WriteLine("Task 1 has completed.") );
            task1.Start();
            
            Alternatively, you can use the static TaskFactory class to create and queue a task with a single line of code. The TaskFactory class is exposed through the static Factory
            property of the Task class.
            
            // Using the TaskFactory.StartNew Method to Queue a Task
            var task3 = Task.Factory.StartNew( () => Console.WriteLine("Task 3 has completed.") );
            
            The Task.Factory.StartNew method is highly configurable and accepts a wide range of parameters. If you simply want to queue some code with the default scheduling options,
            you can use the static Task.Run method as a shortcut for the Task.Factory.StartNew method.
            
            // Using the Task.Run Method to Queue a Task
            var task4 = Task.Run( () => Console.WriteLine("Task 4 has completed. ") );
        */
    }
}
