namespace SchoolClasses
{
    using System;

    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
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
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }
    }
}
