namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    public class StudentsMain
    {
        static void Main()
        {
            var students = new Student[] 
            {
                new Student("Ivan", "Petkov", 15),
                new Student("Angel", "Georgiev", 25),
                new Student("Pesho", "Atanasov", 23),
                new Student("Stoqn", "Dimitrov", 19),
                new Student("Angel", "Ivanov", 33),
            };

            //Problem 3. First before last

            //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            //Use LINQ query operators.

            var filteredStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("Students whose first name is before its last name:");

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student);
            }

            //Problem 4. Age range

            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            var studentsAgeRange =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("\nStudents with age between 18 and 24:");

            foreach (var student in studentsAgeRange)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //Problem 5. Order students

            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
            //by first name and last name in descending order.
            //Rewrite the same with LINQ.

            Console.WriteLine("\nOrdered students:");

            //using extension methods
            var sortedStudentsExt = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            Console.WriteLine("Using extension methods.");

            foreach (var student in sortedStudentsExt)
            {
                Console.WriteLine(student);
            }

            //using LINQ query
            var sortedStudentsLinqQuery =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("\nUsing LINQ query.");

            foreach (var student in sortedStudentsExt)
            {
                Console.WriteLine(student);
            }
        }
    }
}
