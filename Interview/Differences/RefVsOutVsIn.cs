using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Differences
{
    class RefVsOutVsIn
    {
        /*
            These techniques allow you to change how C# handles altering data locally in the method as well as outside the method.
            
            The in, ref, and out Modifiers
            Method parameters have modifiers available to change the desired outcome of how the parameter is treated. Each method has a specific use case:
            
            1. ref is used to state that the parameter passed may be modified by the method.
            2. in is used to state that the parameter passed cannot be modified by the method.
            3. out is used to state that the parameter passed must be modified by the method.
            
            Both the ref and in require the parameter to have been initialized before being passed to a method. The out modifier does not require this and is typically
            not initialized prior to being used in a method.
            
            The ref Modifier
            By default, a reference type passed into a method will have any changes made to its values reflected outside the method as well. If you assign the reference
            type to a new reference type inside the method, those changes will only be local to the method. Using the ref modifier, you have the option to assign a new
            reference type and have it reflected outside the method.
        */
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }

    class ReferenceTypeExample
    {
        static void Enroll(ref Student student)
        {
            // With ref, all three lines below alter the student variable outside the method.
            student.Enrolled = true;
            student = new Student();
            student.Enrolled = false;
        }

        static void MainMethod()
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(ref student);
            // student.Name is now null since a value was not passed when declaring new Student() in the Enroll method
            // student.Enrolled is now false due to the ref modifier
        }

        // Using the ref modifier, you can also change value types outside the method as well.
        static void IncrementExample(ref int num)
        {
            num = num + 1;
        }

        static void MethodMain()
        {
            int num = 1;
            IncrementExample(ref num);
            // num is now 2
        }
    }

    /*
        The out Modifier
        Using the out modifier, we initialize a variable inside the method. Like ref, anything that happens in the method alters the variable outside the method. With
        ref, you have the choice to not make changes to the parameter. When using out, you must initialize the parameter you pass inside the method. The parameter
        being passed in often is null.
    */

    class OutTypeExample
    {
        static void Enroll(out Student student)
        {
            // We need to initialize the variable in the method before we can do anything
            student = new Student();
            student.Enrolled = false;
        }

        static void MainMethod()
        {
            Student student;
            Enroll(out student);
            // student will be equal to the value in Enroll. Name will be null and Enrolled will be false.
        }

        // The out modifier works with value types as well. A useful example is using the out modifier to change a string to an int.
        static void MethodMain()
        {
            int x;
            Int32.TryParse("3", out x);
        }
    }

    /*
        The in Modifier
        The in modifier is most often used for performance reasons and was introduced in C# 7.2. The motivation of in is to be used with a struct to improve performance
        by declaring that the value will not be modified. When using with reference types, it only prevents you from assigning a new reference.
    */

    class InTypeExample
    {
        static void Enroll(in Student student)
        {
            // With in assigning a new object would throw an error
            // student = new Student();

            // We can still do this with reference types though
            student.Enrolled = true;
        }

        static void MainMethod()
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(student);
        }
    }

    /*
        Modifiers Are Not Allowed on All Methods
        It's important to note that in, out and ref cannot be used in methods with the async modifier. You can use them in synchronous methods that return a task, though.
        You cannot use them in iterator methods that have a yield return or yield break either.
        
        Overloading Methods with Modifiers
        When overloading a method in C#, using a modifier will be considered a different method signature than not using a modifier at all. You cannot overload a method
        if the only difference between methods is the type of modifier used. This will result in a compile error.
        
        Conclusion
        Knowing these simple techniques can make your code easier to understand and simpler to read.
    */
}
