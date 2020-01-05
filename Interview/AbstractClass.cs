using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
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
        //We can have an abstract class without abstract method, as both are independent concepts. Declaring a class abstract means that it can not be 
        //instantiated on its own and can only be subclassed. Declaring a method abstract means that Method will be defined in the subclass.
    }

    class ParentAbstract : AbstractClass
    {
        //Now the ParentAbstract class has to implement abstract method Method1, otherwise it will throw an exception.
        //Error: 'ParentAbstract' does not implement inherited abstract method 'AbstractClass.Method1()'.
        public override void Method1()
        {
            
        }

        public ParentAbstract() : base("Test")
        {

        }
    }

    class NewParentAbstract : NewAbstract//, AbstractClass
    {
        //An empty abstract class can be inherited.
        //But a class cannot inherit multiple abstract class. It will throw a compile-time error.
        //Error: Class '' cannot have multiple base classes.
    }
}
