using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    /*
        Why we need an abstract class?
        Because using an abstract class will restrict a user to not create an object of an abstract class. Otherwise, this would not be a case in other concrete class in
        which an object of a class can be created and may result in unexpected behaviors because it may contain some functions that need to be declared in the inherited
        class.
    */

    abstract class AbstractClass
    {
        //A property with private set
        public string Name { get; private set; }

        //Abstract Method
        abstract public void Method1();

        //Constructor in an Abstract Class
        protected AbstractClass(string name)
        {
            this.Name = name;
        }
    }

    public abstract class NewAbstract
    {
        /*
            We can have an abstract class without abstract method, as both are independent concepts. Declaring a class abstract means that it can not be instantiated
            on its own and can only be subclassed. Declaring a method abstract means that Method will be defined in the subclass.
        */
    }

    abstract class NewAbstractClass
    {
        /*
            By default, if no access modifier is applied on a constructor then it would be a private constructor and a class cannot inherit the whole class due to its
            protection level.
        */

        //Error: 'ClassName' is inaccessible due to its protection level.
        public NewAbstractClass()
        {
            Console.WriteLine("In abstract");
        }
    }

    class ParentAbstract : AbstractClass
    {
        /*
            Now the ParentAbstract class has to implement abstract method Method1 otherwise, it will throw an exception.
            Error: 'ParentAbstract' does not implement inherited abstract method 'AbstractClass.Method1()'.
        */
        public override void Method1()
        {
            
        }

        /*
            To invoke the parameterized constructor of an abstract class below is the code. It can be invoked using the base keyword.
            Supply an argument to the base class constructor. So you don't necessarily need to pass any information to the derived class constructor, but the derived
            class constructor must pass information to the base class constructor if that only exposes a parameterized constructor.
        */

        public ParentAbstract() : base("Test")
        {

        }
    }

    class NewParentAbstract : NewAbstract//, AbstractClass
    {
        /*
            An empty abstract class can be inherited.
            But a class cannot inherit multiple abstract class. It will throw a compile-time error.
            Error: Class '' cannot have multiple base classes.
        */
    }

    class ParentAbstractClass : NewAbstractClass
    {
        /*
            A class cannot be instantiated if it contains a private constructor.
            If a class inherits other class and both classes consist of a constructor, then the constructor of a parent class will be called first and after that
            child class constructor will be called.
        */

        public ParentAbstractClass()
        {
            Console.WriteLine("In Child Class");
        }
    }
}
