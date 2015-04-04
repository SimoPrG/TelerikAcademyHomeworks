namespace PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name) 
        {
            this.Name = name;
        }

        public Person(string name, int? age) : this(name)
        {
            this.Age = age;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }

        public int? Age 
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Invalid age!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1}", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());
        }
    }
}
