using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.OnlineTestQuestions
{
    /*
        Q. To conform to the following interface, which of its members need to be implemented?
        A. Both the firstName and lastName properties need to be implemented.
    */

    interface INameable
    {
        string firstName { get; set; }
        string lastName { get; }
    }

    class WhichOfTheMembersNeedToBeImplemented : INameable
    {
        string INameable.firstName { get; set; }
        string INameable.lastName { get; }
    }
}
