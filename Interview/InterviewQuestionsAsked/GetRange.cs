using System;
using System.Collections;

namespace Interview.InterviewQuestionsAsked
{
    class GetRange
    {
        /*
            The first parameter you pass in the GetRange method is the Index it will start the copy and the second parameter is the number of elements that will be copied.
            
            Assuming that ArrayList contains the following data:
            
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            
            If Index = 5 and Count = 7, it will try to copy the values of the element in the following positions:
            
            5, 6, 7, 8, 9, 10, 11(?)
            
            Since ArrayList only goes up to 10 (as it is zero-based), there isn't any element in position 11. Hence you get the error.
        */

        public GetRange()
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

            ArrayList arrayListGetRange = new ArrayList();
            arrayListGetRange = arrayList.GetRange(2, 7);

            Console.WriteLine("The Content of New GetRange ArrayList is below:");
            foreach (var getRange in arrayListGetRange)
            {
                Console.WriteLine(getRange);
            }
        }
    }
}
