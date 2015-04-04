namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestStudentsAndWorkers
    {
        static void Main()
        {
            var students = new List<Student>();
            var workers = new List<Worker>();

            students.Add(new Student("Ivan", "Georgiev", 12));
            students.Add(new Student("Gosho", "Goshov", 8));
            students.Add(new Student("Pesho", "Todorov", 10));
            students.Add(new Student("Todor", "Georgiev", 11));
            students.Add(new Student("Stoqn", "Petkov", 7));
            students.Add(new Student("Dragan", "Draganov", 5));
            students.Add(new Student("Pesho", "Peshov", 10));
            students.Add(new Student("Gencho", "Stoqnov", 6));
            students.Add(new Student("Atanas", "Penchev", 8));
            students.Add(new Student("Nikolay", "Nikolov", 4));

            var sortedStudents = students.OrderBy(st => st.Grade);

            Console.WriteLine(new string('=', 70));            

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            workers.Add(new Worker("Stoqn", "Penkov", 230, 6));
            workers.Add(new Worker("Petko", "Aleksandrov", 180, 8));
            workers.Add(new Worker("Sasho", "Krustev", 190, 6));
            workers.Add(new Worker("Grigor", "Nenkov", 250, 6));
            workers.Add(new Worker("Rosen", "Genchev", 300, 6));
            workers.Add(new Worker("Andrei", "Ognqnov", 120, 4));
            workers.Add(new Worker("Pesho", "Peshov", 230, 8));
            workers.Add(new Worker("Atanas", "Chavdarov", 200, 8));
            workers.Add(new Worker("Hristo", "Ganchev", 210, 4));
            workers.Add(new Worker("Viktor", "Stoqnov", 230, 8));

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine(new string('=', 70));

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            var merged = new List<Human>();

            merged.AddRange(students);
            merged.AddRange(workers);
          
            var sortedMerged = merged.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.WriteLine(new string('=', 70));

            foreach (var human in sortedMerged)
            {
                Console.WriteLine("{0, -10} {1, -15}",human.FirstName, human.LastName);
            }
        }
    }
}
