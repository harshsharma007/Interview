using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class DisposalAndDestructors
    {
        /*
            Implementing the Dispose Pattern
            The dispose pattern is a design pattern that frees resources that an object has used. The .NET Framework provides the IDisposable interface in the System
            namespace to enable you to implement the dispose pattern in your applications.
            
            The IDisposable interface defines a single parameterless method named Dispose. You should use the Dispose method to release all of the unmanaged resources
            that your object consumed. If the object is part of an inheritance hierarchy, the Dispose method can also release resources that the base types consumed by
            calling the Dispose method on the parent type.
            
            Invoking the Dispose method does not destroy an object. The object remains in memory until the final reference to the object is removed and the GC reclaims
            any remaining resources.
            
            Many of the classes in the .NET Framework that wrap unmanaged resources, such as the StreamWriter class, implement the IDisposable interface. The StreamWriter
            class implements a TextWriter object for the purpose of writing text information to a stream. The stream could be a file, memory, or network stream. You
            should also implement the IDisposable interface when you create your own classes that reference unmanaged types.
            
            Implementing the IDisposable Interface
            To implement the IDisposable interface in your application, perform the following steps:
            
            1. Ensure the System namespace is in scope by adding the following using statement to the top of the code file.
               using System;
            
            2. Implement the IDisposable interface in your class definition.
               ...
               public class ManagedWord : IDisposable
               {
                    public void Dispose()
                    {
                        throw new NotImplementedException();
                    }
               }
            
            3. Add a private field to the class, which you can use to track the disposal status of the object, and check whether the Dispose method has already been
               invoked and the resources released.
               
               public class ManagedWord : IDisposable
               {
                    bool _isDisposed;
                    ...
               }
            
            4. Add code to any public methods in your class to check whether the object has already been disposed of. If the object has been disposed of, you should
               throw an ObjectDisposedException.
               
               public void OpenWordDocument(string filePath)
               {
                    if (this._isDisposed)
                        throw new ObjectDisposedException("ManagedWord");
               }
            
            5. Add an overloaded implementation of the Dispose method that accepts a Boolean parameter. The overloaded Dispose method should dispose of both managed
               and unmanaged resources if it was called directly, in which case you pass a Boolean parameter with the value true. If you pass a Boolean parameter with
               the value of false, the Dispose method should only attempt to release unmanaged resources. You may want to do this if the object has already been disposed
               of or is about to be disposed of by the GC.
               
               public class ManagedWord : IDisposable
               {
                    ...
                    protected virtual void Dispose(bool isDisposing)
                    {
                        if (this._isDisposed)
                            return;
                        
                        if (isDisposing)
                        {
                            // Release only managed resources.
                        }
                        
                        // Always release unmanaged resources
                        ...
                        
                        // Indicate that the object has been disposed.
                        this._isDisposed = true;
                    }
               }
            
            6. Add code to the parameterless Dispose method to invoke the overloaded Dispose method and then call the GC.SuppressFinalize method. The GC.SuppressFinalize
               method instructs the GC that the resources that the object referenced have already been released and the GC does not need to waste time running the
               finalization code.
               
               public void Dispose()
               {
                    Dispose(true);
                    GC.SuppressFinalize(this);
               }
               
               After you have implemented the IDisposable interface in your class definitions, you can then invoke the Dispose method on your object to release any
               resources that the object has consumed. You can invoke the Dispose method from a destructor that is defined in the class.
            
            Implementing a Destructor
            You can add a destructor to a class to perform any additional application-specific cleanup that is necessary when your class is garbage collected. To define
            a destructor, you add a tilde (~) followed by the name of the class. You then enclose the destructor logic in braces.
            
            The following code example shows the syntax for adding a destructor.
            
            // Defining a Destructor
            class ManagedWord
            {
                ...
                // Destructor
                ~ManagedWord
                {
                    // Destructor Logic.
                }
            }
            
            When you declare a destructor, the compiler automatically converts it to an override of the Finalize method of the object class. However, you cannot explicitly
            override the Finalize method; you must declare a destructor and the let compiler perform the conversion.
            
            If you want to guarantee that the Dispose method is always invoked, you can include it as part of the finalization process that the GC performs. To do this,
            you can add a call to the Dispose method in the destructor of the class.
            
            The following code example shows how to invoke the Dispose method from a destructor.
            
            // Calling the Dispose Method from a Destructor
            class ManagedWord
            {
                ...
                // Destructor
                ~ManagedWord
                {
                    Dispose(false);
                }
            }
            
            Managing the Lifetime of an Object
            Using types that implement the IDisposable interface is not sufficient to manage resources. You must also remember to invoke the Dispose method in your
            code when you have finished with the object. If you choose not to implement a destructor that invokes the Dispose method when the GC processes the object,
            you can do this in a number of other ways.
            
            One approach is to explicitly invoke the Dispose method after any other code that uses the object. The following code example shows how you can invoke the
            Dispose method on an object that implements the IDisposable interface.
            
            // Invoking the Dispose Method
            var word = new ManagedWord();
            // Code to use the ManagedWord object
            word.Dispose();
            
            Invoking the Dispose method explicitly after code that uses the object is perfectly acceptable, but if your code throws an exception before the call to the
            Dispose method, the Dispose method will never be invoked. A more reliable approach is to invoke the Dispose method in the finally block of a try/catch/finally
            or a try/finally statement. Any code in the scope of the finally block will always execute, regardless of any exceptions that might be thrown. Therefore,
            with this approach, you can always guarantee that you code will invoke the Dispose method.
            
            The following code example shows how you can invoke the Dispose method in a finally block.
            
            // Invoking the Dispose Method in a finally Block
            var word = default(ManagedWord);
            try
            {
                word = new ManagedWord();
                // Code to use the ManagedWord object.
            }
            catch
            {
                // Code to handle any errors.
            }
            finally
            {
                if (word != null)
                    word.Dispose();
            }
            
            Note: When explicitly invoking the Dispose method, it is good practice to check whether the object is not null beforehand, because you cannot guarantee the
            state of the object.
            
            Alternatively, you can use a using statement to implicitly invoke the Dispose method. A using block is exception safe, which means that if the code in the
            block throws an exception, the runtime will still dispose of the objects that are specified in the using statement.
            
            The following code example shows how to implicitly dispose of your object by using a using statement.
            
            // Disposing of an Object by Using a using statement
            using (var word = default(ManagedWord))
            {
                // Code to use the ManagedWord object.
            }
            
            If your object does not implement the IDisposable interface, a try/finally block is an exception-safe approach to execute code to release resources. You
            should aim to use a try/finally block when it is not possible to use a using statement.
        */
    }
}
