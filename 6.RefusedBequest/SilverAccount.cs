using System;

namespace _6.RefusedBequest
{
    public class SilverAccount:IRewardCard
    {
        private const int SilverTransactionCostPerPoint = 10;
        public int RewardPoints { get; private set; }

        public void CalculateRewardPoints(decimal transactionAmount, decimal accountBalance)
        {
            RewardPoints+= Math.Max((int)decimal.Floor(transactionAmount / SilverTransactionCostPerPoint), 0);
        }
    }

}
