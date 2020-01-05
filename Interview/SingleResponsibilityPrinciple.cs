using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    class SingleResponsibilityPrinciple
    {
        //SRP says "Every software module should have only one reason to change."
        //This means that every class, or similar structure, in your code should have only one job to do. Everything in that class should be related to a single purpose.
        //Our class should not be like a Swiss knife wherein if one of them needs to be changed then the entire tool needs to be altered.
        //It does not mean that your classes should only contain one method or property.
        //There may be many members as long as they relate to the single responsibility.
    }

    class UserService
    {
        //This class looks fine, but ValidateEmail and SendEmail methods have nothing to do within this class. So, it is not following SRP.
        public void RegisterUser(string email, string password)
        {
            //Register a user.
        }

        public bool ValidateEmail(string email)
        {
            //After validating an email.
            return true;
        }

        public bool SendEmail(string email)
        {
            //After sending an email.
            return true;
        }
    }

    class NewUserService
    {
        public void RegisterUser(string email, string password)
        {
            //Register a user.
        }
    }

    class EmailService
    {
        public bool ValidateEmail(string email)
        {
            //After validating an email.
            return true;
        }

        public bool SendEmail(string email)
        {
            //After sending an email.
            return true;
        }
    }
}
