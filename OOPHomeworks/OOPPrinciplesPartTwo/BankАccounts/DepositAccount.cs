namespace BankАccounts
{
    public class DepositAccount : Account, IWithdrowlable
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return this.InterestRate * months;
        }

        public void Withdrow(decimal amound)
        {
            this.Balance -= amound;
        }
    }
}
