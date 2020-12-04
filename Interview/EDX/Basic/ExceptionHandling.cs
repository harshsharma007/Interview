using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class ExceptionHandling
    {
        /*
            Exception Handling
            Traditionally, applications used the concept of a global error object. When a piece of code caused an error, it would set the data in this object to indicate the cause of 
            the error and then return to the caller. It was the responsibility of the calling code to examine the error object and determine how to handle it. However, this approach is 
            not robust, because it is too easy for a programmer to forget to handle errors appropriately.
            
            The .NET Framework uses exceptions to help overcome these issues. An exception is an indication of an error or exceptional condition. A method can throw an exception when 
            it detects that something unexpected has happened, for example, the application tries to open a file that does not exist.
            
            Exception Propagation
            When a method throws an exception, the calling code must be prepared to detect and handle this exception. If the calling code does not detect the exception, the code is 
            aborted and the exception is automatically propagated to the code that invoked the calling code. This process continues until a section of code takes responsibility for 
            handling the exception. Execution continues in this section of code after the exception-handling logic has completed. If no code handles the exception, then the process will 
            terminate and display a message to the user.
            
            Handling Exceptions
            The try/catch block is the key programming construct that enables you to implement structured exception handling in your applications. You wrap code that may fail and cause 
            an exception in a try block, and add one or more catch blocks to handle any exceptions that may occur. The recommended strategy to follow with catch blocks is to catch more 
            specific exceptions first, and more general exceptions last. For example, if you expect to run across an exception around file access, you would catch the 
            FileNotFoundException in the first catch block and then perhaps create a second catch block that would watch for the generic Exception class to catch any other exception 
            besides the FileNotFoundException.
            
            If the FileNotFoundException is triggered, that catch block will have code to handle that exception. Otherwise, the other catch block(s) will contain code to handle other 
            exceptions, or to throw the exception back up the stack to the calling application.
            
            The following code example shows the syntax for defining a try/catch block.
            
            try
            {
                // Try block.
            }
            catch (FileNotFoundException ex)
            {
                // Catch block 1.
            }
            catch (Exception e)
            {
                // Catch block n.
            }
        */
    }
}
