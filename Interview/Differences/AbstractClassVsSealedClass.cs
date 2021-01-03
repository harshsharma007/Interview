using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Differences
{
    class AbstractClassVsSealedClass
    {
        /*
            What are the differences between an abstract class and a sealed class in C#?
            
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |                   Abstract Class                               |                          Sealed Class                          |
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |   A class that contains one or more abstract methods is        |  A class from which it is not possible to derive a new class   |
            |   known as an abstract class.                                  |  is known as a sealed class.                                   |
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |   The abstract class can contain abstract and non-abstract     |  A sealed class can contain non-abstract methods; it cannot    |
            |   methods.                                                     |  contain abstract and virtual methods.                         |
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |   Creating a new class from an abstract class is compulsory    |  It is not possible to create a new class from a sealed class. |
            |   to consume it.                                               |                                                                |
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |   An abstract class cannot be instantiated directly; we need   |  We should create an object for the sealed class to consume    |
            |   to create the object for its child classes to consume an     |  its members.                                                  |
            |   abstract class.                                              |                                                                |
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |   We need to use the keyword abstract to make any class as     |  We need to use the keyword sealed to make any class as sealed.|
            |   abstract.                                                    |                                                                |
            +----------------------------------------------------------------+----------------------------------------------------------------+
            |   An abstract class cannot be the bottom-most class within     |  The sealed class should be the bottommost class within the    |
            |   the inheritance hierarchy.                                   |  inheritance hierarchy.                                        |
            +----------------------------------------------------------------+----------------------------------------------------------------+
        */
    }
}
