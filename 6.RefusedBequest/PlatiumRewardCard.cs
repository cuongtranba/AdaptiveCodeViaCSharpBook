using System;
using FactoryClass;

namespace _6.RefusedBequest
{
    public class PlatiumRewardCard : IRewardCard
    {
        public int RewardPoints
        {
            get;
            private set;
        }
        public void CalculateRewardPoints(decimal transactionAmount, decimal accountBalance)
        {
            RewardPoints += Math.Max((int)decimal.Ceiling((accountBalance /
            PlatinumBalanceCostPerPoint) + (transactionAmount / PlatinumTransactionCostPerPoint)), 0);
        }
        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}
