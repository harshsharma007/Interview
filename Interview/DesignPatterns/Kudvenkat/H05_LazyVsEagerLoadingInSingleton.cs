using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Kudvenkat
{
    class H05_LazyVsEagerLoadingInSingleton
    {
        /*
            In the previous session, we have discussed about the thread safety issues that may occur with the lazy initialization. We have also discussed how to overcome
            them by adding double check locking mechanism in the GetInstance property. After these changes we have created a new thread safe lazy initialization from
            our base singleton version. Basically, the lazy initialization of an object improves the performance and avoid necessary computation till the point the
            object is accessed.
            
            Lazy Loading
            - Improves the performance
            - Avoids unnecessary load till the point object is accessed
            - Reduces the memory footprint on the start-up
            - Faster application load
            
            Non-Lazy or Eager Loading
            - Pre-Instantiation of the object
            - Commonly used in lower memory footprints
            
            Further, it also reduces the memory footprint during the startup of the program. Reducing the memory footprint will help the application to load faster.
            Now, you may be wondering why and when to use the lazy initialization?
            
            Let's assume a situation where we need to assign some static properties in the singleton class and those properties need to be retrieved from the database.
            In those situations, we tend to use Lazy Initialization as we do not need to retrieve these values till the singleton object is accessed. That means, using
            Lazy Initialization depends on how heavy is the singleton instantiation and what are the dependent properties or methods that need to be loaded or assigned
            along with the singleton instantiation.
            
            What if, I don't need to use the lazy initialization?
            Depending on the situation, we can enhance the current version of the singleton pattern to a non-lazy loading pattern or to simplify Eager Loading pattern.
            Eager Loading is to initialize the required object before it's being accessed, which means we instantiate the object and keep it ready and use it when we
            need it. Let's see how can we do that?
            
            In order to achieve Eager Loading, we need to follow below steps:
            - We need to change the null initialization to new Singleton instance.
            - We need to change the instance property to readonly.
            - We need to remove the lock chek also, as it is no longer required.
            
            When we run the code below, the runtime will hit the GetInstance property twice due to parallel invoke. But, if you observe the output the counter value
            is still at 1. This proves that Eager Loading has created only one singleton instance.
            
            But you can think of, is this code thread safe?
            To answer that, the Common Language Runtime takes care of the variable initialization and it's thread safety. Hence we don't need to write any explicit
            code for thread safety.
        */
    }
}
