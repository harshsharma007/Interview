using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Keywords
{
    class DefaultKeyword
    {
        /*
            The default keyword is contextual since it has multiple usages. For reference types this is null and for value types this a new instance all zero'd out.    
            Here are some examples to demonstrate:
        */

        public DefaultKeyword()
        {
            Console.WriteLine(default(Int32));      // Prints "0"
            Console.WriteLine(default(Boolean));    // Prints "False"
            Console.WriteLine(default(String));     // Prints nothing (because it is null)
        }

        /*
            You can use default to obtain the default value of a Generic Type as well.
            
            public T Foo()
            {
                .
                .
                return default(T);
            }
        */
    }
}
