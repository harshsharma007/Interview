using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Constructor
{
    class StaticConstructorChaining
    {
        public StaticConstructorChaining() : this(10)
        {

        }

        public StaticConstructorChaining(int i)
        {

        }
    }
}
