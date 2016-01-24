using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountFactory accountFactory=new AccountService();
            var account= accountFactory.CreateAccount(AccountType.Gold);
            Console.WriteLine(account.GetInfo());
        }
    }

}
