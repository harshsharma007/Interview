using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.GenericCollections
{
    class ConstrainingGenerics
    {
        /*
            Constraining Generics
            In some cases, you may need to restrict the types that developers can supply as arguments when they instantiate your generic class. The nature of these constraints will
            depend on the logic you implement in your generic class. For example, if a collection class uses a property named AverageRating to sort the items in a collection, you
            would need to constrain the type parameter to classes that include the AverageRating property. Suppose the AverageRating property is defined by the IBeverage interface.
            To implement this restriction, you would constrain the type parameter to classes that implement the IBeverage interface by using the where keyword.
            
            The following example shows how to constrain a type parameter to classes that implement a particular interface:
            
            // Constraining Type Parameters by Interface
            public class CustomList<T> where T : IBeverage
            {
            }
            
            You can apply the following six types of constraint to type parameters:
            
            +------------------------------------+----------------------------------------------------------------------------+
            |   where T : <name of interface>    |  The type argument must be, or implement, the specified interface.         |
            +------------------------------------+----------------------------------------------------------------------------+
            |   where T : <name of base class>   |  The type argument must be, or derive from, the specified class.           |
            +------------------------------------+----------------------------------------------------------------------------+
            |   where T : U                      |  The type argument must be, or derive from, the supplied type argument U   |
            +------------------------------------+----------------------------------------------------------------------------+
            |   where T : new()                  |  The type argument must have a public default constructor                  |
            +------------------------------------+----------------------------------------------------------------------------+
            |   where T : struct                 |  The type argument must be a value type                                    |
            +------------------------------------+----------------------------------------------------------------------------+
            |   where T : class                  |  The type argument must be a reference type                                |
            +------------------------------------+----------------------------------------------------------------------------+
            
            You can apply the following six types of constraint to type parameters:
            
            // Apply Multiple Type Constraints
            public class CustomList<T> where T : IBeverage, IComparable<T>, new()
            {
            }
        */
    }
}
