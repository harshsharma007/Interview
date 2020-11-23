using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    class PrivateConstructor
    {
        public string name;
        private PrivateConstructor() //Default Constructor
        {
            /*
                Private Constructor is a special instance constructor.
                If a class contains one or more private constructors and no public constructors, then the other classes are not allowed to create an instance
                for that particular class except nested classes.
            */
        }

        PrivateConstructor(int a)
        {
            /*
                If we didn't use any access modifier to define constructor, then by default it will be treated as a private.
                Moreover, a constructor cannot have any return type.
            */
        }

        public PrivateConstructor(string a)
        {
            name = a;
        }
    }

    class PrivateParentClass
    {
        /*
            Here we are initializing parameterized constructor which is decorated as public.
            If you try to initialize a private constructor then there would be a compile time error.
        */

        PrivateConstructor privateConstructor = new PrivateConstructor("Test");

        public string Method1()
        {
            return privateConstructor.name;
        }
    }

    class NewPrivateConstructor
    {
        private NewPrivateConstructor()
        {

        }

        public NewPrivateConstructor(int a)
        {

        }
    }

    class NewChildPrivateConstructor //: NewPrivateConstructor
    {
        /*
            A class with a private constructor cannot be inherited.

            A class with a privatet constructor cannot be inherited. Then what is the use of private constructors?
            In .Net 1.X there was no static classes so developers used private constructor to prevent object creations.
            
            If a class with private constructor and a sealed class cannot be inherited, then what is the use of such class?
            It means that the developer wants to create a strict singleton class which can not be inherited further. And as said previously, private constructors
            can be excused because we have static classes now. So, private constructor + sealed means pure static class.

            Also, sealed class cannot be inherited, then where to use sealed and where to use private constructor?
            Personally, private constructor I will not use and would prefer using static keyword. Sealed, I will use to prevent further inheritance.
        */
    }
}
