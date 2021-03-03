using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.LINQ
{
    class SelectVsSelectMany
    {
        /*
            What is the difference between Select and SelectMany?
            Or
            What are the two projection operators available in C#?

            Select and SelectMany are projection operators. A select operator is used to select value from a collection and SelectMany operator is used to select
            values from a collection of collection i.e. nested collection.
            
            Select operator produces one result value for every source value while SelectMany produces a single result that contains a concatenated value for every
            source value. Actually, SelectMany operator flatten IEnumerable<IEnumerable<T>> to IEnumerable<T> i.e. list of list to list.
        */

        public void MainMethod()
        {
            List<Employee> employees = new List<Employee>();
            Employee employeeDeepak = new Employee { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
            Employee employeeKaran = new Employee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };
            Employee employeeLalit = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

            employees.Add(employeeDeepak);
            employees.Add(employeeKaran);
            employees.Add(employeeLalit);

            // Query using Select()
            IEnumerable<List<String>> resultSelect = employees.Select(e => e.Skills);
            Console.WriteLine("***************** Select *****************");

            /*
                Two foreach loops are required to iterate through the results because the query returns a collection of arrays.
            */
            foreach (List<string> skillList in resultSelect)
            {
                foreach (string skill in skillList)
                {
                    Console.WriteLine(skill);
                }
            }

            // Query using SelectMany()

            IEnumerable<string> resultSelectMany = employees.SelectMany(e => e.Skills);
            Console.WriteLine("***************** SelectMany *****************");

            /*
                Only one foreach loop is required to iterate through the results since query returns a one-dimensional collection.
            */
            foreach (string skill in resultSelectMany)
            {
                Console.WriteLine(skill);
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }
    }
}

/*
    Output for both case:
                
    C
    C++
    Java
    SQL Server
    C#
    ASP.NET
    C#
    ASP.NET MVC
    Windows Azure
    SQL Server
*/