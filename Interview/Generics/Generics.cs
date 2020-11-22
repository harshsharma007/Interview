using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Generics
{
    class Generics<T>
    {
        public T Data { get; set; }

        /*
            Generic means the general form, not specific. In C#, generic means not specific to a particular data type.
            
            C# allows you to define generic classes, interfaces, abstract classes, fields, methods, static methods, properties, events, delegates and operators using the type parameter
            and without the specific data type. A type parameter is a placeholder for a particular type specified when creating an instance of the generic type.
            
            A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.
        */
    }
    class DataStore<T>
    {
        public T Data { get; set; }
    }

    /*
        Generic Class
        Generic classes are defined using a type parameter in an angle brackets after the class name. The following defines a generic class.
        
        Above, the DataStore is a generic class. T is called type parameter, which can be used as a type of fields, properties, method parameters, return types, and delegates
        in the DataStore class. For example, Data is generic property because we have used a type parameter T as its type instead of the specific data type.

        Note:
        It is not required to use T as a type parameter. You can give any name to a type parameter. Generally, T is used when there is only one type parameter. It is recommended to
        use a more readable type parameter name as per requirement like TSession, TKey, TValue etc.

        You can also define multiple type parameters separated by comma.
    */

    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class Test
    {
        public Test()
        {
            /*
                Instantiating Generic Class
                You can create an instance of generic classes by specifying an actual type in angle brackets. The following creates an instance of the generic class DataStore.
            */

            DataStore<string> store = new DataStore<string>();

            /*
                Above, we specified the string type in the angle brackets while creating an instance. So, T will be replaced with a string type whatever T is used in the entire class
                at compile-time. Therefore, the type of Data property would be a string.
                
                You can assign a string value to the Data property. Trying to assign values other than string will result in a compile-time error.
            */

            DataStore<string> storeNew = new DataStore<string>();
            storeNew.Data = "Hello World!";
            // storeNew.Data = 123; // Compile-time error

            DataStore<int> storeInt = new DataStore<int>();
            storeInt.Data = 123;
            // storeInt.Data = "Hello World!"; // Compile-time error

            KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>();
            keyValuePair.Key = 100;
            keyValuePair.Value = "Hundred";

            KeyValuePair<string, string> keyValuePair1 = new KeyValuePair<string, string>();
            keyValuePair1.Key = "IT";
            keyValuePair1.Value = "Information Technology";
        }

        /*
            Generic Class Characteristics
            - A generic class increases the reusability. The more type parameters mean more reusable it becomes. However, too much generalization makes code difficult to understand
              and maintain.
            - A generic class can be a base class to other generic or non-generic classes or abstract classes.
            - A generic class can be derived from other generic or non-generic interfaces, classes or abstract classes.
        */
    }

    /*
        Generic Fields
        A generic class can include generic fields. However, it cannot be initialized.
    */

    class DataStoreFields<T>
    {
        public T data;
    }

    // The following declare a generic array
    class DataStoreArray<T>
    {
        public T[] data = new T[10];
    }

    /*
        Generic Methods
        A method declared with the type parameters for its return type or parameters is called a generic method.
    */

    class GenericMethods<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        /*
            The generic parameter type can be used with multiple parameters with or without non-generic parameters and return type. The followings are valid generic method overloading.
        */

        public void AddOrUpdate(T data1, T data2)
        {
            Console.WriteLine("{0} {1}", data1, data2);
        }

        public void AddOrUpdate(T data)
        {
            Console.WriteLine(data);
        }
    }

    /*
        Above, the AddOrUpdate() and the GetData() methods are generic methods. The actual data type of the item parameter will be specified at the time of instantiating the
        GenericMethods<T> class, as shown below:
    */

    class Main
    {
        public void MainMethod()
        {
            GenericMethods<string> cities = new GenericMethods<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            GenericMethods<int> empIds = new GenericMethods<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);
        }
    }

    /*
        A non-generic class can include generic methods by specifying a type parameter in angle brackets with the method name, as shown below
    */

    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }

    class PrinterCalling
    {
        public void Calling()
        {
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200);             // Type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!");        // Type infer from the specified value
        }
    }

    /*
        Advantages of Generics
        1. Generics increase the reusability of the code. You don't need to write the code to handle different data types.
        2. Generics are type-safe. You get compile-time errors if you try to use a different data type than the one specified in the definition.
        3. Generic has a performance advantage because it removes the possibilities of boxing and unboxing.
    */
}
