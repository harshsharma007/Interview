using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Common
{
    class ExtensionMethods
    {
        /*
            Extension methods allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface.
            Extension methods can be added to your own custom class, .Net framework classes or third party classes or interfaces.
            LINQ is built upon extension methods that operate on IEnumerable and IQueryable type.
            An extension method is actually a special kind of static method defined in a static class. To define an extension method, first of all, define a static class.
        */

        /*
            Benefits of an Extension methods
            Extension methods allow existing classes to be extended without relying on inheritance or having to change the class's source code. If the class is sealed
            then there is no concept of extending it's functionality. For this a new concept is introduced, in other words extension methods.
        */
    }

    /*
        A static class cannot have non-static properties/methods.
    */
    public static class IntExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool IsLessThan(this int i, int value)
        {
            return i < value;
        }
    }

    class IntTestExtension
    {
        void Test()
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            bool resultNew = i.IsLessThan(100);
        }
    }

    /*
        The only difference between a regular static method and an extension method is that the first parameter of the extension method specifies the type that it is
        going to operate on, preceded by the this keyword.

        Points to remember:
        1. Extension methods are additional custom methods which were originally not included with the class.
        2. Extension methods can be added to custom, .Net Framework or third party classes, structs or interfaces.
        3. The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the this keyword.
        4. Extension methods can be used anywhere in the application by including the namespace of the extension method.
    */
}
