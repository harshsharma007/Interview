using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Questions
{
    class VariableVsObject
    {
        /*
            Object-oriented programming or OOP, is an approach to problem-solving where all computations are carried out using objects. An object is a component of a program that
            knows how to perform certain actions and how to interact with other elements of the program. Objects are the basic units of object-oriented programming. A simple example
            of an object would be a person. Logically, you would expect a person to have a name. This would be considered a property of the person. You could also expect a person to
            be able to do something, such as walking or driving. This would be considered a method of the person. The code in object-oriented programming is organized around objects.
            Once you have your objects, they can interact with each other to make something happen. Let's say you want to have a program where a person gets into a car and drives it
            from A to B. You would start by describing the objects, such as a person and car. That includes methods: a person knows how to drive a car, and a car knows what it is like
            to be driven. Once you have your objects, you bring them together so the person can get into the car and drive.
            
            Object: As the name object-oriented implies, objects are key to understanding object-oriented technology. You can look around you now and see many examples of real-world
            objects: your dog, your desk, your television set, your bicycle. These real-world objects share two characteristics: they all have state and they all have behavior.
            For example, dogs have state (name, color, breed, hungry) and dogs have behavior (barking, fetching, and slobbering on your newly cleaned slacks). Bicycles have state
            (current gear, current pedal cadence, two wheels, number of gears) and behavior (braking, accelerating, slowing down, changing gears). Software objects are modeled after
            real-world objects in that they, too, have state and behavior. A software object maintains its state in variables and implements its behavior with methods.
            
            Variables: Variables are those quantities whose value can vary during the execution of the program. Variables must be declared in a program before they are used. Variables
            can be declared at the start of any block of code, but most are used at the start of each function. Most local variables are created when the function is called, and
            are destroyed on return from that function. Variables uses the primary storage area. Variables are basically memory locations that are given names and these locations are
            referred to in the program by variable names to read and write data in it. Variables are used for identification for entering the information or data. In variable, you
            can enter an integer value or real or character value (string value) according to the requirement. So we can say that variables are either of integers or float type or
            string type according to the data type used in C++ programming. Variables are used in C++ programs for reading data from the keyboard or from the file, process some
            formula, and printing the information. In C++ language variables have no length for declaration, but some compilers allow either 31 characters or 8 character long variables.
            It contains the name of a valid identifier.
            
            Types of Variables:
            1. External Variables: A variable that is accessible to all of the functions in the file in which it is declared is known as a global variable. However, if a global variable
               has to be accessed by some other file, it has to be declared as an external variable in that file by prefixing its declaration using the keyword extern. The keyword
               extern informs the compiler that the variable is defined in the same file or another file. An external variable remains in existence throughout the life of the program
               and its value is retained between the function calls. In addition, an external variable is automatically initialized to zero.
            
            2. Static Variables: A variable that is recognized only inside the function in which it is declared, but remains in existence throughout the life of the program is known
               as a static variable. A variable is declared static by prefixing its declaration by the keyword static. Both local and global variables can be declared as static.
               When a local variable is declared as static, it is known as a static local variable. A static local variable retains its value between the function calls. Moreover, it
               can be initialized with the constants only at the time of declaration and its value can be changed later at any point within the function. However, it is initialized
               only once, that is, at the time of creation. When a global variable is declared as static, it is known as a static global variable. A static global variable can be
               accessed by all the functions of the program in the same file in which it is declared. However, functions in other files cannot access it. The lifetime and initialization
               of static global variables are the same as that of static local variables.
        */
    }
}
