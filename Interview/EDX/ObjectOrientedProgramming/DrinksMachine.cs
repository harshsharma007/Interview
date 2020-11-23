using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    /*
        Encapsulation can have a couple of meanings depending on how you look at it. It could be simply meaning that all we're going to ensure we encapsulate
        or include all of our behaviors and attributes of our class in one structure or it could also simply mean that through encapsulation we are going to perform
        what's known as "data hiding".
            
        So let's take a look at the concept of data hiding and what that specifically means.
        
        It's not a good idea to use public member variables, and the reason being is because users of our class can access it directly, change the values, and bypass
        maybe some functionality that you want to use to verify that the information coming in is actually valid.
        
        So instead what you should be doing is you should be using properties to basically encompass the accessibility of your member variables.
    */

    class DrinksMachine
    {
        public DrinksMachine(string location, string make, string model)
        {
            /*
                Even in the constructor of our class, go through the process of accessing a private member variable, we're bypassing any validation checks we may have
                written in those properties.
            */
            this.Location = location;
            this.Make = make;
            this.Model = model;
        }

        // The following statements declare private member variables
        private string _location;
        private string _make;
        private string _model;

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        // The following statements declare public methods
        public void MakeCappuccino()
        {
            // Method logic goes here
            Console.WriteLine("Cappuccino is made.");
        }

        public void MakeEspresso()
        {
            // Method logic goes here
        }
    }
}
