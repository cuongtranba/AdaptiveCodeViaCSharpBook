using System;
using System.Reflection;

namespace FactoryClass
{
    public class AccountService:IAccountFactory
    {
        public AccountBase CreateAccount(AccountType accountType)
        {
            var currentAssemly = Assembly.GetExecutingAssembly();
            var objectHandle = Activator.CreateInstance("FactoryClass", "FactoryClass.GoldAccount");
            return (AccountBase)objectHandle.Unwrap();
        }
    }
}
