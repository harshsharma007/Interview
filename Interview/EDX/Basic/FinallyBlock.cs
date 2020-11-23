using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class FinallyBlock
    {
        /*
            Some methods may contain critical code that must always be run, even if an unhandled exception occurs. For example, a method may need to ensure that it
            closes a file that it was writing to or releases some other resources before it terminates. A finally block enables you to handle this situation.
            
            You specify a finally block after any catch handlers in a try/catch block. It specifies code that must be performed when the block finishes, irrespective
            of whether any exceptions, handled or unhandled, occur. If an exception is caught and handled, the exception handler in the catch block will run before the
            finally block.
            
            You can also add a finally block to code that has no catch blocks. In this case, all exceptions are unhandled, but the finally block will always run.
            The following code example shows how to implement a try/catch/finally block.
            
            try
            {
                // Try block
            }
            catch (NullReferenceException ex)
            {
                // Catch all NullReferenceException exceptions.
            }
            catch (Exception e)
            {
                // Catch all other exceptions.
            }
            finally
            {
                // Code that always runs to close files or release resources.
            }
            
            Throwing Exceptions
            You can create an instance of an exception class in your code and throw the exception to indicate that an exception has occurred. When you throw an exception,
            execution of the current block of code terminates and the CLR passes control to the first available exception handler that catches the exception.
            
            To throw an exception, you use the throw keyword and specify the exception object to throw. The following code example shows how to create an instance
            of the NullReferenceException class and then throw the ex object.
            
            var ex = new NullReferenceException("The 'Name' parameter is null.");
            throw ex;
            
            A common strategy is for a method or block of code to catch any exceptions and attempt to handle them. If the catch block for an exception cannot resolve
            the error, it can rethrow the exception to propogate it to the caller.
            
            The following code example shows how to rethrow an exception that has been caught in a catch block.
            
            try
            {
                // Try block.
            }
            catch (NullReferenceException ex)
            {
                // Catch all NullReferenceException exceptions.
            }
            catch (Exception ex)
            {
                // Attempt to handle the exception
                // If this catch handler cannot resolve the exception, throw it to the calling code.
                throw;
            }
        */
    }
}
