using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Demo
{
    class EagerLoading
    {
        /*
            In order to achieve Eager Loading, we need to follow below steps:
            - We need to change the null initialization to new Singleton instance.
            - We need to change the instance property to readonly.
            - We need to remove the lock chek also, as it is no longer required.
            
            When we run the code below, the runtime will hit the GetInstance property twice due to parallel invoke. But, if you observe the output the counter value
            is still at 1. This proves that Eager Loading has created only one singleton instance.
            
            But you can think of, is this code thread safe?
            To answer that, the Common Language Runtime takes care of the variable initialization and it's thread safety. Hence we don't need to write any explicit
            code for thread safety.
        */

        private static int counter = 0;
        private static readonly EagerLoading instance = new EagerLoading();

        private EagerLoading()
        {
            counter++;
            Console.WriteLine("Counter Value {0}", counter++);
        }

        public static EagerLoading GetInstance
        {
            get
            {
                return instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
