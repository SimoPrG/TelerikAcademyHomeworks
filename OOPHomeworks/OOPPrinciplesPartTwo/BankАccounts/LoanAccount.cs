namespace BankАccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (this.Customer.Type == CustomerType.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                return this.InterestRate * (months - 3);
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                return this.InterestRate * (months - 2);
            }
        }
    }
}
