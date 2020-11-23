using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class PrivatePublicProtectedInternal
    {
        /*
            Which access modifier is the default modifier applied to class members, if you don't explicitly specify one?
            private
        */

        /*
            Private vs Public vs Protected vs Internal
            The following table discusses the access modifiers that can be applied to class members to control how they can be accessed by other code in the application.
            This is a part of encapsulation by allowing you to restrict access to members where it makes sense.

            +-----------------------+----------------------------------------------------------------------------------------------------------------------+
            |                       |                                                                                                                      |
            |       public          | The type is available to code running in any assembly that references the assembly in which the class is contained.  |
            |                       |                                                                                                                      |
            +-----------------------+----------------------------------------------------------------------------------------------------------------------+
            |                       |                                                                                                                      |
            |       internal        | The type is available to any code within the same assembly, but not available to code in another assembly.           |
            |                       |                                                                                                                      |
            +-----------------------+----------------------------------------------------------------------------------------------------------------------+
            |                       |                                                                                                                      |
            |       private         | The type is only available to code within the class that contains it. You can only use the private access modifier   |
            |                       | with nested classes. This is the default value if you do not specify an access modifier.                             |
            |                       |                                                                                                                      |
            +-----------------------+----------------------------------------------------------------------------------------------------------------------+
            |                       |                                                                                                                      |
            |       protected       | The type is only accessible within its class and by derived class instances.                                         |
            |                       |                                                                                                                      |
            +-----------------------+----------------------------------------------------------------------------------------------------------------------+

            The tradition is to create private data fields in the class to prevent direct manipulation of the values for those fields, and expose properties to provide
            access to the values indirectly. The properties are known as accessors or getters and setters.
        */
    }
}
