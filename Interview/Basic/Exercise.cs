using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Basic
{
    class Exercise
    {
        public void NewExercise()
        {
            string firstName = "Harsh";
            string lastName = "Sharma";
            DateTime birthDate = new DateTime(1988, 12, 23);
            string addressLine1 = "#20-A";
            string addressLine2 = "Gobindgarh";
            string city = "Jalandhar";
            string state = "Punjab";
            int zip = 144001;
            string country = "India";

            Console.WriteLine("{0} {1} {2}", "My name is", firstName, lastName);
            Console.WriteLine("{0} {1}", "My DOB is", birthDate);
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", "My address is", addressLine1, addressLine2, city, state, zip.ToString(), country);
        }
    }
}
