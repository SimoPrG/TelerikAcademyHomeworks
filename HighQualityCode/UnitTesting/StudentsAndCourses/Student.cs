namespace School
{
    using System;

    using System.Collections.Generic;

    public class Student
    {
        private string name;

        private int number;

        private ICollection<Course> courses;

        public Student(string name)
        {
            this.Name = name;
            this.number = School.UniqueNumber++;
            this.courses = new List<Course>();
        }

        public string Name
        {
            get
            {
                return this.name; 
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The student's name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        } 

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot" + " be null");
            }

            this.courses.Add(course);

            if (!course.StudentsList.Contains(this))
            {
                course.AddStudent(this);
            }
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot" + " be null");
            }

            this.courses.Remove(course);

            if (course.StudentsList.Contains(this))
            {
                course.RemoveStudent(this);
            }
        }
    }
}
