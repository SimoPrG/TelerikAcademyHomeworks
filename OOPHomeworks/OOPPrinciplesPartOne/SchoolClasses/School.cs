namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<SchoolClass>();
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
                    throw new ArgumentException("Invalid school's name!");
                }
                this.name = value;
            }
        }

        public List<SchoolClass> Classes { get; private set; }

        public SchoolClass SchoolClass { get; set; }

        public void AddClass(SchoolClass schoolClass)
        {
            this.Classes.Add(schoolClass);
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            this.Classes.Remove(schoolClass);
        }

        public string GetClasses(School school)
        {
            var result = new StringBuilder();

            foreach (var schoolClass in Classes)
            {
                result.AppendLine(schoolClass.ToString());
            }

            return result.ToString();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
