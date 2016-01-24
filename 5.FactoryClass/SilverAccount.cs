using System;

namespace FactoryClass
{
    public class SilverAccount:AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int) decimal.Floor(amount/SilverTransactionCostPerPoint), 0);
        }

        public override string GetInfo()
        {
            return "Silver account";
        }

        private const int SilverTransactionCostPerPoint = 10;
    }

}
