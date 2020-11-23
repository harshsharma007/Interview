using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class ApplyingInheritance
    {
        /*
            Applying Inheritance
            The C# programming language does not support multiple inheritance directly. Multiple inheritance is a concept whereby multiple base classes can be
            inherited by a single subclass. In C#, a derived class can only have one base class.
            
            To inherit from base class in C#, you append your derived class name with a colon and the name of the base class. The following example demonstrates the
            Manager class inheriting the Employee base class from the previous topic's UML diagram.
        */
    }

    class Manager : Employee
    {
        private char payRateIndicator;
        private Employee[] emps;
    }

    /*
        This simple class definition in C# lists the keyword class followed by the class name Manager, a colon and then the name of the base class Employee. Looking
        at this snippet we can't tell what the Manager class has inherited from Employee so we would need to look at that class as well to understand all the properties
        available for us. The Employee class is shown here:
    */

    class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string EmpNumber
        {
            get
            {
                return empNumber;
            }
            set
            {
                empNumber = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        /*
            When working in Visual Studio, the Intellisense feature will provide you with a visual representation of the inherited members. As an example, if we were
            to instantiate an object of type Manager in our code and then use the dot notation to bring up the list of properties for the Manager class, we would
            also see the properties from the base class Employee in that list as well.
        */

        public void MethodMain()
        {
            Manager leadManager = new Manager();
            leadManager.Address = "";
        }
    }
}
