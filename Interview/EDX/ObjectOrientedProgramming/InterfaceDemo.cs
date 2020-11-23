using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    interface ILoyaltyCardHolderNew
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }

    class InterfaceDemo : ILoyaltyCardHolderNew
    {
        private int totalPoints;
        public int TotalPoints
        {
            get
            {
                return totalPoints;
            }
        }

        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }

        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }
}
