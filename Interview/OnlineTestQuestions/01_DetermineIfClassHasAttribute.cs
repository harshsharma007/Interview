using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.OnlineTestQuestions
{
    class DetermineIfClassHasAttribute
    {
        /*
            Q. How would you determine if a class has a perticular attribute?
            A. Attribute.GetCustomAttribute(typeof(ScheduleController), typeof(SubControllerActionToViewDataAttribute))
               isn't null (Assert.IsNotNull or similar)
               The reason I use this rather than IsDefined is that most times I want to validate some properties of the attribute too.
        */
    }
}
