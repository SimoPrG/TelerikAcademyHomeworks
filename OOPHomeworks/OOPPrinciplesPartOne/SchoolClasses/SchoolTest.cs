namespace SchoolClasses
{
    using System;

    public class SchoolTest
    {
        public static void Main()
        {
            var school = new School("PG Gen. Vl. Zaimov");

            //students
            var ivan = new Student("Ivan Ivanov", 100011);
            var stoyan = new Student("Stoyan Stoyanov", 100012);
            var dragan = new Student("Dragan Draganov", 200011);
            var pesho = new Student("Pesho Peshov", 200012);

            //teachers
            var ivo = new Teacher("Ivaylo Kenov");
            var niki = new Teacher("Nikolay Kostov");
            var doncho = new Teacher("Doncho Minkov");
            var evlogi = new Teacher("Evlogi Hristov");

            //classes
            var firstClass = new SchoolClass("100");
            var secondClass = new SchoolClass("200");

            //disciplines
            var geography = new Discipline("Geography", 2, 2);
            var history = new Discipline("History", 1, 2);
            var biology = new Discipline("Biology", 3, 1);
            var math = new Discipline("Math", 3, 2);
            var mpt = new Discipline("MPT", 1, 3);

            //adding classes to school
            school.AddClass(firstClass);
            school.AddClass(secondClass);

            //adding teachers and students to classes
            firstClass.AddStudents(ivan);
            firstClass.AddStudents(stoyan);
            firstClass.AddTeachers(ivo);
            firstClass.AddTeachers(evlogi);

            secondClass.AddStudents(dragan);
            secondClass.AddStudents(pesho);
            secondClass.AddTeachers(doncho);
            secondClass.AddTeachers(niki);

            //adding disciplines to teachers
            ivo.AddDisciplines(geography);
            niki.AddDisciplines(biology);
            doncho.AddDisciplines(mpt);
            doncho.AddDisciplines(geography);
            ivo.AddDisciplines(history);
            evlogi.AddDisciplines(biology);

            ivan.Comment = "I like geography!";

            doncho.Comment = "Something.";

            geography.Comment = "Surface of Earth......";

            firstClass.Comment = "Advanced.";

            Console.WriteLine("{0, 28}", school);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Class identifier: {0}", firstClass);
            Console.WriteLine("\nStudents: \n{0}", firstClass.GetStudents());
            Console.WriteLine("Teachers: \n{0}", firstClass.GetTeachers());
            Console.WriteLine("Teacher's disciplines: ");
            Console.WriteLine("{0}\n{1}",ivo, ivo.GetDisciplines());
            Console.WriteLine("{0}\n{1}", evlogi, evlogi.GetDisciplines());

            Console.WriteLine("Comments:");
            Console.WriteLine("{0}: {1}", ivan.Name, ivan.Comment);
            Console.WriteLine("{0}: {1}", geography.Name, geography.Comment);
        }
    }
}
