namespace SchoolClasses
{
    using System;

    public class Student : Person, ICommentable
    {
        private int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.classNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("{0} Class number: {1}", this.Name, this.ClassNumber);
        }
    }
}
