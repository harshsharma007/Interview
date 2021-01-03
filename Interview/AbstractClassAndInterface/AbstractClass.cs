using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    /*
        Q. Why we need an Abstract Class?
        Because using an abstract class will restrict a user to not create an object of an abstract class. Otherwise, this would not be a case in other concrete class in which an object 
        of a class can be created and may result in unexpected behaviors because it may contain some functions that need to be declared in the inherited class.
        
        Q. When to use Abstract Classes in C#?
        When we have a requirement where our base class should provide the default implementation of certain methods whereas other methods should be open to being overridden by child
        classes use abstract classes.
        
        Q. What is an Abstract Class in C#?
        A class that is declared by using the keyword abstract is called an abstract class. An abstract class is a partially implemented class used for developing some of the operations
        which are common for all next level sub classes. So it contains both abstract methods, concrete methods including variables, properties and indexers.
        
        It is always created as a super class next to interface in object inheritance hierarchy for implementing common operations from the interface.
        
        An abstract class may or may not have abstract methods. But if a class contains an abstract method then it must be declared as abstract. The abstract class cannot be instantiated
        directly. It's compulsory to create/derive a new class from an abstract class in order to provide the functionality to its abstract functions.
        
        Q. Can you create an instance of an Abstract Class?
        No, abstract classes are incomplete and we cannot create an instance of an abstract class.
        
        Q. What is the abstract method?
        A method that does not have the body is called an abstract method. It is declared with the modifier abstract. It contains only the declaration/signature and does not contain
        the implementation/body of the method. An abstract function should be terminated with a semicolon. Overriding of an abstract function is compulsory.
        
        Q. When to use the abstract method?
        Abstract methods are usually declared where two or more subclasses are expected to fulfill a similar role in different ways.
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
            We can have an abstract class without abstract method, as both are independent concepts. Declaring a class abstract means that it can not be instantiated on its own and can 
            only be subclassed. Declaring a method abstract means that Method will be defined in the subclass.
        */
    }

    abstract class NewAbstractClass
    {
        /*
            By default, if no access modifier is applied on a constructor then it would be a private constructor and a class cannot inherit the whole class due to its protection level.
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
            If a class inherits other class and both classes consist of a constructor, then the constructor of a parent class will be called first and after that child class constructor
            will be called.
        */

        public ParentAbstractClass()
        {
            Console.WriteLine("In Child Class");
        }
    }

    /*
        Q. Can an Abstract Class have a constructor? If so what is the use?
        Yes, an abstract class can have a constructor. In general, a class constructor is used to initialize fields. Along the same lines, an abstract class constructor is used to
        initialize fields of the abstract class. We would provide a constructor for an abstract class if we want to initialize certain fields of the abstract class before the
        instantiation of a child-class takes place. An abstract class constructor can also be used to execute code that is relevant for every child's class. This prevents duplicate
        code.
        
        Q. We cannot create an instance of an abstract class. So, what is the use of a constructor in an abstract class?
        Though we cannot create an instance of an abstract class, we can create instances of the classes that are derived from the abstract class. So, when an instance of a derived
        class is created, the parent abstract class constructor is automatically called.
        
        Note: Abstract classes can't be directly instantiated. The abstract class constructor gets executed through a derived class. So, it is a good practice to use a protected
        access modifier with the abstract class constructor. Using public doesn't make sense.
        
        Q. An Abstract Method in an Abstract Class does not have any implementation, so what is the use of calling it from the abstract class constructor?
        If we want the abstract method to be invoked automatically whenever an instance of the class that is derived from the abstract class is created, then we would call it in the
        constructor of the abstract class.
        
        Q. When should a class be declared as abstract?
        A class should be declared as abstract:
            - If it has any abstract methods.
            - If it does not provide implementation to any of the abstract methods it inherited.
            - When it does not provide implementation to any of the methods of an interface.
        
        Q. Why should the method have an abstract keyword if it does not have the body?
        In a class, we are allowed only to define a class with the body. Since we are changing its default property (means removing its body) it must have the abstract keyword in
        its prototype.
        
        Q. What are the characteristics of an abstract class in C#?
        - The abstract class can contain both abstract methods and non-abstract (concrete) methods.
        - It can contain both static and instance variables.
        - The abstract class cannot be instantiated but its reference can be created.
        - If any class contains abstract methods then it must be declared by using the keyword abstract.
        - An abstract class can contain sealed methods.
        - The abstract method or class cannot be declared as sealed.
        - A subclass of an abstract class can only be instantiated if it implements all of the abstract methods of its superclass. Such classes are called concrete classes to
          differentiate them from abstract classes.
    */
}
