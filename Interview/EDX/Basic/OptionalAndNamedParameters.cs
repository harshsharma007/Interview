using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class OptionalAndNamedParameters
    {
        /*
            Optional Parameters
            A key feature of Visual C# is the ability to interoperate with applications and components that are written by using other technologies. One of the principal
            technologies that Windows uses is the Component Object Model (COM). COM does not support overloaded methods, but instead uses methods that can take
            optional parameters. To make it easier to incorporate COM libraries and components into a Visual C# solution, Visual C# also supports optional parameters.

            Optional parameters are also useful in other situations. They provide a compact and simple solution when it is not possible to use overloading because the
            the types of the parameters do not vary sufficiently to enable the compiler to distinguish between implementations. When defining methods that will use
            optional parameters, it's important to note that you must specify all non-optional parameters first, and then list the optional parameters.

            The following code example shows how to define a method that accepts one mandatory parameter (forceStop) and two optional parameters (serviceName, serviceID).
            Note that the mechanism used to denote an optional parameter is the inclusion if a default value.

            void StopService(bool forceStop, string serviceName = null, int serviceID = null)
            {
                // Code here that will stop the service
            }

            You can call a method that takes optional parameters in the same way that you call any other method. You specify the method name and provide any necessary
            arguments. The difference with methods that take optional parameters is that you can omit the corresponding arguments, and the method will use the default
            value when the method runs.

            Named Parameters
            Traditionally, when calling a method, the order and position of arguments in the method call corresponds to the order of parameters in the method signature.
            If the arguments are misaligned and the types mismatched, you receive a compile error.

            In Visual C#, you can specify parameter by name, and therefore supply arguments in a sequence that differs from that defined in the method signature. To use
            named arguments, you supply tha parameter name and corresponding value separated by a colon.
            
            The following code example shows how to invoke the StopService method by using named arguments to pass the serviceID parameter.

            StopService(true, serviceID: 1);

            When using named arguments in conjuction with optional parameters, you can easily omit parameters. Any optional parameters will receive their default value.
            However, if you omit any mandatory parameters, your code will not compile.

            You can mix positional and named arguments. However, you must specify all positional arguments before any named arguments.
        */
    }
}
