using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCodeViaCSharp
{
    public class Account
    {
        private readonly AccountType type;
        public decimal Balance { get; set; }
        public int RewardPoints { get; set; }
        public Account(AccountType type)
        {
            this.type = type;
        }

        public void AddTransaction(decimal amount)
        {
            RewardPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }

        public int CalculateRewardPoints(decimal amount)
        {
            int points;
            switch (type)
            {
                case AccountType.Silver:
                    points = (int)decimal.Floor(amount / 10);
                    break;
                case AccountType.Gold:
                    points = (int)decimal.Ceiling((Balance / 10000 * 5) + (amount / 5));
                    break;
                case AccountType.Platinum:
                    points = (int)decimal.Ceiling((Balance / 10000 * 10) + (amount / 2));
                    break;
                default:
                    points = 0;
                    break;
            }
            return Math.Max(points, 0);
        }
    }

    public enum AccountType
    {
        Silver, Gold, Platinum
    }
}
