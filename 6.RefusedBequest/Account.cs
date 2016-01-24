using FactoryClass;

namespace _6.RefusedBequest
{
    public class Account
    {
        private readonly IRewardCard rewardCard;
        public decimal AccountBalance { get; set; }

        public Account(IRewardCard rewardCard)
        {
            this.rewardCard = rewardCard;
        }

        public void AddTransaction(decimal amount)
        {
            rewardCard.CalculateRewardPoints(amount,AccountBalance);
            AccountBalance += amount;
        }
    }
}
