namespace FirstBeforeLast
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firsName, string lastName, int age)
        {
            this.firstName = firsName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 120 || value < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("{0} {1} - Age: {2}", this.firstName, this.lastName, this.age);
            return result;
        }
    }
}
