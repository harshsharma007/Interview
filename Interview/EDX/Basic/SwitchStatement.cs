using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class SwitchStatement
    {
        /*
            If there are too many else if statements, code can become messy and difficult to follow. In this scenario, a better solution is to use a switch statement.
            The switch statement simply replaces multiple else if statements. The following sample shows how you can use a switch statement to replace a collection of
            else if clauses.
            
            string response;
            switch (response)
            {
                case "connection_failed":
                    // Block of code executes if the value of response is "connection_failed".
                    break;
                case "connection_success":
                    // Block of code executes if the value of response is "connection_success".
                    break;
                case "connection_error":
                    // Block of code executes if the value of response is "connection_error".
                    break;
                default:
                    // Block executes if none of the above conditions are met.
                    break;
            }
            
            Notice that there is a block labeled default:. This block of code will execute when none of the other blocks match. In each case statement, notice the
            break keyword. This causes control to jump to the end of the swtich after processing the block of code. If you omit the break keyword, your code will not
            compile. If you want to handle multiple cases with the same code segment, you can use a fall-through setup similar to this sample code.
            
            string response;
            switch (response)
            {
                case "connection_success":
                    // Block of code executes if the value of response is "connection_success".
                    break;
                case "connection_failed":
                case "connection_error":
                    // Block of code executes if the value of response is "connection_failed" or "connection_error;
                    break;
                default:
                    // Block executes if none of the above conditions are met.
                    break;
            }
            
            If you are coming from another programming language, such as C, that also uses the switch statement, you might notice that in the C# language, you can use
            string values in your switch statements and don't have to use integers or enumerated types. C# swtich statements support the following data types as
            expressions:
            - sbyte
            - byte
            - short
            - ushort
            - int
            - uint
            - long
            - ulong
            - char
            - string
            - enumerations
        */
    }
}
