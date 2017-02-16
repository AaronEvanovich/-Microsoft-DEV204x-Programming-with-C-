using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_practice
{
    interface ILoyaltyCard //interface naming convention: starts with "I"
    {
        int TotalPoints { get; } //interface: a "contract" without specifying the content
        int AddPoints(decimal inp); //content specified in class
        void ResetPoints();
    }
    class Customer : ILoyaltyCard 
    {
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
