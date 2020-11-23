using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class TheGarbageCollector
    {
        /*
            Introducing Garbage Collection
            The garbage collector is a separate process that runs in its own thread whenever a managed code application is running. The garbage collection process
            provides the following benefits:
            
            1. Enables you to develop your application without having to worry about freeing memory.
            2. Allocates objects on the managed heap efficiently.
            3. Reclaims objects that are no longer being used, clears their memory, and keeps the memory available for future allocations. Managed objects automatically
               get clean content to start with, so their constructors do not have to initialize every data field.
            4. Provides memory safety by making sure that an object cannot use the content of another object.
            
            When a .NET application is executed, the garbage collector is initialized by the CLR. The GC allocates a segment of memory that it will use to store and
            manage the objects for each .NET application that is running. This memory area is referred to as the managed heap, which differs from a native heap used in
            the context of the operating system.
            
            There is a managed heap for each managed process that is running and all threads in the process allocate memory for objects, in that process, on the same
            heap. This means that each process has its own virtual memory space.
            
            To reserve memory, the garbage collector calls the Win32 VirtualAlloc function, and reserves one segment of memory at a time for managed applications. The
            garbage collector also reserves segments as needed, and releases segments back to the operating system (after clearing them of any objects) by calling
            the Win32 VirtualFree function.
            
            Note: The size of segments allocated by the garbage collector is implementation-specific and is subject to change at any time, including in periodic updates.
            When writing your app, you should never make assumptions about, or depend on a particular segment size that will be used by the GC.
            
            When a garbage collection is triggered, the process will reclaim memory that is occupied by dead objects, objects are no longer referenced in the application
            code. Reclaiming also compacts live objects so that they are moved together, dead space is removed, which reduces the size of the heap.
            
            The GC does exact a performance hit on the application because garbage collection is the result of the number of allocations and the amount of memory
            usage and release on the managed heap.
            
            Garbage collection occurs when one of the following condition is true:
            1. The system is running low on physical memory.
            2. The memory that is used by currently allocated objects surpasses an acceptable threshold. This threshold will be continously adjusted as the process is
               running.
            3. The GC.Collect method is called. While you can call this method yourself, typically you do not have to call this method, because the garbage collector
               runs continously. Even if you do call this method, there is no guarantee that it will run precisely when you call it.
        */
    }
}
