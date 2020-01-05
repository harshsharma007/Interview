using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    sealed class SealedClass
    {
        //Sealed class is used to prevent inheritance.
        //Class named SealedClass cannot be inherited further.
        //Error message will be: cannot derive from sealed type.
        //Although we can create an object of a sealed class, there is no restriction in that.

        public SealedClass()
        {

        }
    }

    class ParentClass
    {
        public virtual void Method1()
        {
            SealedClass sealedClass = new SealedClass();
        }

        public virtual void Method2()
        {

        }
    }

    class ChildClass : ParentClass
    {
        public override sealed void Method1()
        {
            //A method can be decorated with a sealed keyword only if it is virtual in the parent class and in the child class it is overridden.
            //A sealed method allows that a method cannot be overridden in the subsequent class.
            //Error message will be: cannot override inherit member '{name}' because it is sealed.
        }

        public override void Method2()
        {
            
        }
    }

    class FurtherClass : ChildClass
    {
        //public override sealed void Method1()
        //{

        //}
    }
}
