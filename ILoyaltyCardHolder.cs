namespace Module6Assignment
{
    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}