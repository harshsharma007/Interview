using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class Inheritance
    {
        /*
            Introducing Inheritance
            Inheritance is yet another pillar in the world of object-oriented programming. You can use inheritance as an aspect of code reuse by defining different
            classes that will contain common features and have a relationship to one another. An example could be employees as a general classification and which could
            contain managers, non-management workers, and any other employee classification.
            
            Consider creating an application to stimulate an office workspace that includes all the employees. Then consider the common features that all employee
            classifications have followed by a list of attributes that are different for each employee type. For example, they all might have an employee number, first
            and last names, addresses etc, but managers have different responsibilities than other employee classifications.
            
            Inheritance allows you to create a base class containing the core, shared attributes, and then each different class of employee would inherit these attributes
            whole extending them for their own special needs. The class that inherits from the base class is referred to as the derived class but also commonly
            referred to as a subclass. When using the term subclass, some also refer to the base class as a super class. In programming language such as Objective-C,
            this is reinforced by the use of statements such like this example where the keyword super is used to initialize a nib file in a super class;
            
            self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
            
            Consider the following simplified UML Class diagram as an example:
            
                                                            +------------------------+
                                                            |       Employee         |
                                                            +------------------------+
                                                            |   -EmpNumber           |
                                            +-------------->|   -FirstName           |<----------------+
                                            |               |   -LastName            |                 |
                                            |               |   -Address             |                 |
                                            |               +------------------------+                 |
                                            |                                                          |
                                            |                                                          |
                                +------------------------+                                  +------------------------+
                                |       Manager          |                                  |       Programmer       |
                                +------------------------+                                  +------------------------+
                                |   -PayRateIndicator    |                                  |   -PayRateIndicator    |
                                |   -Employees[]         |                                  |   -Qualifications      |
                                +------------------------+                                  +------------------------+
        */
    }
}
