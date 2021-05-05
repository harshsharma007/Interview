using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.AsyncAwaitThread
{
    class TaskParallelLibraryQuestions
    {
        /*
            Can an async method have a void as a return type?
            You use the void return type in asynchronous event handlers, which require a void return type. For methods other than event handlers that don't return a
            value, you should return a Task instead, because an async method that returns void can't be awaited. Any caller of such a method must continue to completion
            without waiting for the called async method to finish. The caller must be independent of any values or exceptions that the async method generates.
            
            The caller of a void-returning async method can't catch exceptions thrown from the method and such unhandled exceptions are likely to cause your application
            to fail. If a method that returns a Task or Task<TResult> throws an exception, the exception is stored in the returned task. The exception is rethrown when
            the task is awaited. Therefore, make sure that any async method that can produce an exception has a return type of Task or Task<TResult> and that calls to
            the method are awaited.
        */
    }
}
