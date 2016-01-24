namespace FactoryClass
{
    public interface IAccountFactory
    {
        AccountBase CreateAccount(AccountType accountType);
    }
}
