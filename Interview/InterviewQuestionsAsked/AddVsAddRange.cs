using System;
using System.Collections;

namespace Interview.InterviewQuestionsAsked
{
    class AddVsAddRange
    {
        /*
            Add is used to add the item into a collection one by one whereas AddRange is used to add the bulk item into another collection.
        */

        public AddVsAddRange()
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

            ArrayList arrayListAddRange = new ArrayList();
            arrayListAddRange.AddRange(arrayList);
        }
    }
}
