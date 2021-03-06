﻿using System;

namespace _4.FactoryMethod
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
