namespace StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permAddres;
        private string mobilePhone;
        private string email;
        private byte course;

        public Student()
        {

        }

        public Student(string firstName, string middleNmae, string lastName,
            string ssn, string permAddres, string mobilePhone, string email, byte course, 
            University university, Specialty specialty, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleNmae;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermAddres = permAddres;
            this.MobileNumber = mobilePhone;
            this.Email = email;
            this.Course = course;

        }

        public string FirstName 
        {
            get { return this.firstName; }
            private set 
            {
                CheckName(value);
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                CheckName(value);
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                CheckName(value);
                this.lastName = value;
            }
        }

        public string SSN 
        {
            get { return this.ssn; }
            private set
            {
                if (value.Length != 6)
                {
                    throw new System.ArgumentException("Invalid SSN!");
                }
                this.ssn = value;
            }
        }

        public string PermAddres
        {
            get { return this.permAddres; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid addres!");
                }
                this.permAddres = value;
            }
        }

        public string MobileNumber
        {
            get { return this.mobilePhone; }
            private set
            {
                if (value.Length != 10 && value.Length != 13)
                {
                    throw new System.ArgumentException("Invalid mobile number!");
                }
                this.mobilePhone = value;
            }
        }

        public string Email 
        {
            get { return this.email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new System.ArgumentException("Invalid email!");
                }
                this.email = value;
            }
        }

        public byte Course 
        {
            get { return this.course; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Invalid course!");
                }
                this.course = value;
            }
        }

        public University University { get; private set; }

        public Specialty Specialty { get; private set; }

        public Faculty Faculty { get; private set; }

        private static void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > 20)
            {
                throw new System.ArgumentException("Invalid name!");
            }
        }

        public override bool Equals(object student)
        {
            var stud = (Student)student;

            if (!this.Course.Equals(stud.Course))
            {
                return false;
            }

            if (!this.FirstName.Equals(stud.FirstName))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Univrsity:{2} SSN:{3}", this.FirstName, this.LastName, this.University, this.SSN);
        }

        public override int GetHashCode()
        {
            return this.LastName.Length ^ this.Course;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.FirstName != secondStudent.FirstName)
            {
                return false;
            }

            if (firstStudent.Course != secondStudent.Course)
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.FirstName == secondStudent.FirstName)
            {
                return false;
            }

            if (firstStudent.Course == secondStudent.Course)
            {
                return false;
            }
            return true;
        }

        //Problem 2
        public object Clone()
        {
            var clonedStudent = new Student();

            clonedStudent.FirstName = this.FirstName;
            clonedStudent.MiddleName = this.middleName;
            clonedStudent.LastName = this.LastName;
            clonedStudent.SSN = this.SSN;
            clonedStudent.MobileNumber = this.MobileNumber;
            clonedStudent.PermAddres = this.PermAddres;
            clonedStudent.Email = this.Email;
            clonedStudent.University = this.University;
            clonedStudent.Specialty = this.Specialty;
            clonedStudent.Faculty = this.Faculty;

            return clonedStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName[0] < other.FirstName[0] )
            {
                return -1;
            }
            else if (this.FirstName[0] > other.FirstName[0] )
            {
                return 1;
            }
            else if (this.FirstName[0] == other.FirstName[0] && int.Parse(this.SSN) < int.Parse(other.SSN))
            {
                return -1;
            }
            else if (this.FirstName[0] == other.FirstName[0] && int.Parse(this.SSN) > int.Parse(other.SSN))
            {
                return 1;
            }
            return 0;
        }
    }
}
