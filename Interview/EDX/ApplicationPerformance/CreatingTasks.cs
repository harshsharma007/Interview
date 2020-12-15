using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ApplicationPerformance
{
    class CreatingTasks
    {
        /*
            Creating Tasks
            The Task class lies at the heart of the Task Parallel Library in the .NET Framework. As the name suggests, you use the Task class to represent a task, or in other words,
            a unit of work. The Task class enables you to perform mulitple tasks concurrently, each on a different thread. Behind the scenes, the Task Parallel Library manages the
            thread pool and assigns tasks to threads. You can implement sophisticated multitasking functionality by using the Task Parallel Library to chain tasks, pause tasks, wait
            for tasks to complete before continuing and perform many other operations.
            
            You create a new Task object by using the Task class. A Task object runs a block of code, and you specify this code as a parameter to the constructor. You can provide
            this code in a method and create an Action delegate that wraps this method.
            
            Note: A delegate provides a mechanism for referencing a block of code or a method. The Action class is a type in the .NET Framework Class Library that enables you to convert
            a method into a delegate. The method cannot return a value, but it can take parameters. The .NET Framework Class Library also provides the Func class, which enables you to
            define a delegate that can return a result.
            
            The following code example shows how to create a task by using an Action delegate:
            
            // Creating a Task by Using an Action Delegate
            Task task1 = new Task(new Action(GetTheTime));
            
            private static void GetTheTime()
            {
                Console.WriteLine("The time now is {0}", DateTime.Now);
            }
            
            Using an Action delegate requires that you have defined a method that contains the code that you want to run in a task. However, if the sole purpose of this method is to
            provide the logic for a task and it is not reused anywhere else, you can find yourself creating (and having to remember the names of) a substantial number of methods.
            This makes maintenance more difficult. A more common approach is to use an anonymous method. An anonymous method is a method without a name, and you provide the code for
            an anonymous method inline, at the point you need to use it. You can use the delegate keyword to convert an anonymous method into a delegate.
            
            The following code example shows how to create a task by using an anonymous delegate.
            
            // Creating a Task by using an Anonymous Delegate
            Task task2 = new Task(delegate { Console.WriteLine("The time now is {0}", DateTime.Now); });
            
            Using Lambda Expressions to Create Tasks
            A lambda expression is a shorthand syntax that provides a simple and concise way to define anonymous delegates. When you create a Task instance, you can use a lambda
            expression to define the delegate that you want to associate with your task.
            
            If you want your delegate to invoke a named method or a single line of code, you can use use a lambda expression. A lambda expression provides a shorthand notation for
            defining a delegate that can take parameters and return a result. It has the following form:
            
            (input parameters) => expression
            
            In this case:
            - The lambda operator => is read as "goes to".
            - The left side of the lambda operator includes any variables that you want to pass to the expression. If you do not require any inputs - for example, if you are invoking
              a method that takes no parameters - you include empty parentheses() on the left side of the lambda operator.
            
            The right side of the lambda operator includes the expression you want to evaluate. This could be a comparison of the input parameters - for example, the expression
            (x, y) => x == y will return true if x is equal to y; otherwise, it will return false. Alternatively, you can call a method on the right side of the lambda operator.
            
            The following code example shows how to use lambda expressions to represent a delegate that invokes a named method.
            
            // Using a Lambda Expression to Invoke a Named Method
            Task task1 = new Task( () => MyMethod() );
            // This is equivalent to: Task task1 = new Task( delegate(MyMethod) );
            
            A lambda expression can be a simple expression or function call, as the previous example shows, or it can reference a more substantial block of code. To do this, specify
            the code in curly braces (like the body of a method) on the right side of the lambda operator:
            
            (input parameters) => { Visual C# statements; }
            
            The following code example shows how to use lambda expressions to represent a delegate that invokes an anonymous method.
            
            // Using a Lambda Expression to Invoke an Anonymous Method
            Task task2 = new Task( () => { Console.WriteLine("Test") } );
            // This is equivalent to: Task task2 = new Task( delegate { Console.WriteLine("Test") } );
            
            As your delegates become more complex, lambda expressions offer a far more concise and easily understood way to express anonymous delegates and anonymous methods. As such, 
            lambda expressions are the recommended approach when you work with tasks.
        */
    }
}
