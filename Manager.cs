using System;

namespace Module6Assignment
{
    public class Manager : Employee, ILoyaltyCardHolder
    {
        private string department;

        public string Department
        {
            get => department;
            set => department = value;
        }

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

        public override void Login()
        {
            Console.WriteLine("Manager login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }
    }
}