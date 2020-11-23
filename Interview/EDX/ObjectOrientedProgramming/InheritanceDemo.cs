using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class InheritanceDemo
    {
        public void MainTest()
        {
            ManagerClass managerClass = new ManagerClass();
            managerClass.Department = "";
        }
    }

    class EmployeeClass
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
    }

    class ManagerClass : EmployeeClass
    {
        private string department;

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
    }
}
