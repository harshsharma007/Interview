using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.EventsAndDelegates
{
    class RaisingEvents
    {
        /*
            Raising Events
            After you have defined an event and a delegate, you can write code that raises the event when certain conditions are met. When you raise the event, the delegate associated
            with your event will invoke any event handler methods that have subscribed to your event.
            
            To raise an event, you need to do two things:
            1. Check whether the event is null. The event will be null if no code is currently subscribing to it.
            2. Invoke the event and provide arguments to the delegate.
            
            For example, suppose a Coffee struct includes a method named MakeCoffee. Every time you call the MakeCoffee method, the method reduces the stock level of the Coffee
            instance. If the stock level drops below a certain point, the MakeCoffee method will raise an OutOfBeans event.
            
            The following example shows how to raise an event:
        */
    }

    // Raising an Event
    public struct NewCoffee
    {
        // Declare the event and the delegate
        public EventArgs e;
        public delegate void OutOfBeansHandler(NewCoffee coffee, EventArgs args);
        public event OutOfBeansHandler OutOfBeans;
        int currentStockLevel, minimumStockLevel;

        public void MakeCoffee()
        {
            minimumStockLevel = 1;

            // Decrement the stock level
            currentStockLevel--;

            // If the stock level drops below the minimum, raise the event
            if (currentStockLevel < minimumStockLevel)
            {
                // Check whether the event is null
                if (OutOfBeans != null)
                {
                    // Raise the event
                    OutOfBeans(this, e);
                }
            }
        }
    }

    /*
        To raise the event, you use a similar syntax to calling a method. You provide arguments to match the parameters required by the delegate. The first argument is the object
        that raised the event. Note how the this keyword is used to indicate the current Coffee instance. The second parameter is the EventArgs instance, which can be null if you
        do not need to provide any other information to subscribers.
    */
}
