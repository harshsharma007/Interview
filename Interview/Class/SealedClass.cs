using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Class
{
    class SealedClass
    {
        /*
            Q. What is a Sealed Class?
            A sealed class is a class that cannot be inherited from. That means if we have a class called Customer that is marked as sealed. No other class can inherit from the
            Customer class.
            
            Q. Can a sealed class be used as a base class?
            No, the sealed class cannot be used as a base class. A compile-time error will be generated.
            
            Q. When should a method be declared as sealed in C#?
            If we don't want to allow subclasses to override the superclass method and to ensure that all sub-classes use the same superclass method logic then that method should be
            declared as sealed. The sealed method cannot be overriden in sub-classes violation leads to a compile-time error.
            
            Q. What is the difference between private and sealed method in C#?
            The private method is not inherited whereas the sealed method is inherited but cannot be overridden. So private method cannot be called from sub-classes whereas the sealed
            method can be called from sub-classes. The same private method can be defined in sub-class and it does not lead to compile-time error.
            
            Q. When should a class be declared as sealed?
            In the below situations we must define the class as sealed
                - If we don't want to override all the methods of our class in sub-classes.
                - If we don't want to extend our class functionality.
        */
    }
}
