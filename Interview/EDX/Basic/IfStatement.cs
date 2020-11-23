using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Basic
{
    class IfStatement
    {
        /*
            In C#, if statements are concerned with Boolean logic. If the statement is true, the block of code associated with the if statement is executed. If the
            statement is false, control either falls through to the line after the if statement or after the closing curly brace of an if statement block.
            
            The following code sample demonstrates an if statement to determine if a response contains a value of yes.
            
            string response = "yes";
            if (response == "yes")
            {
                // statements that will execute if the value of the response variable is yes, will be placed here.
            }
            
            Note the use of curly braces in the code sample. You can eliminate the curly braces if your statement to execute is a single line statement. C# understands
            that if no curly braces are used, the line immediately after the if (condition) will be executed if the condition is true. Otherwise, it is not.
            To avoid confusion as to which lines will execute for a true condition, a recommended practice is to always use curly braces for your if statement.
            
            In C#, if statements can also have associated else clauses. The else clause executes when the if statement is false. The following code example shows how
            to use an if statement to execute code when a condition is false.
            
            string response;
            if (response == "connection_failed")
            {
                // Block of code executes if the value of the response variable is "connection_failed".
            }
            else
            {
                // Block of code executes if the value of the response variable is not "connection_failed".
            }
            
            if statements can also have associated else if clauses. The clauses are tested in the order that they appear in the code after the if statement. If any of
            the clauses returns true, the block of code associated with that statement is executed and control leaves the block of code associated with the entire if
            construct.
            
            The following code example shows how to use an if statement with an else if clause.
            
            string response;
            if (response == "connection failed")
            {
                // Block of code executes if the value of the response variable is "connection_failed".
            }
            else if (response == "connection_error")
            {
                // Block of code executes if the value of the response variable is "connection_error".
            }
            else
            {
                // Block of code executes if the value of the response variable is neither above responses.
            }
            
            You can create as many else if blocks as necessary for your logic, or until you become completely lost from too many else if clauses. If you require any
            more than five else if clauses, you might want to consider the switch statement.
        */
    }
}
