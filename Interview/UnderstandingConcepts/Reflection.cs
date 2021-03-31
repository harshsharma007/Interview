using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.UnderstandingConcepts
{
    class Reflection
    {
        /*
            Reflection is the ability of inspecting an assemblies' metadata at runtime. It is used to find all types in an assembly and/or dynamically invoke methods
            in an assembly.
            
            Uses of reflection:
            1. When you drag and drop a button or a win forms or an asp.net application. The properties window uses reflection to show all the properties of the Button
            class. So, reflection is extensively used by IDE or a UI designers.
            
            2. Late binding can be achieved by using reflection. You can use reflection to dynamically create an instance of a type, about which we don't have any
            information at compile time. So, reflection enables you to use code that is not available at compile time.
            
            3. Consider an example where we have two alternate implementations of an interface. You want to allow the user to pick one or the other using a config file.
            With reflection, you can simply read the name of the class whose implementation you want to use from the config file, and instantiate an instance of that
            class. This is another example for late binding using reflection.
        */
    }
}
