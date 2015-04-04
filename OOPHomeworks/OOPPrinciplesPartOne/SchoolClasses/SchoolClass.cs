namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass : ICommentable
    {
        private string identifier;

        public SchoolClass(string identifier)
        {
            this.identifier = identifier;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }


        public string Identifier 
        {
            get
            {
                return this.identifier;
            }
        }

        public List<Student> Students { get; private set; }

        public List<Teacher> Teachers { get; private set; }

        public string Comment { get; set; }

        public Person Person { get; set; }

        public void AddStudents(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudents(Student student)
        {
            this.Students.Remove(student);
        }

        public string GetStudents()
        {
            var result = new StringBuilder();

            foreach (var student in this.Students)
            {
                result.AppendLine(student.ToString());
            }
            return result.ToString();
        }

        public void AddTeachers(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeachers(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }
        
        public string GetTeachers()
        {
            var result = new StringBuilder();

            foreach (var teacher in this.Teachers)
            {
                result.AppendLine(teacher.ToString());
            }
            return result.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}", this.identifier);
        }
    }
}
