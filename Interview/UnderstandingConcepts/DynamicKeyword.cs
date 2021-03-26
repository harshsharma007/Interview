using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;

namespace Interview.UnderstandingConcepts
{
    /*
        Short Answer:
        Dynamic should be used only when not using it is painful. Like in MS Office Libraries. In all other cases it should be avoided as compile type checking is
        beneficial. Following are the good situations of using dynamic.
        
        1. Calling javascript method from Silverlight.
        2. COM interop.
        3. Maybe reading XML, Json without creating custom classes.
    */

    class DynamicKeyword
    {
        public DynamicKeyword()
        {
            /*
                What is Dynamic?
                Programming languages are sometimes divided into statically type and dynamically typed languages. C# and Java are often considered examples of statically
                typed languages, while Python, Ruby and JavaScript are examples of dynamically typed languages.
                
                Generally speaking, dynamic languages don't perform compile-time type checks and identify the type of objects at run time only. This approach has its
                pros and cons: Often the code is much faster and easier to write, but at the same time you don't get compiler errors and have to use unit testing and
                other techniques to ensure the correct behavior of your application.
                
                Originally, C# was created as a purely static language, but with C# 4, dynamic elements have been added to improve interoperability with dynamic
                languages and frameworks. The C# team considered several design options, but finally settled on adding a new keyword to support these features: dynamic.
                
                The dynamic keyword acts as a static type declaration in the C# type system. This way C# got the dynamic features and at the same time remained a
                statically typed language. Among other things, it was decided that dynamic objects should be first-class citizens of the C# language, so there's no
                option to switch dynamic features on or off, and nothing similar to the Option Strict On/Off in Visual Basic was added to C#.
                
                When you use the dynamic keyword you tell the compiler to turn off compile-time checking. A common example looks like this:
            */

            dynamic d = "test";
            Console.WriteLine(d.GetType()); // Prints "System.String"

            d = 100;
            Console.WriteLine(d.GetType()); // Prints "System.Int32"

            /*
                As you can see, it's possible to assign objects of different types to a variable declared as dynamic. The code compiles and the type of object is
                identified at run time. However, this code compiles as well, but throws an exception at run time:
            */

            d = "test";
            d++; // The following line throws an exception at run time.

            /*
                The reason is the same: The compiler doesn't know the runtime type of the object and therefore can't tell you that the increment operation is not
                supported in this case.
                
                Absence of compile-time type checking leads to the absence of IntelliSense as well. Because the C# compiler doesn't know the type of the object, it
                can't enumerate its properties and methods. This problem might be solved with additional type inference, as is done in the IronPython tools for
                Visual Studio, but for now C# doesn't provide it.
                
                However, in many scenarios that might benefit from the dynamic features, IntelliSense wasn't available anyway because the code used string literals.
                This issue is discussed in more detail later in this article.
            */

            /*
                Dynamic, Object or Var?
                So what's the real difference between dynamic, object and var and when should you use them? Here are short definitions of each keyword and some examples.
                
                The object keyword represents the System.Object type, which is the root type in the C# class hierarchy. This keyword is often used when there's no way
                to identify the object type at compile time, which often happens in various interoperability scenarios.
                
                You need to use explicit casts to convert a variable declared as object to a specific type:
            */

            object objExample = 10;
            Console.WriteLine(objExample.GetType());

            // This obviously prints System.Int32. However, the static type is System.Object, so you need an explicit cast here:
            objExample = (int)objExample + 10;

            // You can assign values of different types because they all inherit from System.Object:
            objExample = "test";

            /*
                The var keyword, since C# 3.0, is used for implicitly typed local variables and for anonymous types. This keyword is often used with LINQ. When a
                variable is declared by using the var keyword, the variable's type is inferred from the initialization string at compile time. The type of the variable
                can't be changed at run time. If the compiler can't infer the type, it produces a compilation error:
            */
            var varExample = 10;
            Console.WriteLine(varExample.GetType());

            /*
                This prints System.Int32, and it's the same as the static type. In the following example, no cast is required because varExample's static typed is
                System.Int32:
            */

            varExample = varExample + 10;

            // This line doesn't compile because you can only assign integers to varExample:
            // varExample = "test";

            /*
                The dynamic keyword, introduced in C# 4, makes certain scenarios that traditionally relied on the object keyword easier to write and maintain. In fact,
                the dynamic type uses the System.Object type under the hood, but unlike object it doesn't require explicit cast operations at compile time, because
                it identifies the type at run time only:
            */

            dynamic dynamicExample = 10;
            Console.WriteLine(dynamicExample.GetType());

            /*
                This prints System.Int32. In the following line, no cast is required, because the type is identified at run time only:
            */
            dynamicExample = dynamicExample + 10;

            // You can assign values of different types to dynamicExample:
            dynamicExample = "test";

            // What sometimes causes confusion is that all of these keywords can be used together - they're not mutually exclusive. Let's take a look at the code below:
            dynamic dynamicObject = new Object();
            var anotherObject = dynamicObject;

            /*
                What's the type of anotherObject? The answer is: dynamic. Remember that dynamic is in fact a static type in the C# type system, so the compiler infers
                this type for the anotherObject. It's important to understand that the var keyword is just an instruction for the compiler to infer the type from the
                variable's initialization expression; var is not a type.
            */

            /*
                The Dynamic Language Runtime
                When you hear the term "dynamic" in regard to the C# language, it usually refers to one of two concepts: the dynamic keyword in C# 4 or the DLR.
                Although these two concepts are related, it's important to understand the difference as well.
                
                The DLR serves two main goals. First, it enables interoperation between dynamic languages and the .NET Framework. Second, it brings dynamic behavior to
                C# and Visual Basic.
                
                The DLR was created based on lessons learned while building IronPython, which was the first dynamic language implemented on the .NET Framework. While
                working on IronPython, the team found out that they could reuse their implementation for more than one language, so they created a common underlying
                platform for .NET dynamic languages.
                
                Later the DLR was also included in the .NET Framework 4 to support dynamic features in C# and Visual Basic. If you only need the dynamic keyword in C# 4,
                you can simply use the .NET Framework and in most cases it will handle all interactions with the DLR on its own. But if you want to implement or port
                a new dynamic language to .NET, you may benefit from the extra helper classes in the open source project, which has more features and services for
                language implementers.
            */

            /*
                Using Dynamic in a Statically Typed Language
                It's not expected that everybody should use dynamic whenever possible instead of the static type declarations. Compile-time checking is a powerful
                instrument and the more benefits you can get from it, the better. And once again, dynamic objects in C# do not support IntelliSense, which might have
                a certain impact on overall productivity.
                
                At the same time, there are scenarios that were hard to implement in C# prior to the dynamic keyword and DLR. In most cases they used System.Object
                type and explicit casting and couldn't get much benefit from compile-time checking and IntelliSense anyway. Here are some examples.
                
                The most notorious scenario is when you have the object keyword for interoperability with other languages or frameworks. Usually you have to rely on
                reflection to get the type of the object and to access its properties and methods. The syntax is sometimes hard to read and consequently the code is
                hard to maintain. Using dynamic here might be much easier and more convenient than reflection.
                
                object calc = GetCalculator();
                Type calcType = calc.GetType();
                object res = calcType.InvokeMember("Add", BindingFlags.InvokeMethod, null, new object[] { 10, 20 });
                int sum = Convert.ToInt32(res);
                
                The function returns a calculator, but the system doesn't know the exact type of this calculator object at compile time. The only thing the code relies
                on is that this object should have the Add method. Note that you don't get IntelliSense for this method because you supply its name as a string literal.
                
                With the dynamic keyword, this code looks as simple as this one:
                dynamic calc = GetCalculator();
                int sum = calc.Add(10, 20);
                
                The assumptions are the same: There's some object with an unknown type that we expect to have the Add method. And similar to the previous example, you
                don't get IntelliSense for this method. But the syntax is much easier to read and use and looks similar to calling a typical .NET method.
            */

            /*
                Dynamic Method Bags
                Another example where dynamic can help is creating dynamic method bags, which are objects that can add and remove properties and methods at run time.
                The .NET Framework 4 has a new namespace: System.Dynamic. This namespace is in fact a part of the DLR. The System.Dynamic.ExpandoObject and
                System.Expando.DynamicObject classes in combination with the new dynamic keyword can help you to create dynamic structures and hierarchies in a clear
                and easy-to-read way.
                
                For example, here's how you can add a property and a method by using the ExpandoObject class:
            */

            dynamic expando = new ExpandoObject();
            expando.SampleProperty = "This property was added at run time";
            expando.SampleMethod = (Action)(() => Console.WriteLine(expando.SampleProperty));
            expando.SampleMethod();
        }
    }

    /*
        Class Wrappers
        You can provide a better syntax for your own library or create a wrapper for an existing library. This is a more advanced scenario compared to the previous two 
        and requires a deeper understanding of the DLR specifics.
                
        For simple cases you can use the DynamicObject class. In this class you can mix static declaration of methods and properties with the dynamic dispatch. So you 
        can store an object for which you want to provide better syntax in a class property, but handle all operations with this object through a dynamic dispatch.
                
        As an example, look at the DynamicString class below that wraps a string and displays names of all methods before actually calling those methods through 
        reflection.
    */

    public class DynamicString : DynamicObject
    {
        string str;

        public DynamicString(string str)
        {
            this.str = str;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine("Calling method: {0}", binder.Name);
            try
            {
                result = typeof(string).InvokeMember(binder.Name, System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.Instance, null, str, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }
    }

    /*
        To instantiate this class you should use the dynamic keyword:
    */

    public class Instantiate
    {
        public Instantiate()
        {
            dynamic dStr = new DynamicString("Test");
            Console.WriteLine(dStr.ToUpper());
            Console.ReadLine();
        }

        /*
            Of course, this particular example is contrived and not really efficient. But if you have an API that already relies heavily on reflection, you can wrap
            all calls through reflection as shown here so the end users of your API won't see them.
            
            As I mentioned, the DynamicObject class provided by the DLR. DynamicObject or ExpandoObject is all you need to produce a dynamic object. However, some
            dynamic objects have a complicated binding logic for accessing members or invoking methods. Such objects need to implement the IDynamicMetaObjectProvider
            inter-face and provide their own dynamic dispatch.
        */

        /*
            Scriptable Applications
            Scripts are a powerful way to provide extensibility for your application. Microsoft Office can serve as a good example here: numerous macros, add-ons and
            plug-ins exist due to Visual Basic for Applications (VBA). And now the DLR enables you to create scriptable applications because it provides a common set
            of hosting APIs for languages.
            
            For example, you can create an application where users would be able to add functionality themselves without asking for new features from the main product,
            like adding new characters and maps to a game or new graphs to a business application.
            
            You have to use the open source version of the DLR from dlr.codeplex.com instead of the one used by the .NET Framework 4 because, right now, the DLR
            scripting and hosting APIs are only available in the open source version. Also, it's assumed that you'll write scripts not by using C#, but rather one of
            the .NET dynamic languages, such as IronPython or IronRuby. However, any language can support these APIs, even one that's not implemented on top of the DLR.
        */

        /*
            Identifying Dynamic Objects
            How can you distinguish dynamic objects from other objects? One easy way is to use built-in IDE features. You can either hover the mouse cursor over the
            object to see its declaration type or check whether IntelliSense is available.
            
            At run time, however, things get more complicated. You can't check whether the variable was declared by the dynamic keyword - the runtime type of the
            dynamic object is the type of the value it stores and you can't get its static type declaration. It's the same as if you declare your variable as object:
            At run time you can only get a type of the value that the variable holds; you can't tell whether this variable was originally declared as object.
            
            What you can identify at run time is whether an object is coming from the DLR. It might be important because objects of types like ExpandoObject and
            DynamicObject can change their behavior at run time - for example, add and delete properties and methods.
            
            Also, you can't use standard reflection methods to get information about such objects. If you add a property to an instance of the ExpandoObject class, you
            can't get this property from reflection:
        */

        public Instantiate(string str)
        {
            dynamic expando = new ExpandoObject();
            expando.SampleProperty = "This property was added at run time";
            PropertyInfo dynamicProperty = expando.GetType().GetProperty("SampleProperty");
            // dynamicProperty is null

            /*
                The good thing is that, in the .NET Framework 4, all objects that can dynamically add and remove members must implement one particular interface:
                System.Dynamic.IDynamicMetaObjectProvider
            
                Both DynamicObject and ExpandoObject classes implement this interface, as well. However, this doesn't mean that any object declared by using the dynamic
                keyword implements this interface:
            */

            dynamic expand = new ExpandoObject();
            Console.WriteLine(expand is IDynamicMetaObjectProvider); // True

            dynamic test = "test";
            Console.WriteLine(test is IDynamicMetaObjectProvider); // False

            /*
                So, if you're using dynamic along with reflection, keep in mind that reflection won't work for dynamically added properties and methods, and that it
                might be a good idea to check whether the object you're reflecting on implements the IDynamicMetaObjectProvider interface.
            */

            /*
                Dynamic and COM Interop
                The COM interop scenario that the C# team specifically targeted in the C# 4 release was programming against Microsoft Office applications, such as
                Word and Excel. The intent was to make this task as easy and natural in C# as it always was in Visual Basic. This is also a part of the Visual Basic
                and C# co-evolution strategy, where both languages aim at feature parity and borrow the best and most productive solutions from one another.
                
                Below example shows the C# 4 code that adds a value to the first cell in the Excel worksheet and then applies the AutoFit method to the first column.
                The comments under each line show equivalents from C# 3.0 and earlier.
                
                Add this line to the beginning of the file:
                using Excel = Microsoft.Office.Interop.Excel;
                var excelApp = new Excel.Application();

                excelApp.Workbooks.Add();
                excelApp.Workbooks.Add(Type.Missing);
                excelApp.Visible = true;

                Excel.Range targetRange = excelApp.Range["A1"];
                Excel.Range targetRange = excelApp.get_Range("A1", Type.Missing);
                targetRange.Value = "Name";
                targetRange.set_Value(Type.Missing, "Name");
                targetRange.Columns[1].AutoFit();
                ((Excel.Range)targetRange.Columns[1, Type.Missing]).AutoFit();
                
                The interesting thing about this example is you can't see the dynamic keyword anywhere in the code. In fact, it's used in just one line here:
                targetRange.Columns[1].AutoFit();
                ((Excel.Range)targetRange.Columns[1, Type.Missing]).AutoFit();
                
                In the C# 3.0 version, targetRange.Columns[1, Type.Missing] returns object, and that's why the casting to Excel.Range is necessary. But in C# 4 and
                Visual Studio 2010 such calls are silently converted into dynamic ones. So, the type of the targetRange.Columns[1] in C# 4 is actually dynamic.
                
                Another highlight is that the COM interop improvements in C# 4 are not just about dynamic. In all ther lines better syntax is achieved because of
                other new features such as indexed properties and named and optional parameters.
            */
        }
    }
}
