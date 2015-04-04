namespace StudentsGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentGroupsApp
    {
        public static void Main()
        {
            var firstStudent = new Student("Mitko", "Ivanov", "354806", "+359888524896", "someemail@abv.bg", 2);

            firstStudent.AddMark(6);
            firstStudent.AddMark(4);
            firstStudent.AddMark(2);
            firstStudent.AddMark(5);
            firstStudent.AddMark(5);

            var secondStudent = new Student("Pesho", "Draganov", "378805", "+359889524017", "someemail@gmail.com", 1);

            secondStudent.AddMark(3);
            secondStudent.AddMark(4);
            secondStudent.AddMark(4);
            secondStudent.AddMark(2);
            secondStudent.AddMark(2);

            var thirdStudent = new Student("Gosho", "Stoqnov", "332406", "+35929858215", "someemail@yahoo.com", 2);

            thirdStudent.AddMark(6);
            thirdStudent.AddMark(6);
            thirdStudent.AddMark(5);
            thirdStudent.AddMark(5);
            thirdStudent.AddMark(4);

            var students = new List<Student> { firstStudent, secondStudent, thirdStudent };

            //Problem 9. Student groups
            //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            //Create a List<Student> with sample students. Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
            Problem9(students);

            //Problem 10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.
            Problem10(students);

            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.
            Problem11(students);

            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.
            Problem12(students);

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.
            Problem13(students);

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            Problem14(students);

            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Problem15(students);
        }

        public static void Problem9(List<Student> students)
        {
            var groupTwo =
                            from student in students
                            where student.GroupNumber == 2
                            orderby student.FirstName
                            select student;

            Console.WriteLine(new string('*', 10) + "Problem 9" + new string('*', 10));
            Console.WriteLine(string.Join("\n", groupTwo));
        }

        public static void Problem10(List<Student> students)
        {
            var groupTwo = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName).ToList();

            Console.WriteLine(new string('*', 10) + "Problem 10" + new string('*', 10));
            Console.WriteLine(string.Join("\n", groupTwo));
        }

        public static void Problem11(List<Student> students)
        {
            var abvEmail =
                from student in students
                where student.Email.Contains("abv.bg")
                select student;

            Console.WriteLine(new string('*', 10) + "Problem 11" + new string('*', 10));
            Console.WriteLine(string.Join("\n", abvEmail));
        }

        public static void Problem12(List<Student> students)
        {
            var telSofia =
                from student in students
                where student.Tel.StartsWith("+3592") || student.Tel.StartsWith("02")
                select student;

            Console.WriteLine(new string('*', 10) + "Problem 12" + new string('*', 10));
            Console.WriteLine(string.Join("\n", telSofia));
        }

        public static void Problem13(List<Student> students)
        {
            var filteredStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = string.Format("{0} {1}", student.FirstName, student.LastName), Mark = student.Marks };

            Console.WriteLine(new string('*', 10) + "Problem 13" + new string('*', 10));

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.FullName + " Marks: " + string.Join(", ", student.Mark));
            }

        }

        public static void Problem14(List<Student> students)
        {
            var filteredStudents = students.Where(x => x.Marks.FindAll(y => y == 2).Count == 2)
                .Select(x => new
                {
                    FullName = string.Format("{0} {1}", x.FirstName, x.LastName),
                    Mark = x.Marks
                });

            Console.WriteLine();
            Console.WriteLine(new string('*', 10) + "Problem 14" + new string('*', 10));

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.FullName + " Marks: " + string.Join(", ", student.Mark));
            }
        }

        public static void Problem15(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine(new string('*', 10) + "Problem 15" + new string('*', 10));

            var filteredStudents = students.Where(st => st.FN[4] == '0' && st.FN[5] == '6');

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(string.Join(", ", student.Marks));
            }
        }
    }
}
