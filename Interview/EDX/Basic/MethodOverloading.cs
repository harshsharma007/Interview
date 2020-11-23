using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class MethodOverloading
    {
        /*
            When you define a method, you might realize that it requires different sets of information in different circumstances. You can define overload methods to
            create multiple methods with the same functionality that accept different parameters depending on the context in which they are called.
            
            Overload methods have the same name as each other to emphasize their common intent. However, each overload method must have a unique signature, to
            differentiate it from the other overload versions of the method in the class.
            
            The signature of a method includes its name and its parameter list. The return type is not part of the signature. Therefore, you cannot define overload
            methods that differ only in their return type. You can also not define overloaded methods that differ in position of the parameters.
            
            The following code example shows three versions of the StopService method, all with a unique signature.
            
            void StopService()
            {
                // This method accepts no arguments.
            }
            
            void StopService(string serviceName)
            {
                // This method overload accepts a single string argument.
            }
            
            void StopService(int serviceId)
            {
                // This method overload accepts a single integer argument.
            }
            
            When you invoke the StopService method, you have choice of which overloaded version you use. You simply provide the relevant arguments to satisfy a particular
            overload, and then the compiler works out which version to invoke based on the arguments that you passed.
        */
    }
}
