using System;
using System.Collections.Generic;
using System.Text;
using Interview.EDX.Collections;

namespace Interview.EDX.EventsAndDelegates
{
    class HandlingEvents
    {
        /*
            Handling Events
            
            Subscribing to Events
            
            If you want to handle an event in client code, you need to do two things:
            1. Create a method with a signature that matches the delegate for the event.
            2. Use the addition assignment operator (+=) to attach your event handler method to the event.
            
            For example, suppose you have created an instance of the Coffee struct named coffee1. In your Inventory class, you want to subscribe to the OutOfBeans that may be raised
            by coffee1.
            
            Note: The previous topic shows how the Coffee struct, the OutOfBeans event, and the OutOfBeansHandler delegate are defined.
            
            The following example shows how to subscribe to an event:
        */
    }

    // Subscribing to an Event
    public class Inventory
    {
        internal void HandleOutOfBeans(Collections.Coffee sender, EventArgs args)
        {
            string coffeeBean = sender.Bean;
            Console.WriteLine(coffeeBean);
            // Reorder the coffee bean
        }

        public void SubscribeToEvent()
        {
            // coffee1.OutOfBeans += HandleOutOfBeans;
        }

        /*
            In this example, the signature of the HandleOutOfBeans method matches the delegate for the OutOfBeans event. When you call the SubscribeToEvent method, the
            HandleOutOfBeans method is added to the list of subscribers for the OutOfBeans event on the coffee1 object.
        
            To unsubscribe from an event, you use the substraction assignment operator (-+) to remove your event handler method from the event.
            The following exmaple shows how to unsubscribe from an event:
        */

        // Unsubscribing from an Event
        public void UnsubscribeFromEvent()
        {
            // coffee1.OutOfBeans -= HandleOutOfBeans;
        }
    }
}
