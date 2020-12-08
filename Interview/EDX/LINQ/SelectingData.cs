using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.LINQ
{
    class SelectingData
    {
        /*
            Selecting Data
            The following code example shows how to use a simple select clause to return all of the data in a single entity.
            
            // Using a select clause
            IQueryable<Employee> employee = from e in Employees select e;
            
            The return data type from the query is an IQueryable<Employee>, enabling you to iterate through the data that is required.
            
            Filtering Data By Row
            The following code example shows how to use the where keyword to filter the returned data by row to contain only employees with a last name of Prescott.
            
            // Using a where clause
            string _LastName = "Prescott";
            IQueryable<Employee> employee = from e in Employees where e.LastName == _LastName select e;
            
            Filtering Data by Column
            The following code example shows how to declare a new type in which to store a subset of columns that the query returns; in this case, just the FirstName and LastName
            properties of the Employee entity.
            
            // Using a New Class to Return a Subset of Columns
            private class FullName
            {
                public string Forename { get; set; }
                public string Surname { get; set; }
            }
            
            private void FilteringDataByColumn()
            {
                IQueryable<Fullname> names = from e in Employees select new Fullname { Forename = e.FirstName, Surname = e.LastName };
            }
            
            Working with the Results
            To then work with the data that is returned from any of these queries, you use dot notation to access the properties of the members of the IQueryable<> type, as the
            following code example shows.
            
            // Accessing the Returned Data
            foreach (var emp in emps)
            {
                Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);
            }
        */
    }
}
