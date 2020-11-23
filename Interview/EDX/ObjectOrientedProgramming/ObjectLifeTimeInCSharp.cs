using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class ObjectLifeTimeInCSharp
    {
        /*
            Object Lifecycle
            The life cycle of an object has several stages, which start at creation of the object and end in its destruction. To create an object in your application,
            you use the new keyword. When the common language runtime (CLR) executes code to create a new object, it performs the following steps:
            
            1. It allocates a block of memory large enough to hold the object.
            2. It initializes the block of memory to the new object.
            
            The CLR handles the allocation of memory for all managed objects. However, when you use unmanaged objects, you may need to write code to allocate memory for
            the unmanaged objects that you create. Unmanaged objects are those that are not .NET components such as Microsoft Word object, a database connection, or a
            file resource.
            
            When you have finished with an object, you can dispose of it to release any resources, such as database connections and file handles, that it consumed.
            When you dispose of an object, the CLR uses a feature called the gargbage collector (GC) to perform the following steps:
            
            1. The GC releases resources.
            2. The memory that is allocated to the object is reclaimed.
            
            The GC runs automatically is a separate thread. When the GC runs, other threads in the application are halted, because the GC may move objects in memory
            and therefore must update the memory pointers.
        */
    }
}
