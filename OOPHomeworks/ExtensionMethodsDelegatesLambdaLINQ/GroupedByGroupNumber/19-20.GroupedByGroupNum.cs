namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentsGroups;

    public class GroupedByGroupNum
    {
        static void Main()
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

            //Problem 18. Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.
            var groupedStudents =
                from groups in students
                group groups by groups.GroupNumber;

            Console.WriteLine("Using LINQ" + new string('=', 50));
            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group {0} ", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }

            //Problem 19. Grouped by GroupName extensions
            //Rewrite the previous using extension methods.
            var secondGroupedStudents = students.GroupBy(x => x.GroupNumber);

            Console.WriteLine("Using extension methods" + new string('=', 37));

            foreach (var group in secondGroupedStudents)
            {
                Console.WriteLine("Group {0} ", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }

        }
    }
}
