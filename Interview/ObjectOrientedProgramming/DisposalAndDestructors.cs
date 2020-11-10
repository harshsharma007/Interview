using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.ObjectOrientedProgramming
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
        */
    }
}
