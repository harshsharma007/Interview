using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.DesignPatterns.Kudvenkat
{
    class H08_FactoryDesignPatternIntroduction
    {
        /*
            Gang of Four Definition
            "Define an interface for creating an object, but let subclasses decide which class to instantiate. The Factory method lets a class defer instantiation it
            uses to subclasses".
            
            Factory pattern is one of the most used design patterns in real world applications. Factory pattern creates object without exposing the creation logic to
            the client and refer to newly created object using a common interface.
            
            +-------------+     uses      +-------------+   creates     +-------------+
            |   Client    |-------------->|   Factory   |-------------->|   Product   |
            +-------------+               +-------------+               +-------------+
            
            Implementation Guidelines
            Choose Factory Pattern when
            - The Object needs to be extended to subclasses
            - The Classes doesn't know what exact sub-classes it has to create
            - The Product implementation tend to change over time and the Client remains unchanged
            
            Business Requirement (Simple Factory Example)
            Differentiate employees as permanent and contract and segregate their pay scales as well as bonus based on their employee types.
            (See FactoryDesignPatternIntroduction project).
            
            Simple Factory Representation
            
            +-------------+     uses      +-------------+   creates     +-------------+
            |   Client    |-------------->|   Factory   |-------------->|   Product   |
            +-------------+               +-------------+               +-------------+
                                                +---+
                                                |   |
                                                |   |
                                                |   |
                                               _|   |_
                                               \     /
                                                \   /                                                                     +-----------+
                                                 \ /                                                        +------------>| Permanent |
            +---------------------+ Uses  +--------------------------+  Creates   +-----------+             |             +-----------+
            | Employee Controller |------>| Employee Manager Factory |----------->| IEmployee |-------------|
            +---------------------+       +--------------------------+            +-----------+             |             +-----------+
                                                                                                            +------------>| Contract  |
                                                                                                                          +-----------+
        */
    }
}
