using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.AdvancedOOPS
{
    /*
        Meaning of warning:
        
        'ClassA.AAA()' hides inherited member 'ClassB.AAA()'. Use the new keyword if hiding was intended.
        
        Your class has a base class, and this base class also has a property (which is not virtual or abstract) called Method which is being overridden by your class.
        If you intend to override it put the "new" keyword after the public modifier.
        
        If you don't wish to override it change your properties name to something else.
    */

    class H03_PolymorphismAndInheritance
    {
        /*
            Polymorphism and Inheritance (Dynamic Binding/Run Time Polymorphism):
            Run time polymorphism is also called Late Binding or Method Overriding. In run time polymorphism or method overriding, we can override a method in base
            class by creating similar method in derived class this can be achieved by using inheritance priniciple and using "virtual & override" keywords.
            
            What are New and Override Keywords in C#?
            To understand, just add two classes. The two classes will be named ClassA and ClassB.
            
            We see both classes ClassA and ClassB have the same number of methods with similar names in both the classes. Now let's inherit ClassA and ClassB, and
            create instances of the classes and call their methods.
        */
    }

    // ClassB, acting as a base class
    class ClassB
    {
        public void AAA()
        {
            Console.WriteLine("ClassB AAA");
        }

        public void BBB()
        {
            Console.WriteLine("ClassB BBB");
        }

        public void CCC()
        {
            Console.WriteLine("ClassB CCC");
        }
    }

    // ClassA, acting as a derived class
    class ClassA : ClassB
    {
        public void AAA()
        {
            Console.WriteLine("ClassA AAA");
        }

        public void BBB()
        {
            Console.WriteLine("ClassA BBB");
        }

        public void CCC()
        {
            Console.WriteLine("ClassA CCC");
        }
    }

    class ClassAB
    {
        public ClassAB()
        {
            ClassA x = new ClassA();
            ClassB y = new ClassB();
            ClassB z = new ClassA();

            x.AAA();
            x.BBB();
            x.CCC();

            y.AAA();
            y.BBB();
            y.CCC();

            z.AAA();
            z.BBB();
            z.CCC();

            /*
                Output:
                
                ClassA AAA
                ClassA BBB
                ClassA CCC
                
                ClassB AAA
                ClassB BBB
                ClassB CCC
                
                ClassB AAA
                ClassB BBB
                ClassB CCC
                
                Warnings:
                'ClassA.AAA()' hides inherited member 'ClassB.AAA()'. Use the new keyword if hiding was intended.
                'ClassA.BBB()' hides inherited member 'ClassB.BBB()'. Use the new keyword if hiding was intended.
                'ClassA.CCC()' hides inherited member 'ClassB.CCC()'. Use the new keyword if hiding was intended.
                
                Points to remember: In C#, we can equate an object of a base class to a derived class but not vice versa.
                
                Class ClassB is the super class of class ClassA. That means ClassA is the derived class and ClassB is the base class. The class ClassA comprises ClassB 
                and something more. So we can conclude that object of ClassA is bigger than object of ClassB. Since ClassA is inherited from ClassB, it contains its own 
                methods and properties. Moreover, it will also contain methods/properties that are inherited from ClassB too.
                
                Let’s take the case of object y. It looks like ClassB and initialized by creating an object that also looks like ClassB, well and good. Now, when we call 
                the methods AAA and BBB and CCC through the object y, we know that it will call them from ClassB.
                
                Object x looks like that of ClassA, i.e., the derived class. It is initialized to an object that looks like ClassA. When we call AAA, BBB and CCC method 
                through x, it calls AAA, BBB and CCC from ClassA.
                
                Now there is a somewhat tricky situation we are dealing with:
                
                Object z again looks like ClassB, but it is now initialized to an object that looks like ClassA which does not give an error as explained earlier. But 
                there is no change at all in the output we get and the behavior is identical to that of object y.Therefore initializing it to an object that looks like 
                ClassB or ClassA does not seem to matter.
            */
        }
    }

    class ClassBB
    {
        public virtual void AAA()
        {
            /*
                If we don't use virtual keyword in front of method AAA(), we will get the below error:
                'ClassA.AAA()': cannot override inherited member 'ClassB.AAA()' because it is not marked virtual, abstract, or override
            */
            Console.WriteLine("ClassBB AAA");
        }

        public void BBB()
        {
            Console.WriteLine("ClassBB BBB");
        }

        public void CCC()
        {
            Console.WriteLine("ClassBB CCC");
        }
    }

    class ClassAA : ClassBB
    {
        public override void AAA()
        {
            Console.WriteLine("ClassAA AAA");
        }

        public new void BBB()
        {
            Console.WriteLine("ClassAA BBB");
        }

        public void CCC()
        {
            Console.WriteLine("ClassAA CCC");
        }
    }

    class ClassAABB
    {
        public ClassAABB()
        {
            ClassBB y = new ClassBB();
            ClassAA x = new ClassAA();
            ClassBB z = new ClassAA();

            y.AAA();
            y.BBB();
            y.CCC();

            x.AAA();
            x.BBB();
            x.CCC();

            z.AAA();
            z.BBB();
            z.CCC();

            /*
                Output:
                
                ClassB AAA
                ClassB BBB
                ClassB CCC
                
                ClassA AAA
                ClassA BBB
                ClassA CCC
                
                ClassA AAA
                ClassB BBB
                ClassB CCC
                
                Points to remember: The override modifier is needed as the derived class methods will get first priority and be called upon.
                
                We see here that there is only a single small change in the workings of the object z only and not in x and y. This strange output occurred only after
                we added virtual modifier in the base class methods. The difference is in the object z. z looks like the base class ClassB but is initialized to an
                instance that looks like that of derived class ClassA. C# knows this fact.
                
                When we run z.AAA(), C# remembers that instance z was initialized by a ClassA object and hence it first goes to class ClassA, too obvious. Here the
                method has a modifier override which literally means, forget about the data type of z which is ClassB, call AAA from ClassA as it overrides the AAA of
                the base class. The override modifier is needed as the derived class methods will get first priority and be called upon.
                
                We wanted to override the AAA of the base class ClassB. We are infact telling C# that this AAA is similar to the AAA of the one in base class.
                
                New keyword acts in the exact opposite to override keyword. The method BBB as we see has the new modifier. z.BBB() calls BBB from ClassB and not ClassA.
                New means that the method BBB is a new method and it has absolutely nothing to do with the BBB in the base class. It may have the same name i.e. BBB
                as in the base class, but that is only a coincidence. As z looks like ClassB, the BBB of ClassB gets called even though there is a BBB in ClassA.
                When we do not write any modifier, then it is assumed that we wrote new. So every time we write a method, C# assumes it has nothing to do with the base
                class.
                
                Points to remember: These modifiers like new and override can only be used if the method in the base class is a virtual method. Virtual means that the
                base class is granting us permission to invoke the method from the derived class and not the base class. But, we have to add the modifier override if
                our derived class method has to be called.
            */
        }
    }

    /*
        Run Time Polymorphism with Three Classes
        Let's get into some more action. Let's invoke one more class in the play. Let's add a class named ClassC, and design our three classes and program.cs as follows:
    */

    public class B
    {
        public void AAA()
        {
            Console.WriteLine("ClassB AAA");
        }

        public virtual void BBB()
        {
            Console.WriteLine("ClassB BBB");
        }

        public virtual void CCC()
        {
            Console.WriteLine("ClassB CCC");
        }
    }

    public class A : B
    {
        public virtual void AAA()
        {
            Console.WriteLine("ClassA AAA");
        }

        public new void BBB()
        {
            Console.WriteLine("ClassA BBB");
        }

        public override void CCC()
        {
            Console.WriteLine("ClassA CCC");
        }
    }

    public class C : A
    {
        public override void AAA()
        {
            Console.WriteLine("ClassC AAA");
        }

        public void BBB()
        {
            Console.WriteLine("ClassC BBB");
        }

        public void CCC()
        {
            Console.WriteLine("ClassC CCC");
        }
    }

    public class ABC
    {
        public ABC()
        {
            B y = new A();
            B x = new C();
            A z = new C();

            y.AAA();
            y.BBB();
            y.CCC();

            x.AAA();
            x.BBB();
            x.CCC();

            z.AAA();
            z.BBB();
            z.CCC();

            /*
                Output:
                
                ClassB AAA
                ClassB BBB
                ClassA CCC
                
                ClassB AAA
                ClassB BBB
                ClassA CCC
                
                ClassC AAA
                ClassA BBB
                ClassA CCC
                
                Don't be scared of the long example that we have taken. This will help you to learn the concept in detail. We have already learned that we can initialize
                a base object to a derived object. But vice versa will result into error. This leads to an instance of a base class being initialized to an instance of
                the derived class. So the question is now that which method will be called when. The method from the base class or from the derived class.
                
                Point to remember: If the base class object declared the method virtual and the derived class used the modifier override, the derived class method will
                get called. Otherwise the base class method will get executed. Therefore for virtual methods, the data type created is decided at run time only.
                
                Point to remember: All the methods not marked with virtual are non virtual, and the method to be called is decided at compile time, depending upon the
                static data type of the object.
                
                If the object of a class is initialized to the same data type, none of the above rule would apply. Whenever we have a mismatch, we always need rules to
                resolve the mismatch. So we can land up with a scenario where an object to a base class can call a method in the derived class.
                
                The object y that looks like of ClassB but is initialized here to the derived class, i.e. ClassA.
                
                y.AAA() first looks into the class ClassB. Here, it verifies whether the method AAA is marked virtual. The answer is an emphatic no and hence everything
                comes to halt and the method AAA gets called from class ClassB.
                
                y.BBB also done the same thing, but the method now is defined virtual in class ClassB. Thus C# looks at the class ClassA, the one it was initialized to.
                Here BBB is marked with the modifier "new". That means BBB is a new method which has nothing to do with the one in the base class. They only accidentally
                share the same name. So as there is no method called BBB (as it is a new BBB) in the derived class, the one from base class gets called. In the scene
                of y.CCC(), the same above steps are followed again, bu in the class ClassA, we see the modifier override, that by behavior overrides the method in
                the base class. We are actually telling C# to call this method in class ClassA and not the one in the base class, i.e. ClassB.
                
                The object x which also looks like that of class ClassB is now initialized with an object that looks like our newly introduced class ClassC and not
                ClassA like before. Since AAA is a non virtual method, it gets called from ClassB. In the case of method BBB, C# now looks into class ClassC. Here, it
                does not find a method named BBB and so ultimately propogates and now looks into class ClassA. Therefore the above rules repeat on and on and it gets
                called from class ClassB. In the case of x.CCC, in class ClassC, it is already marked new by default and therefore this method has nothing to do with
                the one declared in class ClassB. So the one from ClassC does not get called but the one from class ClassB where it is marked as override.
                
                Now if we modify a bit our CCC method in ClassC and change it to the code as shown below:
                
                public override void CCC()
                {
                    Console.WriteLine("ClassC CCC");
                }
                
                We changed default new to override, the CCC of ClassC will now be called.
                
                The last object z looks like that of ClassA but is now initialized to an object that looks like the derived class ClassC, we know we can do this.
                So z.AAA() when called, looks first into class ClassA where it is flagged as virtual.
            */
        }
    }

    // Jon Skeet's explanation of the new keyword

    /*
        Just using new creates a new method without associating it with the interface. You're using the interface in your real code, so you want the binding of
        the interface method to the new method. To do that, you have to declare that you're implementing the interface again. Here's an example showing the difference:
    */

    interface IFoo
    {
        void Bar();
    }

    public class Normal : IFoo
    {
        public void Bar()
        {
            Console.WriteLine("Normal.Bar");
        }
    }

    public class Extended1 : Normal
    {
        public new void Bar()
        {
            Console.WriteLine("Extended1.Bar");
        }
    }

    public class Extended2 : Normal, IFoo
    {
        public new void Bar()
        {
            Console.WriteLine("Extended2.Bar");
        }
    }

    public class JonSkeet
    {
        public void MainMethod()
        {
            IFoo x = new Extended1();
            IFoo y = new Extended2();

            x.Bar();
            y.Bar();
        }

        /*
            Output:
            
            Normal.Bar
            Extended2.Bar
        */
    }
}
