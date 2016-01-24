using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PlatinumAccount:AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int) decimal.Floor((amount/GoldBalanceCostPerPoint) + (amount/GoldTransactionCostPerPoint)) , 0);
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}
