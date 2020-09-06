using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.SOLID_Principles
{
    class InterfaceSegregationPrinciple
    {
        /*
            The interface segregation states "that clients should not be forced to implement interfaces they don't use. Instead of one fat interface many small
            interfaces are preferred based on groups of methods, each one serving one sub module."
        */
    }

    public interface IProgrammer
    {
        void WorkOnTask();
    }

    public interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {

        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {

        }

        public void CreateSubTask()
        {

        }
    }

    public class TeamLead : IProgrammer, ILead
    {
        public void WorkOnTask()
        {

        }

        public void AssignTask()
        {

        }

        public void CreateSubTask()
        {

        }
    }
}
