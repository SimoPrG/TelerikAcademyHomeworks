namespace BankАccounts
{
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private string name;
        private List<Account> accounts;

        public Bank(string name)
        {
            this.Name = name;
            this.accounts = new List<Account>();
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid bank's name!");
                }
                this.name = value;
            }
        }

        public List<Account> Accounts 
        {
            get { return this.accounts; }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var account in accounts)
            {
                result.AppendLine(account.ToString());
                result.AppendLine(new string('-', 40));
            }

            return result.ToString();
        }
    }
}
