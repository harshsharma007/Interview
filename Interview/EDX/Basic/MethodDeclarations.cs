using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class MethodDeclarations
    {
        /*
            The ability to define and call methods is a fundamental component of object-oriented programming, because methods enable you to encapsulate operations that
            protect data that is stored inside a type.
            
            Typically, any application that you develop by using the Microsoft .NET Framework and Visual C# will have many methods, each with a specific purpose. Some
            methods are fundamental of the operation of an application. For example, all Visual C# desktop applications must have a method called Main that defines the
            entry point for the application. When the user runs a Visual C# application, the common language runtime (CLR) executes the Main method for that application.
            
            Methods can be designed for internal use by a type, and as such are hidden from other types. Public methods may be designed to enable other types to request
            that an object performs an action, and are exposed outside of the type. The .NET Framework itself is built from classes that expose methods that you can
            call from your applications to interact with the user and the computer.
            
            A method is declared using a method signature and method body. The signature portion is responsbile for providing the access modifier, method return type,
            the method name, and the list of parameters. The body contains the implementation for what the method is intended to do. Each method signature component
            is explained here:
            
            Access modifier - this is used to control the accessibility of the method (from where it can be called)
            1. private - most restrictive and allows access to the method only from within the containing class or struct.
            2. public - least restrictive, allowing access from any code in the application.
            3. protected - allows for access from within the containing class or from within derived classes.
            4. internal - accessible from files within the same assembly.
            5. static - indicates the method is a static member of the class rather than a member of an instance of a specific object.
            
            Return type - used to indicate what type the method will return. Use void if the method will not return a value or any supported data type.
            Method name - all methods need a name so you know what to call in code. Identifier rules apply to methods names as well.
            Parameter list - a comma separated list of parameters to accept arguments passed into the method.
            
            public bool StartService(string serviceName)
            {
                // Code to start the service.
            }
            
            In the preceding example, public is the access modifier, bool is the return type, StartService is the name, and string serviceName is the parameter list.
            Note that the parameter list specifies a data type and a name for the parameter.
        */
    }
}
