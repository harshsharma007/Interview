using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.EventsAndDelegates
{
    class CreatingEventsAndDelegates
    {
        /*
            Creating Events and Delegates
            When you create an event in a struct or a class, you need a way of enabling other code to subscribe to your event. In Visual C#, you accomplish this by creating a delegate.
            Once again, a delegate is a special type that defines a method signature; in other words, the return type and the parameters of a method. As the name suggests, a delegate
            behaves like a representative for methods with matching signatures.
            
            When you define an event, you associate a delegate with you event. To subscribe to the event from client code, you need to:
            1. Create a method with a signature that matches the event delegate. This method is known as the event handler.
            2. Subscribe to the event by giving the name of your event handler method to the event publisher, in other words, the object that will raise the event.
            
            When the event is raised, the delegate invokes all the event handler methods that have subscribed to the event.
            
            Suppose you create a struct named Coffee. One of the responsibilities of this struct is keep track of the stock level for each Coffee instance. When the stock level
            drops below a certain point, you might want to raise an event to warn an ordering system that you are running out of beans.
            
            The first thing you need to do is to define a delegate. To define a delegate, you use the delegate keyword. A delegate includes two parameters:
            1. The first parameter is the object that raised the event - in this case, a Coffee instance.
            2. The second parameter is the event arguments - in other words, any other information that you want to provide to consumers. This must be an instance of the EventArgs
               class, or an instance of a class that derives from EventArgs.
            
            Next, you need to define the event. To define an event, you use the event keyword. You precede the name of your event with the name of the delegate you want to associate
            with your event.
            
            The following example shows how to define delegates and events:
        */
    }

    // Defining a Delegate and an Event
    public struct Coffee
    {
        public EventArgs e;
        public delegate void OutOfBeansHandler(Coffee coffee, EventArgs args);
        public event OutOfBeansHandler OutOfBeans;
    }

    /*
        In this example, you define an event named OutOfBeans. You associate a delegate named OutOfBeansHandler with your event. The OutOfBeansHandler delegate takes two parameters,
        an instance of Coffee that will represent the object that raised the event and an instance of EventArgs that could be used to provide more information about the event.
    */
}
