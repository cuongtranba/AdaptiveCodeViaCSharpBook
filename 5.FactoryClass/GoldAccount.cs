using System;

namespace FactoryClass
{
    public class GoldAccount:AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor((amount / GoldBalanceCostPerPoint) + (amount / GoldTransactionCostPerPoint)), 0);
        }

        public override string GetInfo()
        {
            return "Gold Account";
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}
