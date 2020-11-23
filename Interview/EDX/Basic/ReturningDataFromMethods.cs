using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class ReturningDataFromMethods
    {
        /*
            If the method returns a value, you specify how to handle this value, typically by assigning it to a variable of the same type, in your calling code.
            The following code example shows how to capture the return value of the GetServiceName method in a variable named serviceName.
            
            string serviceName = GetServiceName();
            string GetServiceName()
            {
                return "FourthCoffee.SalesService";
            }
            
            The above example shows returning a single value from the method. There may be times when you would prefer to return multiple values from a method. There
            are three approaches that you can take to accomplish this:
            
            1. Return an array or collection.
            2. Use the ref keyword.
            3. Use the out keyword.
            
            In this first code example, a call to the method ReturnMultiOut is made. The parameters for this method use the out keyword to indicate that values will
            be returned for these parameters. Note that we do not have to call this method with an assignment statement as in the previous method call to
            GetServiceName().
            
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine("{0} {1}", first.ToString(), sValue);
            
            static void ReturnMultiOut(out int i, out string s)
            {
                i = 25;
                s = "using out";
            }
            
            In this code example, the keyword ref is used to return multiple values from the method. Typically the ref keyword requires that the variables being used
            are initialized first.
            
            // Using ref requires that the variables be initialized first.
            sValue = "";
            ReturnMultiRef(ref first, ref sValue);
            Console.WriteLine("{0}, {1}", first.ToString(), sValue);
            
            static void ReturnMultiRef(ref int i, ref string s)
            {
                i = 50;
                s = "using ref";
            }
        */
    }
}
