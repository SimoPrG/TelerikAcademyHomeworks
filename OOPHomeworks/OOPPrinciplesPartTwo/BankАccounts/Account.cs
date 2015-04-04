namespace BankАccounts
{
    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;

        public Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Interest rate cannot be negative!");
                }
                this.interestRate = value;
            }
        }

        public abstract double CalculateInterest(int months);

        public void Deposit(decimal amound)
        {
            this.Balance += amound;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Account type: {1} \nBalance: {2} Interest rate: {3}",
                this.Customer.Name, this.Customer.Type, this.Balance, this.InterestRate);
        }
    }
}
