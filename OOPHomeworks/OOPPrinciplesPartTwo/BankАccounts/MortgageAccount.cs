namespace BankАccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (this.Customer.Type == CustomerType.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                return this.InterestRate * (months - 6);
            }

            else
            {
                if (months <= 12)
                {
                    return (this.InterestRate * months) / 2;
                }
                return ((this.InterestRate * months) / 2) + (this.InterestRate * (months - 12));
            }
        }
    }
}
