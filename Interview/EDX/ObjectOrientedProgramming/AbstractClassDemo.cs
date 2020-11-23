using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class AbstractClassDemo
    {
    }

    abstract class EmployeeAbstractClass
    {
        public virtual void Login()
        {
            Console.WriteLine("Employee Login");
        }

        public abstract void Hire();

        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;
    }

    class ManagerAbstractClass : EmployeeAbstractClass
    {
        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire Someone");
        }
    }
}
