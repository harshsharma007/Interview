using System;
using System.Collections;

namespace Interview.InterviewQuestionsAsked
{
    class CapacityVsCount
    {
        public CapacityVsCount()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3);
            arrayList.Add("Four");
            arrayList.Add(5);
            arrayList.Add("Six");
            arrayList.Add(7);
            arrayList.Add("Eight");
            arrayList.Add(9);
            arrayList.Add("Ten");

            Console.WriteLine("The Capacity of ArrayList is {0}", arrayList.Capacity);
            Console.WriteLine("The Count of ArrayList is {0}", arrayList.Count);

            /*
                The Capacity of the list represents how much memory the list currently has set aside for the current objects to be added to it. The Count of the list is how many items
                have actually been added to the list.
                
                To understand this, Add only one element to the ArrayList object and then run the output. After running, you will see the Capacity has a value of 8 and Count of 1.
                Now, keep on adding the elements till 8 then the value of Capacity and Count both becomes 8. As soon as, you enter the 9th value the Capacity becomes 16 and the Count
                becomes 9.
            */
        }
    }
}
