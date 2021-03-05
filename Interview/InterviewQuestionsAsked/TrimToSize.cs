using System;
using System.Collections;
using System.Text;

namespace Interview.InterviewQuestionsAsked
{
    class TrimToSize
    {
        /*
            ArrayList.TrimToSize() method is used to set the capacity to the actual number of elements in the ArrayList. It can be used to minimize a collection's
            memory overhead if no new elements will be added to the collection.
            
            This method is an O(n) operation, where n is count.
        */

        public TrimToSize()
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

            Console.WriteLine("Before trimming the capacity is: {0}", arrayList.Capacity);
            arrayList.TrimToSize();
            Console.WriteLine("After trimming the capacity is: {0}", arrayList.Capacity);
        }
    }
}
