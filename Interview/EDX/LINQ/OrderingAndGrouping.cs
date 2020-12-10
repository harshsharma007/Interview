using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.LINQ
{
    class OrderingAndGrouping
    {
        /*
            Grouping Data
            The following code example shows how to use a group clause to group the returned employees by their Job Title ID.
            
            // Using a group Clause
            var employee = from e in Employees group e by e.JobTitle into eGroup select new { Job = eGroup.Key, Names = eGroup };
            
            Aggregating Data
            The following code example shows how to use a group clause with an aggregate function to count the number of employees with each job title.
            
            // Using a group Clause with an Aggregate Function
            var employee = from e in Employees group e by e.JobTitle into eGroup select new { Job = eGroup.Key, CountOfEmployees = eGroup.Count() };
            
            Navigating Data
            The following code example shows how to use navigation properties to retrieve data from the Employees entity and the related JobTitles entity.
            
            // Using Dot Notation to Navigate Related Entities
            var employee = from e in Employees
            select new
            {
                FirstName = e.FirstName, LastName = e.LastName, Job = e.JobTitle1.Job
            };
        */
    }
}
