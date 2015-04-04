namespace AnimalHierarchy
{
    using System;

    public class Animal
    {
        private string name;
        private byte age;
        private Sex sex;

        public Animal(string name, byte age, Sex sex)
        {
           this.Name = name;
           this.Age = age;
           this.Sex = sex;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }

        public byte Age
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

        public Sex Sex 
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1} Sex: {2}", this.Name, this.Age, this.sex);
        }
    }
}
