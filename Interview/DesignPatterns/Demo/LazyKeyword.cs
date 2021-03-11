using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Demo
{
    class LazyKeyword
    {
        private static int counter = 0;
        private static readonly Lazy<LazyKeyword> instance = new Lazy<LazyKeyword>(() => new LazyKeyword()); // Lambda expression

        private LazyKeyword()
        {
            counter++;
            Console.WriteLine("Counter Value {0}", counter);
        }

        public static LazyKeyword GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
