namespace StudentsGroups
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = new List<int>();

        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; private set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; private set; }

        public int GroupNumber { get; set; }

        public void AddMark(int mark)
        {
            if (mark < 2 || mark > 6)
            {
                throw new ArgumentException("Invalid mark.");
            }
            this.Marks.Add(mark);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("{0} {1} FN: {2} Tel: {3}", this.FirstName, this.LastName, this.FN, this.Tel);
            result.AppendFormat("\nEmail: {0} Group: {1}", this.Email, this.GroupNumber);
            result.AppendLine("\nMarks: " + string.Join(", ", this.Marks));

            return result.ToString();
        }
    }
}
