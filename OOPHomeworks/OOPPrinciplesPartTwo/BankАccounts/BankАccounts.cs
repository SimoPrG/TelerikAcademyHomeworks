namespace BankАccounts
{
    using System;
    using System.Collections.Generic;

    public class BankАccounts
    {
        static void Main()
        {
            Account ivanIvanov = new DepositAccount(new Customer("Ivan Ivanov", CustomerType.Individual), 1458.26M, 7.8);
            Account peshoPeshov = new MortgageAccount(new Customer("Pesho Peshov", CustomerType.Company), 17895.89M, 13.3);
            Account draganDraganov = new LoanAccount(new Customer("Dragan Draganov", CustomerType.Individual), 7895.24M, 5.35);

            var betaBank = new Bank("Beta Bank");

            betaBank.AddAccount(ivanIvanov);
            betaBank.AddAccount(draganDraganov);
            betaBank.AddAccount(peshoPeshov);

            Console.WriteLine(betaBank);

            foreach (var account in betaBank.Accounts)
            {
                Console.WriteLine("{0} \nInterest amound for 5 months: {1}", account, account.CalculateInterest(5));
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
