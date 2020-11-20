using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    interface IPen
    {
        /*
            We cannot create a constructor inside an interface. If you want to create a constructor then create an abstract class. Example is already given. You cannot use any access 
            modifier for any member of an interface. All the members by default are public members. If you use an access modifier in an interface then the C# compiler will give a 
            compile-time error.
        */

        //Error: The modifier 'public/private/protected' is not valid for this item.
        string Color { get; set; }
        bool Open();
        bool Close();
        void Write(string Text);
    }

    interface IPod : IPen
    {
        /*
            C# allows the inheritance of one interface to another interface. A class which is implementing the child interface must provide the definition of each and every signature 
            which is defined within the interface inheritance chain.
        
            Apart from that, an interface can be defined with an empty body. If the interface which is inheriting the parent interface has defined the method, property with the same name, 
            then the signature will hide the member of an inherited interface. In this case use of 'new' keyword is recommended.
        */
        new int Write(string Text);
    }

    interface IPad
    {

    }

    class LearnInterface : IPen, IPad //Only a class can implement multiple interface. Only through this, multiple inheritance can be achieved.
    {
        public string Color { get; set; }

        public bool Open()
        {
            return true;
        }

        public bool Close()
        {
            return false;
        }

        /*
            If you try to decorate a method other than public, then also the compiler will throw a compile-time error. So, only public keyword can be used.
        */
        public void Write(string Text)
        {
            /*
                Tag - Harsh
                Why are explicit members (very) private?
            */
            NewLearnInterface obj = new NewLearnInterface();
            (obj as IPen).Write("Test");
            (obj as IPod).Write("Test");

            //obj.Write("Test"); -> Error, because which one to call?
            obj.Open();
            obj.Close();
        }
    }

    class NewLearnInterface : IPen, IPod
    {
        public string Color { get; set; }

        public bool Open()
        {
            return true;
        }

        public bool Close()
        {
            return false;
        }

        /*
            Welcome to the concept of explicit implementation of an interface.
            When using explicit implementation of an interface, the members are forced to something more restricted than private in the class itself.
            And when the access modifier is forced, you may not add one.
            Likewise, in the interface itself, all members are public. If you try to add a modifier inside an interface you will get a similar error.
            Error: The modifier public is not valid for this item.
            Go to Tag - Harsh for more info on how to call the method.
        */
        void IPen.Write(string Text)
        {

        }

        //Below is the method of how to explicity implement an interface.
        int IPod.Write(string Text)
        {
            return 1;
        }
    }

    /*
        An interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement. An interface may define static methods, which
        must have an implementation. Beginning with C# 8.0, an interface may define a default implementation for members. An interface may not declare instance data such as fields,
        auto-implemented properties, or property-like events.
        
        By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C# because the language doesn't support multiple
        inheritance of classes. In addition, you must use an interface if you want to simulate inheritance for sturcts, because they can't actually inherit from another struct or
        class.
        
        You define an interface by using the interface keyword as the following example shows.
    */

    interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    /*
        The name of an interface must be a valid C# identifier name. By convention, interface names begin with a capital I.
        
        Any class or struct that implements the IEquatable<T> interface must contain a definition for an Equals method that matches the signature that the interface specifies. As a
        result, you can count on a class that implements IEquatable<T> to contain an Equals method with which an instance of the class can determine whether it's equal to another
        instance of the same class.
        
        The definition of IEquatable<T> doesn't provide an implementation for Equals. A class or struct can implement multiple interfaces, but a class can only inherit from a single class.
        
        Interfaces can contain instance methods, properties, events, indexers or any combination of those four member types. Interfaces may contain static constructors, fields,
        constants, or operators. An interface can't contain instance fields, instance constructors or finalizers. Interface members are public by default.
        
        To implement an interface member, the corresponding member of the implementing class must be public, non-static, and have the same name and signature as the interface member.
        
        When a class or struct implements an interface, the class or struct must provide an implementation for all of the members that the interface declares but doesn't provide a
        default implementation for. However, if a base class implements an interface, any class that's derived from the base class inherits that implementation.
        
        The following example shows an implementation of the IEquatable<T> interface. The implementing class, Car, must provide an implementation of the Equals method.
    */

    public class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car car)
        {
            return (this.Make, this.Model, this.Year) == (car.Make, car.Model, car.Year);
        }
    }

    /*
        Properties and indexers of a class can define extra accessors for a property or indexer that's defined in an interface. For example, an interface might declare a property
        that has a get accessor. The class that implements the interface can declare the same property with both a get and set accessor. However, if the property or indexer uses
        explicit implementation, the accessors must match.
        
        Interfaces can inherit from one or more interfaces. The derived interface inherits the members from its base interfaces. A class that implements a derived interface must
        implement all members in the derived interface, including all members of the derived interface's base interfaces. That class may be implicitly converted to the derived
        interface or any of its base interface. A class might include an interface multiple times through base classes that it inherits or through interfaces that other interfaces
        inherit. However, the class can provide an implementation of an interface only one time and only if the class declares the interface as part of the definition of the class
        (class ClassName : InterfaceName).
        
        If the interface is inherited because you inherited a base class that implements the interface, the base class provides the implementation of the members of the interface.
        However, the derived class can reimplement any virtual interface members instead of using the inherited implementation. When interface declare a default implementation of a
        method, any class implementing that interface inherits that implementation. Implementations defined in interfaces are virtual and the implementing class may override that
        implementation.
        
        A base class can also implement interface members by using virtual members. In that case, a derived class can change the interface behavior by overriding the virtual members.
        For more information about virtual members, see Polymorphism.
        
        Interfaces Summary
        An interface has the following properties:
        1. An interface is typically like an abstract base class with only abstract members. Any class or struct that implements the interface must implement all its members.
           Optionally, an interface may define default implementations for some or all of its members. For more information, see default interface methods.
        
        2. An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
        
        3. A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces.
    */
}
