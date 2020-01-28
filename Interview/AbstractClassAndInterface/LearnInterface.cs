using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    interface IPen
    {
        //We cannot create a constructor inside an interface. If you want to create a constructor then create an abstract class. Example is already given.
        //You cannot use any access modifier for any member of an interface. All the members by default are public members.
        //If you use an access modifier in an interface then the C# compiler will give a compile-time error.
        //Error: The modifier 'public/private/protected' is not valid for this item.
        string Color { get; set; }
        bool Open();
        bool Close();
        void Write(string Text);
    }

    interface IPod : IPen
    {
        //C# allows the inheritance of one interface to another interface. A class which is implementing the child interface must provide the definition of
        //each and every signature which is defined within the interface inheritance chain.

        //Apart from that, an interface can be defined with an empty body.

        //If the interface which is inheriting the parent interface has defined the method, property with the same name, then the signature will hide the 
        //member of an inherited interface.
        //In this case use of 'new' keyword is recommended.
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

        //If you try to decorate a method other than public, then also the compiler will throw a compile-time error.
        //So, only public keyword can be used.
        public void Write(string Text)
        {
            //Tag - Harsh
            //Why are explicit members (very) private? Consider:
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

        //Welcome to the concept of explicit implementation of an interface.
        //When using explicit implementation of an interface, the members are forced to something more restricted than private in the class itself.
        //And when the access modifier is forced, you may not add one.
        //Likewise, in the interface itself, all members are public. If you try to add a modifier inside an interface you will get a similar error.
        //Error: The modifier public is not valid for this item.
        //Go to Tag - Harsh for more info on how to call the method.
        void IPen.Write(string Text)
        {

        }

        //Below is the method of how to explicity implement an interface.
        int IPod.Write(string Text)
        {
            return 1;
        }
    }
}
