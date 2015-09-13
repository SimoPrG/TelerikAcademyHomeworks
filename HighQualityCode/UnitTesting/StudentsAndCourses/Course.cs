namespace School
{
    using System;

    using System.Collections.Generic;

    public class Course
    {
        private ICollection<Student> studentsList;

        private string title;

        public Course(string title)
        {
            this.Title = title;
            this.studentsList = new List<Student>();
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course title cannot be null or empty");
                }
                this.title = value;
            }
        }

        public ICollection<Student> StudentsList
        {
            get
            {
                return new List<Student>(this.studentsList);
            }
        }
        
        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            if (this.studentsList.Count < 29)
            {
                if (this.studentsList.Contains(student))
                {
                    throw new ApplicationException("The same student cannot be added more than once");
                }
                this.studentsList.Add(student);
                student.AddCourse(this);
                return;
            }

            throw new ApplicationException("Students in a class must be less than 30");
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null");
            }

            this.studentsList.Remove(student);
            student.RemoveCourse(this);
        }
    }
}
