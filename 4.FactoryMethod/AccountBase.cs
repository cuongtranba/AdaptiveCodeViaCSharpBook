namespace _4.FactoryMethod
{
    public abstract class AccountBase
    {
        public decimal Balance { get; private set; }
        public int RewardPoints { get; private set; }

        public static AccountBase CreateAccount(AccountType type)
        {
            AccountBase account = null;
            switch (type)
            {
                case AccountType.Silver:
                    account = new SilverAccount();
                    break;
                case AccountType.Gold:
                    account=new GoldAccount();
                    break;
                case AccountType.Platinum:
                    account=new PlatinumAccount();
                    break;
            }
            return account;
        }

        public void AddTransaction(decimal amount)
        {
            RewardPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }

        public abstract int CalculateRewardPoints(decimal amount);

    }
}
