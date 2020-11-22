using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interview.Generics
{
    class GenericConstraints<T> where T : class
    {
        /*
            C# allows you to use constraints to restrict client code to specify certain types while instantiating generic types. It will give a compile-time error if you try to
            instantiate a generic type using a type that is not allowed by the specified constraints.
            
            You can specify one or more constraints on the generic type using the where clause after the generic type name.
            
            GenericTypeName<T> where T : constraint1, constraint2
        */

        public T Data { get; set; }
    }

    /*
        Above, we applied the class constraint, which means only a reference type can be passed as an argument while creating the GenericConstraints class object. So, you can pass
        reference types such as class, interface, delegate or array type. Passing value types will give a compile-time error, so we cannot pass primitive data types or struct types.
    */

    class GenericClass
    {
        public void GenericMethod()
        {
            GenericConstraints<string> genericConstraints = new GenericConstraints<string>();   // valid
            GenericConstraints<Main> genericMain = new GenericConstraints<Main>();              // valid
            GenericConstraints<ArrayList> genericList = new GenericConstraints<ArrayList>();    // valid
            // GenericConstraints<int> genericInt = new GenericConstraints<int>();              // Invalid
        }
    }

    /*
        The following table lists the types of generic constraints
        
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   class                           |   The type argument must be any class, interface, delegate, or array type.                                                         |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   class?                          |   The type argument must be a nullable or non-nullable class, interface, delegate or array type.                                   |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   struct                          |   The type argument must be non-nullable value types such as primitive data types int, char, bool, float etc.                      |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   new()                           |   The type argument must be a reference type which has a public parameterless constructor. It cannot be combined with struct and   |
        |                                   |   unmanaged constraints.                                                                                                           |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   notnull                         |   Available C# 8.0 onwards. The type argument can be non-nullable reference types or value types. If not, then the compiler        |
        |                                   |   generates a warning instead of an error.                                                                                         |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   unmanaged                       |   The type argument must be non-nullable unmanaged types.                                                                          |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   base class name                 |   The type argument must be or derive from the specified base class. The Object, Array, ValueType classes are disallowed as a base |
        |                                   |   class constraint. The Enum, Delegate, MulticastDelegate are disallowed as base class constraint before C# 7.3.                   |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   <base class name>?              |   The type argument must be or derive from the specified nullable or non-nullable base class.                                      |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   <interface name>                |   The type argument must be or implement the specified interface.                                                                  |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   <interface name>?               |   The type argument must be or implement the specified interface. It may be a nullable reference type, a non-nullable reference    |
        |                                   |   type or a value type.                                                                                                            |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
        |   where T : U                     |   The type argument supplied for T must be or derive from the argument supplied for U.                                             |
        +-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------+
    */

    /*
        where T : struct
        The following example demonstrates the struct constraint that restricts type argument to be non-nullable value type only.
    */

    class DataStruct<T> where T : struct
    {
        public T Data { get; set; }
    }

    public class StructClass
    {
        public StructClass()
        {
            DataStruct<int> dataStruct = new DataStruct<int>();     // valid
            DataStruct<char> dataChar = new DataStruct<char>();     // valid
            // DataStruct<string> dataString = new DataStruct<string>();         // Invalid
            // DataStruct<ArrayList> dataString = new DataStruct<ArrayList>();   // Invalid
        }
    }

    /*
        where T : new()
        The following example demonstrates the struct constraint that restricts type argument to be non-nullable value type only.
    */

    class DataNew<T> where T : class, new()
    {
        public T Data { get; set; }
    }

    public class StructNew
    {
        public void Struct()
        {
            DataNew<Main> dataNew = new DataNew<Main>();
            DataNew<ArrayList> dataList = new DataNew<ArrayList>();
            // DataNew<string> data = new DataNew<string>();    // Compile-time error
            // DataNew<int> data = new DataNew<int>();          // Compile-time error
        }
    }

    /*
        where T : baseclass
        The following example demonstrates the base class constraint that restricts type argument to be a derived class of the specified class, abstract class, or an interface.
    */

    class DataBase<T> where T : IEnumerable
    {
        public T Data { get; set; }
    }

    public class BaseClass
    {
        public void Base()
        {
            DataBase<ArrayList> dataBase = new DataBase<ArrayList>();   // valid
            // DataBase<string> dataString = new DataBase<string>();    // Compile-time error
            // DataBase<int> dataInt = new DataBase<int>();             // Compile-time error
        }
    }
}
