using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.OnlineTestQuestions
{
    class ThrowExceptionVsThrowClause
    {
        /*
            What is the difference between throw exception vs throw?
            Yes, there is a difference:
            - throw ex resets the stack trace (so your errors would appear to originate from HandleException)
            - throw doesn't - the original offender would be preserved.
        */

        public void MainMethod()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        public void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                // throw ex, resets the stack trace coming from Method1 and propogates it to the caller (MainMethod)
                throw ex;
            }
        }

        public void Method1()
        {
            try
            {
                throw new Exception("Inside Method1");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    /*
        Another example
    */

    class AnotherThrowExceptionVsThrowClause
    {
        public void MainMethod()
        {
            try
            {
                ThrowException1(); // Line 19
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception 1:");
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                ThrowException2(); // Line 25
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception 2:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ThrowException1()
        {
            try
            {
                DivideByZero(); // Line 34
            }
            catch
            {
                throw; // Line 36
            }
        }

        public void ThrowException2()
        {
            try
            {
                DivideByZero(); // Line 41
            }
            catch (Exception ex)
            {
                throw ex; // Line 43
            }
        }

        public void DivideByZero()
        {
            int x = 0;
            int y = 1 / x; // Line 49
        }

        /*
            Output:
            Exception 1:
                at Interview.Program.DivideByZero() in <snip>\Dev\UnitTester\Program.cs:line 49
                at Interview.Program.ThrowException1() in <snip>\Dev\UnitTester\Program.cs:line 36
                at Interview.Program.TestExceptions() in <snip>\Dev\UnitTester\Program.cs:line 19
            
            Exception 2:
                at Interview.Program.ThrowException2() in <snip>\Dev\UnitTester\Program.cs:line 43
                at Interview.Program.TestExceptions() in <snip>\Dev\UnitTester\Program.cs:line 25
            
            You can see that in Exception 1, the stack trace goes back to the DivideByZero() method, whereas in Exception 2 it does not.
            
            Note:
            The line number shown in ThrowException1() and ThrowException2() is the line number of the throw statement, not the line number of the call to DivideByZero(),
            which probably makes sense now.
            
            
            Output in Release Mode:
            Exception 1:
                at ConsoleAppBasics.Program.ThrowException1()
                at ConsoleAppBasics.Program.Main(String[] args)
            
            Exception 2:
                at ConsoleAppBasics.Program.ThrowException2()
                at ConsoleAppBasics.Program.Main(String[] args)
            
            Is it maintains the original stackTrace in debug mode only?
        */
    }
}
