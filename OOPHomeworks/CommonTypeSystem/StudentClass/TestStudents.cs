//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone,
//e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//Problem 2. IClonable
//Add implementations of the ICloneable interface. 
//The Clone() method should deeply copy all object's fields into a new object of type Student.

//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
//and by social security number (as second criteria, in increasing order).

namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestStudents
    {
        public static void Main()
        {
            var student = new Student("Ivan", "Ivanov", "Draganov", "353406", "Sofia", "0888256859", "someemail@abv.bg", 3, University.TUGabrovo, Specialty.AIUT, Faculty.FEA);
            var otherStudent = new Student("Ivan", "Peshov", "Peshovski", "352789", "Plovdiv", "+359857457412", "someemail@gmail.com", 3, University.TUSofia, Specialty.AIUT, Faculty.FEA);
            var anotherStudent = new Student("Asen", "Atanasov", "Petkov", "345879", "Burgas", "0889789888", "someemail@yahoo.com", 2, University.TUGabrovo, Specialty.CST, Faculty.FEA);
            
            //Equals()
            Console.WriteLine(student.Equals(otherStudent));

            //ToString()
            Console.WriteLine(student);

            //GetHashCode()
            Console.WriteLine(student.GetHashCode());
            Console.WriteLine(otherStudent.GetHashCode());

            //== and !=
            Console.WriteLine(student == otherStudent);
            Console.WriteLine(student != otherStudent);


            //Problem 2
            var clonedStudent = (Student)student.Clone();

            Console.WriteLine("\nProblem 2");

            Console.WriteLine(clonedStudent);

            //Problem 3
            var students = new SortedSet<Student>();

            students.Add(student);
            students.Add(otherStudent);
            students.Add(anotherStudent);

            Console.WriteLine("\nProblem 3");

            foreach (var st in students)
            {
                Console.WriteLine(st);
            }

        }
    }
}
