namespace BankАccounts
{
    public class Customer
    {
        private string name;
        private CustomerType type;

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.type = type;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid customer's name!");
                }
                this.name = value;
            }
        }

        public CustomerType Type 
        {
            get { return this.type; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Type: {1}", this.Name, this.Type);
        }
    }
}
